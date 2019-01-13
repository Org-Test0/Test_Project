using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Bonus
{
    public class BonusPointsTransaction
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
        public string CustomerName
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string TransactionsDate
        {
            get;
            set;
        }
        public int DebitAmount
        {
            get;
            set;
        }
        public int CreditAmount
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
    }
}
