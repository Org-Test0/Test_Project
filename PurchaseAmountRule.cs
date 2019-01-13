using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bonus
{
    public class PurchaseAmountRule : Rule
    {
     
        public override void SaveNewBonusRule()
        {
            bounsLinq.BonusRules_Insert(this.RuleData.ClientID, (int)RuleTypes.PurchaseAmount, this.RuleData.Points, this.RuleData.StartDate, this.RuleData.EndDate, this.RuleData.Active, this.RuleData.Value1, this.RuleData.Value2);
        }

        public override void UpdateBonusRule()
        {
            bounsLinq.BonusRules_UpdateById(this.RuleData.ID, this.RuleData.ClientID, (int)RuleTypes.PurchaseAmount, this.RuleData.Points, this.RuleData.StartDate, this.RuleData.EndDate, this.RuleData.Value1, this.RuleData.Value2);
        }

        public override int GetRuleInvoicePoints(Invoice invoice)
        {

            int points = 0;
            if (invoice.PurchaseAmount >= double.Parse(this.RuleData.Value1))
            {
                int count = (int)(invoice.PurchaseAmount / double.Parse(this.RuleData.Value1));
                points = count*this.RuleData.Points;
            }
            return points;
        }
    }
}
