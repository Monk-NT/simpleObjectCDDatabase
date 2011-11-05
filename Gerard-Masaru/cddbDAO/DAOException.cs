using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.cddbDAO
{
    /// <summary>
    /// Base exception for all classes in DAO layer
    /// </summary>
    class DAOException : Exception
    {
        /// <summary>
        /// Initializes a new instance od DAOException
        /// </summary>
        public DAOException():base()
        {
        }
        /// <summary>
        /// Initializes a new instance od DAOException with a specific error message
        /// </summary>
        /// <param name="message">Error message</param>
        public DAOException(string message):base(message)
        {
        }
        /// <summary>
        /// Initializes a new instance od DAOException with a specific error message, and innerException which is the cause of 
        /// this exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">cause</param>
        public DAOException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        /// <summary>
        /// Initializes a new instance of DAOException with serialized data
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public DAOException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
        

    }
}
