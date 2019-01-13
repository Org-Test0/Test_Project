using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bonus
{
    public class Invoice
    {
        public long ClientID
        {
            get;
            set;
        }
        public long CustomerID
        {
            get;
            set;
        }

        public double PurchaseAmount
        {
            get;
            set;
        }


        public string DocumentNumber
        {
            get;
            set;
        }


        public DateTime DocumentDate
        {
            get;
            set;
        }

    }
}
