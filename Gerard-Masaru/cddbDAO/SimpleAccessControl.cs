﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cddb.Model;
using Db4objects.Db4o;

namespace cddb.cddbDAO
{
    class SimpleAccessControl
    {
        IObjectContainer db;
        private static SimpleAccessControl instance = new SimpleAccessControl();

        private SimpleAccessControl() 
        {
           
        }

        public static SimpleAccessControl getInstance()
        {
            return instance;
        }

        public void openDatabase()
        {
            db = Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), "t1.yap");
        }

        public void closeDatabase()
        {
            db.Close();
        }

        public void addArtist(string name)
        {
            try
            {
                Artist veljko = new Artist("veljko");
                veljko.addAlbum(new Album("albumslika","1992"));
                db.Store(veljko);
                db.Store(new Artist(name));
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
        public void addAlbum(string artist, string cdName, string cdYear)
        {
            Artist a = new Artist(artist);
            IObjectSet res = db.QueryByExample(a);
            if (res.Count == 0)
            {
                a.addAlbum(new Album(cdName, cdYear));
                db.Store(a);
            }
            else
            {
                Artist art = (Artist)res.Next();
                art.addAlbum(new Album(cdName, cdYear));
                db.Store(art);
            }

        }
        public List<Artist> listArtistsAndAlbums()
        {
            Artist a = new Artist(null);
            IObjectSet res = db.QueryByExample(a);
            List<Artist> artists = iterateOverResult(res);
            

            return artists;
        }

        public void deleteAlbum(string artist, string albumName, string albumYear)
        {
            IObjectSet res = db.QueryByExample(new Artist(artist));
            Artist found = (Artist) res.Next();
            if (found.Albums.Count == 0)
                db.Delete(found);
            else
            {
                found.removeAlbum(new Album(albumName, albumYear));
                db.Store(found);
            }
        }

        private List<Artist> iterateOverResult(IObjectSet result)
        {
            List<Artist> artists = new List<Artist>();
            foreach (object res in result)
            {
                artists.Add((Artist)res);
            }
            return artists;
        }



    }
}
