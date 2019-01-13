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
    public class Gift
    {
        public Int64 GiftID
        {
            get;
            set;
        }             
        public int? GiftPoints
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
     
    }
}
