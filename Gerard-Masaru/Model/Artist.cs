using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.Model
{
   /// <summary>
   /// Represents one artist. An Artist can have several albums
   /// </summary>
    class Artist
    {
        private string name;
        private List<Album> albums = new List<Album>();
            
     
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }       

        }

        public List<Album> Albums
        {
            get { return this.albums; }
            
        }
        
        /// <summary>
        /// Default constructor, adds an artist to database
        /// </summary>
        /// <param name="name">Artists name</param>
        public Artist(string name)
        {
            this.name = name;
            
        }

        public Artist(string name, List<Album> albums)
        {
            this.name = name;
            this.albums = albums;
        }

        /// <summary>
        /// Method adds a new album to the artist
        /// </summary>
        /// <param name="album">An album to be added</param>
        public void addAlbum(Album album)
        {
            albums.Add(album);
        }

        public override string ToString()
        {
            return name;
        }

        public void removeAlbum(Album album)
        {
            albums.Remove(album);
        }



    }
}
