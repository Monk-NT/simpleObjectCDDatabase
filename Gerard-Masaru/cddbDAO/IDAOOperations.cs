using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.cddbDAO
{
    /// <summary>
    /// Represents operations interface
    /// </summary>
    interface IDAOOperations
    {
        /// <summary>
        /// Method provides the object which provides persistancy 
        /// </summary>
        /// <returns>Object which provides persistancy</returns>
         Object getObject();

        /// <summary>
        /// Method releases the object which provides persistancy
        /// </summary>
         void closeObject();

        /// <summary>
        /// Method begins the transaction
        /// </summary>
         void beginTransaction();

        /// <summary>
        /// Method ends the transaction
        /// </summary>
         void commitTransaction();

        /// <summary>
        /// Method rollbacks the last transaction
        /// </summary>
         void rollbackTransaction();

        /// <summary>
        /// Method rollbacks transaction if transaction is open
        /// </summary>
         void rollbackTransactionIfNeeded();
    }
}
