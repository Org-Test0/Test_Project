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
using System.Collections.Generic;
using System.Web.Services;

namespace Bonus
{
    public abstract class Rule
    {
        public static BounsLinqDataContext bounsLinq = new BounsLinqDataContext();

        public RuleData RuleData
        {
            get;
            set;
        }

        #region Abstracts
        public abstract void SaveNewBonusRule();

        public abstract void UpdateBonusRule();

        public abstract int GetRuleInvoicePoints(Invoice invoice);
       
        #endregion

        #region Static functions
        public static int GetInvoicePoints(Invoice invoice)
        {
            int points = 0;

            var bonusRules = bounsLinq.BonusRules_SelectByClientID(invoice.ClientID);

            foreach (BonusRules_SelectByClientIDResult dbRule in bonusRules)
            {
                Rule rule=null;
                switch (dbRule.RuleTypeID.Value)
                {
                    case (int)RuleTypes.PurchaseAmount:
                        rule = new PurchaseAmountRule() { RuleData = new RuleData() { Active = dbRule.Active.Value, ID = dbRule.ID, ClientID = dbRule.ClientID, StartDate = dbRule.StartDate.Value, EndDate = dbRule.EndDate.Value, Points = dbRule.Points.Value, RuleTypeID = dbRule.RuleTypeID.Value, Value1 = dbRule.Value1, Value2 = dbRule.Value2 } };
                       

                        break;
                }

                if(rule!=null)
                    points+=rule.GetRuleInvoicePoints(invoice);
            }

            return points;
        }
        
        public static  Rule CreateRule(RuleData ruleData )
        {
            Rule rule = null;
            switch (ruleData.RuleTypeID)
            {
                case (int)RuleTypes.PurchaseAmount:
                    rule = new PurchaseAmountRule() ;
                    rule.RuleData = ruleData;
                    break;
            }
            return rule;

        }
        #endregion
    }
}
