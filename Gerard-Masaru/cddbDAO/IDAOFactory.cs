using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.cddbDAO
{
    interface IDAOFactory
    {
        /// <summary>
        /// Method returns IAblumDAO object
        /// </summary>
        /// <returns>IAlbumDAO</returns>
         IAlbumDAO getAlbumDAO();
        
        /// <summary>
        /// Method returns IArtistDAO object
        /// </summary>
        /// <returns>IArtistDAO</returns>
         IArtistDAO getArtistDAO();
        
        /// <summary>
        /// Method releases
        /// </summary>
         void release();
        
         void initStorage();

         IDAOOperations getDAOOperations();
    }
}
