using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Bonus
{
    /// <summary>
    /// Summary description for BonusSRV
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BonusSRV : System.Web.Services.WebService
    {
        BounsLinqDataContext bounsLinq = new BounsLinqDataContext();
        SMSGateway.SMSGateway sMSGateway = new Bonus.SMSGateway.SMSGateway();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void CreateBonusRule(RuleData ruleData)
        {
            try
            {
                Rule rule = Rule.CreateRule(ruleData);
                rule.RuleData = ruleData;
              
                rule.SaveNewBonusRule();
            }
            catch { }
        }
        [WebMethod]
        public void UpdateBonusRule(RuleData ruleData)
        {
            try
            {
                Rule rule = Rule.CreateRule(ruleData);
                rule.RuleData = ruleData;
                rule.UpdateBonusRule();
            }
            catch { }
        }
        [WebMethod]
        public List<RuleData> GetBonusRuleList(Int64 ClientID)
        {
            try
            {
                return bounsLinq.BonusRules_SelectByClientID(ClientID).Select(b => new RuleData() { ID = b.ID, ClientID = b.ClientID, StartDate = b.StartDate.Value, EndDate = b.EndDate.Value, RuleTypeID = b.RuleTypeID.Value, Value1=b.Value1,Value2= b.Value2,Active= b.Active.Value,Points= b.Points.Value }).ToList();
            }
            catch { return null; }
        }
        [WebMethod]
        public RuleData GetBonusRule(Int64 ClientID, Int64 ID)
        {
            try
            {
                return bounsLinq.BonusRules_SelectById(ClientID, ID).Select(b => new RuleData(){ID = b.ID, ClientID = b.ClientID, StartDate = b.StartDate.Value, EndDate = b.EndDate.Value, RuleTypeID = b.RuleTypeID.Value, Value1=b.Value1,Value2= b.Value2,Active= b.Active.Value,Points= b.Points.Value}).SingleOrDefault();
            }
            catch { return null; }
        }
        [WebMethod]
        public void ActivateAndDeactivateBonusRule(Int64 ID, Int64 ClientID)
        {
            try
            {
                bounsLinq.BonusRules_UpdateStatus(ID, ClientID);
            }
            catch { }
        }
        [WebMethod]
        public void DeleteBonusRule(Int64 BonusID, Int64 ClientID)
        {
            try
            {
                bounsLinq.BonusRules_DeleteById(BonusID, ClientID);
            }
            catch { }
        }
        [WebMethod]
        public void DefineGiftPoints(Int64 GiftID, Int64 ClientID, int? GiftPoints)
        {
            try
            {
                bounsLinq.GiftItems_UpdatePoints(GiftID, ClientID, GiftPoints);
            }
            catch { }
        }
        [WebMethod]
        public void CheckCustomerPurchases(Int64 ClientID)
        {
            var customers = bounsLinq.Customers_SelectByClientID(ClientID);
            foreach (Customers_SelectByClientIDResult customer in customers)
            {
                GetCustomerPurchases(ClientID, customer.CustomerID, customer.Phone);
            }

        }
        [WebMethod]
        public int GetCustomerPoints(Int64 ClientID, Int64 CustomerID)
        {
            int points = 0;
            try
            {
                points = bounsLinq.Customers_SelectCustomerPoints(CustomerID, ClientID).FirstOrDefault().Bonuspoints.Value;
            }
            catch
            {
                points = 0;
            }
            return points;
        }

        [WebMethod]
        public List<BonusPointsTransaction> GetCustomerTransactions(long ClientID,int MaritalStatus, int Gender, string Phone, string Job, long City, DateTime FromDate, DateTime ToDate)
        {
            return bounsLinq.BonusPointsTransactions_SelectCustomersPoints(ClientID,MaritalStatus, Gender, Phone, Job, City, FromDate, ToDate).Select(o => new BonusPointsTransaction() 
             {
                 CreditAmount = o.CreditAmount.HasValue ? o.CreditAmount.Value : 0, 
                 CustomerName = string.IsNullOrEmpty(o.CustomerName) ? "" : o.CustomerName,
                 DebitAmount = o.DebitAmount.HasValue ? o.DebitAmount.Value : 0,
                 Phone = o.Phone,
                 TransactionsDate = o.TransactionsDate, 
                 Gender=o.Gender,
             Notes=o.Notes}).ToList();
        }
        [WebMethod]
        public List<Gift> GetAvailableGifts(Int64 ClientID, int Points)
        {
            try
            {
                return bounsLinq.GiftItems_GetAvailableGifts(ClientID, Points).Select(g => new Gift() { GiftID = g.GiftID, Description = g.Description, GiftPoints = g.GiftPoints }).ToList();
            }
            catch
            {
                return null;
            }
        }
        [WebMethod]
        public void ExchangeBonus(List<Gift> gifts,long CustomerID,long ClientID,long BranchID)
        {
            //
            foreach( Gift gift in gifts)
            {
                try
                {
                    bounsLinq.deliveredGift_InsertByBonus(ClientID, CustomerID, DateTime.Now, true, BranchID, gift.GiftID);
                    bounsLinq.BonusPointsTransactions_Insert(ClientID, CustomerID, 0, gift.GiftPoints, "");
                }
                catch { }
            }
            
        }
        [WebMethod]
        public int GetCustomersPoints(long ClientID,int MaritalStatus, int Gender, string Phone, string Job, long City)
        {
            return bounsLinq.BonusPointsTransactions_SelectCustomersTotalPoints(ClientID,MaritalStatus, Gender, Phone, Job, City).FirstOrDefault().Bonuspoints.Value;
        }

        [WebMethod]
        public List<ExchangedGifts> GetExchangedGifts(Int64 GiftID, DateTime FromDate, DateTime ToDate)
        {
            return null;
        }
        [WebMethod]
        public int GetInvoicePoints(Invoice invoice)
        {
           return Rule.GetInvoicePoints(invoice);
        }
        [WebMethod]
        public List<BounsGifts_Given_To_Customers_In_PeriodResult> BounsGifts_Given_To_Customers_In_Period(Int64? ClientID, DateTime? FromDate, DateTime? ToDate)
        {
            try
            {
                List<BounsGifts_Given_To_Customers_In_PeriodResult> BounsGifts_Given_To_Customers_In_Period = bounsLinq.BounsGifts_Given_To_Customers_In_Period(ClientID, FromDate, ToDate).ToList();
                return BounsGifts_Given_To_Customers_In_Period;
            }
            catch
            {
                return null;
            }
        }

        #region Private Functions
        public void GetCustomerPurchases(Int64 ClientID, Int64 CustomerID,string Phone)
        {
            List<Invoice> invoices = bounsLinq.CustomerPurchases_SelectByCustomerID(ClientID, CustomerID).Select(o => new Invoice() { ClientID = o.ClientID.Value, CustomerID = o.CustomerID.Value, DocumentDate = o.DocumentDate.Value, DocumentNumber = o.DocumentNumber, PurchaseAmount = o.PurchaseAmount.Value }).ToList();
            int Totalpoints = 0;
            foreach (Invoice invoice in invoices)
            {
                int points = Rule.GetInvoicePoints(invoice);

                if (points > 0)
                {
                    bounsLinq.BonusPointsTransactions_Insert(ClientID, CustomerID, points, 0, "Points added from Invoice No." + invoice.DocumentNumber);
                    Totalpoints += points;
                }
            }
            if (Totalpoints > 0)
            {
                int customerPoints = GetCustomerPoints(ClientID, CustomerID);
                string sms = GetSmsText(ClientID, customerPoints);
                if (sms != "")
                {
                    sMSGateway.SendSMS(new Bonus.SMSGateway.SmsMessageItem() { ClientID = ClientID, CustomerID = CustomerID, SmsType = false, SmsText = sms, Type = 4, SendDate = DateTime.Now }, Phone);
                }
            }
        }
        private string GetSmsText(long ClientID, int Points)
        {
            List<Gift> gifts =GetAvailableGifts(ClientID,Points);
            string sms = "";
            foreach (Gift gift in gifts)
            {
                sms += gift.Description + " ,";
            }
            if (!string.IsNullOrEmpty(sms))
                sms = " Dear sir your points increased to " + Points + " point , you can now choose from following gifts " + sms;
            return sms;
        }
        #endregion



    }
}
