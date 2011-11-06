using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cddb.Model
{
    /// <summary>
    /// Represents an Album
    /// </summary>
    class Album
    {
        private string cdName;
        private string cdYear;

        public string CdName
        {
            get { return this.cdName; }
            set { this.cdName = value; }
           
        }
        public string CdYear
        {
            get { return this.cdYear; }
            set { this.cdYear = value; }
            
        }
        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="cdName">Name of the album</param>
        /// <param name="cdYear">Year of publishing</param>
        public Album(string cdName, string cdYear)
        {
            this.cdName = cdName;
            this.cdYear = cdYear;
            
        }

        public override bool Equals(object obj)
        {
            if (obj is Album)
            {
                Album a = (Album)obj;
                if (this.cdName.Equals(a.cdName))
                {
                    if (this.cdYear.Equals(a.cdYear))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
