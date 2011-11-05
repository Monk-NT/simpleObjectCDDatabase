using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.cddbDAO.db4oAccess
{
    class DAOFactoryDb4oimpl : IDAOFactory, IDAOOperations
    {
        private IAlbumDAO AlbumDAO;
        private IArtistDAO ArtistDAO;

        public DAOFactoryDb4oimpl()
        {
            AlbumDAO = new AlbumDAOdb4o();
            ArtistDAO = new ArtistDAOdb4o();
        }

        public IAlbumDAO getAlbumDAO()
        {
            return AlbumDAO;
        }

        public IArtistDAO getArtistDAO()
        {
            return ArtistDAO;
        }

        public void release()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// initStorage is an empty method because of the nature of the OODBs 
        /// </summary>
        public void initStorage()
        {
        }


        public IDAOOperations getDAOOperations()
        {
            return this;
        }

        public object getObject()
        {
            throw new NotImplementedException();
        }

        public void closeObject()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method begins transaction
        /// </summary>
        public void beginTransaction()
        {
            throw new NotImplementedException();
        }

        public void commitTransaction()
        {
            throw new NotImplementedException();
        }

        public void rollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public void rollbackTransactionIfNeeded()
        {
            throw new NotImplementedException();
        }
    }
}
