using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.cddbDAO.db4oAccess
{
    /// <summary>
    /// Main class from witch all other DAO classes are built
    /// </summary>
    class db4oDAOBase
    {
        private IDAOOperations daoOperations;

        /// <summary>
        /// Returns daoOperations
        /// </summary>
        /// <param name="daoOperations"></param>
        public db4oDAOBase(IDAOOperations daoOperations)
        {
            this.daoOperations = daoOperations;
        }

        protected IDAOOperations getDaoOperations()
        {
            return daoOperations;
        }
    }
}
