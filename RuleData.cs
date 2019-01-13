using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bonus
{
    public class RuleData
    {
      
        public long ID
        {
            get;
            set;
        }
        public long ClientID
        {
            get;
            set;
        }
        public int Points
        {
            get;
            set;
        }
        public DateTime StartDate
        {
            get;
            set;
        }
        public DateTime EndDate
        {
            get;
            set;
        }
        public bool Active
        {
            get;
            set;
        }
        public string Value1
        {
            get;
            set;

        }
        public string Value2
        {
            get;
            set;

        }
        public int RuleTypeID
        {
            get;
            set;
        }
       
    }


}
