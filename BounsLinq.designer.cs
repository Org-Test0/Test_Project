﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="MobiMarket")]
	public partial class BounsLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion

    public BounsLinqDataContext() :
        base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MobiMarketConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}

		public BounsLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BounsLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BounsLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BounsLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[Function(Name="dbo.BonusRules_DeleteById")]
		public int BonusRules_DeleteById([Parameter(Name="ID", DbType="BigInt")] System.Nullable<long> iD, [Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, clientID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.GiftItems_UpdatePoints")]
		public int GiftItems_UpdatePoints([Parameter(Name="GiftID", DbType="BigInt")] System.Nullable<long> giftID, [Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="GiftPoints", DbType="Int")] System.Nullable<int> giftPoints)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), giftID, clientID, giftPoints);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusPointsTransactions_Insert")]
		public int BonusPointsTransactions_Insert([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="CustomerID", DbType="BigInt")] System.Nullable<long> customerID, [Parameter(Name="DebitAmount", DbType="Int")] System.Nullable<int> debitAmount, [Parameter(Name="CreditAmount", DbType="Int")] System.Nullable<int> creditAmount, [Parameter(Name="Notes", DbType="NVarChar(200)")] string notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, customerID, debitAmount, creditAmount, notes);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.CustomerPurchases_SelectByCustomerID")]
		public ISingleResult<CustomerPurchases_SelectByCustomerIDResult> CustomerPurchases_SelectByCustomerID([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="CustomerID", DbType="BigInt")] System.Nullable<long> customerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, customerID);
			return ((ISingleResult<CustomerPurchases_SelectByCustomerIDResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.Customers_SelectCustomerPoints")]
		public ISingleResult<Customers_SelectCustomerPointsResult> Customers_SelectCustomerPoints([Parameter(Name="CustomerID", DbType="BigInt")] System.Nullable<long> customerID, [Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), customerID, clientID);
			return ((ISingleResult<Customers_SelectCustomerPointsResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.Customers_SelectByClientID")]
		public ISingleResult<Customers_SelectByClientIDResult> Customers_SelectByClientID([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID);
			return ((ISingleResult<Customers_SelectByClientIDResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.GiftItems_GetAvailableGifts")]
		public ISingleResult<GiftItems_GetAvailableGiftsResult> GiftItems_GetAvailableGifts([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="Points", DbType="Int")] System.Nullable<int> points)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, points);
			return ((ISingleResult<GiftItems_GetAvailableGiftsResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusRules_Insert")]
		public int BonusRules_Insert([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="RuleTypeID", DbType="Int")] System.Nullable<int> ruleTypeID, [Parameter(Name="Points", DbType="Int")] System.Nullable<int> points, [Parameter(Name="StartDate", DbType="DateTime")] System.Nullable<System.DateTime> startDate, [Parameter(Name="EndDate", DbType="DateTime")] System.Nullable<System.DateTime> endDate, [Parameter(Name="Active", DbType="Bit")] System.Nullable<bool> active, [Parameter(Name="Value1", DbType="NVarChar(200)")] string value1, [Parameter(Name="Value2", DbType="NVarChar(200)")] string value2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, ruleTypeID, points, startDate, endDate, active, value1, value2);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusRules_SelectByClientID")]
		public ISingleResult<BonusRules_SelectByClientIDResult> BonusRules_SelectByClientID([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID);
			return ((ISingleResult<BonusRules_SelectByClientIDResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusRules_SelectById")]
		public ISingleResult<BonusRules_SelectByIdResult> BonusRules_SelectById([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="ID", DbType="BigInt")] System.Nullable<long> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, iD);
			return ((ISingleResult<BonusRules_SelectByIdResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusRules_UpdateById")]
		public int BonusRules_UpdateById([Parameter(Name="ID", DbType="BigInt")] System.Nullable<long> iD, [Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="RuleTypeID", DbType="Int")] System.Nullable<int> ruleTypeID, [Parameter(Name="Points", DbType="Int")] System.Nullable<int> points, [Parameter(Name="StartDate", DbType="DateTime")] System.Nullable<System.DateTime> startDate, [Parameter(Name="EndDate", DbType="DateTime")] System.Nullable<System.DateTime> endDate, [Parameter(Name="Value1", DbType="NVarChar(200)")] string value1, [Parameter(Name="Value2", DbType="NVarChar(200)")] string value2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, clientID, ruleTypeID, points, startDate, endDate, value1, value2);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusRules_UpdateStatus")]
		public int BonusRules_UpdateStatus([Parameter(Name="ID", DbType="BigInt")] System.Nullable<long> iD, [Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, clientID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.deliveredGift_InsertByBonus")]
		public int deliveredGift_InsertByBonus([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="CustomerID", DbType="BigInt")] System.Nullable<long> customerID, [Parameter(Name="WinningDate", DbType="DateTime")] System.Nullable<System.DateTime> winningDate, [Parameter(Name="GiftStatus", DbType="Bit")] System.Nullable<bool> giftStatus, [Parameter(Name="BrancheID", DbType="BigInt")] System.Nullable<long> brancheID, [Parameter(Name="GiftID", DbType="BigInt")] System.Nullable<long> giftID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, customerID, winningDate, giftStatus, brancheID, giftID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusPointsTransactions_SelectCustomersTotalPoints")]
		public ISingleResult<BonusPointsTransactions_SelectCustomersTotalPointsResult> BonusPointsTransactions_SelectCustomersTotalPoints([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="MaritalStatus", DbType="Int")] System.Nullable<int> maritalStatus, [Parameter(Name="Gender", DbType="Int")] System.Nullable<int> gender, [Parameter(Name="Phone", DbType="NVarChar(50)")] string phone, [Parameter(Name="Job", DbType="NVarChar(100)")] string job, [Parameter(Name="City", DbType="BigInt")] System.Nullable<long> city)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, maritalStatus, gender, phone, job, city);
			return ((ISingleResult<BonusPointsTransactions_SelectCustomersTotalPointsResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BonusPointsTransactions_SelectCustomersPoints")]
		public ISingleResult<BonusPointsTransactions_SelectCustomersPointsResult> BonusPointsTransactions_SelectCustomersPoints([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="MaritalStatus", DbType="Int")] System.Nullable<int> maritalStatus, [Parameter(Name="Gender", DbType="Int")] System.Nullable<int> gender, [Parameter(Name="Phone", DbType="NVarChar(50)")] string phone, [Parameter(Name="Job", DbType="NVarChar(100)")] string job, [Parameter(Name="City", DbType="BigInt")] System.Nullable<long> city, [Parameter(Name="FromDate", DbType="DateTime")] System.Nullable<System.DateTime> fromDate, [Parameter(Name="ToDate", DbType="DateTime")] System.Nullable<System.DateTime> toDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, maritalStatus, gender, phone, job, city, fromDate, toDate);
			return ((ISingleResult<BonusPointsTransactions_SelectCustomersPointsResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.BounsGifts_Given_To_Customers_In_Period")]
		public ISingleResult<BounsGifts_Given_To_Customers_In_PeriodResult> BounsGifts_Given_To_Customers_In_Period([Parameter(Name="ClientID", DbType="BigInt")] System.Nullable<long> clientID, [Parameter(Name="FromDate", DbType="DateTime")] System.Nullable<System.DateTime> fromDate, [Parameter(Name="ToDate", DbType="DateTime")] System.Nullable<System.DateTime> toDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clientID, fromDate, toDate);
			return ((ISingleResult<BounsGifts_Given_To_Customers_In_PeriodResult>)(result.ReturnValue));
		}
	}
	
	public partial class CustomerPurchases_SelectByCustomerIDResult
	{
		
		private long _ID;
		
		private System.Nullable<long> _ClientID;
		
		private System.Nullable<long> _CustomerID;
		
		private System.Nullable<double> _PurchaseAmount;
		
		private string _DocumentNumber;
		
		private System.Nullable<System.DateTime> _DocumentDate;
		
		public CustomerPurchases_SelectByCustomerIDResult()
		{
		}
		
		[Column(Storage="_ID", DbType="BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt")]
		public System.Nullable<long> ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_CustomerID", DbType="BigInt")]
		public System.Nullable<long> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[Column(Storage="_PurchaseAmount", DbType="Float")]
		public System.Nullable<double> PurchaseAmount
		{
			get
			{
				return this._PurchaseAmount;
			}
			set
			{
				if ((this._PurchaseAmount != value))
				{
					this._PurchaseAmount = value;
				}
			}
		}
		
		[Column(Storage="_DocumentNumber", DbType="VarChar(30)")]
		public string DocumentNumber
		{
			get
			{
				return this._DocumentNumber;
			}
			set
			{
				if ((this._DocumentNumber != value))
				{
					this._DocumentNumber = value;
				}
			}
		}
		
		[Column(Storage="_DocumentDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DocumentDate
		{
			get
			{
				return this._DocumentDate;
			}
			set
			{
				if ((this._DocumentDate != value))
				{
					this._DocumentDate = value;
				}
			}
		}
	}
	
	public partial class Customers_SelectCustomerPointsResult
	{
		
		private System.Nullable<int> _Bonuspoints;
		
		public Customers_SelectCustomerPointsResult()
		{
		}
		
		[Column(Storage="_Bonuspoints", DbType="Int")]
		public System.Nullable<int> Bonuspoints
		{
			get
			{
				return this._Bonuspoints;
			}
			set
			{
				if ((this._Bonuspoints != value))
				{
					this._Bonuspoints = value;
				}
			}
		}
	}
	
	public partial class Customers_SelectByClientIDResult
	{
		
		private long _CustomerID;
		
		private long _ClientID;
		
		private string _CustomerName;
		
		private System.Nullable<bool> _Gender;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private System.Nullable<long> _CityID;
		
		private System.Nullable<int> _MaritalStatusID;
		
		private string _Phone;
		
		private string _Job;
		
		private System.Nullable<int> _Bonuspoints;
		
		private System.Nullable<bool> _CompletedData;
		
		public Customers_SelectByClientIDResult()
		{
		}
		
		[Column(Storage="_CustomerID", DbType="BigInt NOT NULL")]
		public long CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt NOT NULL")]
		public long ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_CustomerName", DbType="NVarChar(100)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this._CustomerName = value;
				}
			}
		}
		
		[Column(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[Column(Storage="_BirthDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this._BirthDate = value;
				}
			}
		}
		
		[Column(Storage="_CityID", DbType="BigInt")]
		public System.Nullable<long> CityID
		{
			get
			{
				return this._CityID;
			}
			set
			{
				if ((this._CityID != value))
				{
					this._CityID = value;
				}
			}
		}
		
		[Column(Storage="_MaritalStatusID", DbType="Int")]
		public System.Nullable<int> MaritalStatusID
		{
			get
			{
				return this._MaritalStatusID;
			}
			set
			{
				if ((this._MaritalStatusID != value))
				{
					this._MaritalStatusID = value;
				}
			}
		}
		
		[Column(Storage="_Phone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[Column(Storage="_Job", DbType="NVarChar(100)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this._Job = value;
				}
			}
		}
		
		[Column(Storage="_Bonuspoints", DbType="Int")]
		public System.Nullable<int> Bonuspoints
		{
			get
			{
				return this._Bonuspoints;
			}
			set
			{
				if ((this._Bonuspoints != value))
				{
					this._Bonuspoints = value;
				}
			}
		}
		
		[Column(Storage="_CompletedData", DbType="Bit")]
		public System.Nullable<bool> CompletedData
		{
			get
			{
				return this._CompletedData;
			}
			set
			{
				if ((this._CompletedData != value))
				{
					this._CompletedData = value;
				}
			}
		}
	}
	
	public partial class GiftItems_GetAvailableGiftsResult
	{
		
		private long _GiftID;
		
		private long _ClientID;
		
		private System.Nullable<double> _GiftCost;
		
		private System.Nullable<int> _GiftPoints;
		
		private string _Description;
		
		private System.Nullable<bool> _Active;
		
		private string _GiftImage;
		
		public GiftItems_GetAvailableGiftsResult()
		{
		}
		
		[Column(Storage="_GiftID", DbType="BigInt NOT NULL")]
		public long GiftID
		{
			get
			{
				return this._GiftID;
			}
			set
			{
				if ((this._GiftID != value))
				{
					this._GiftID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt NOT NULL")]
		public long ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_GiftCost", DbType="Float")]
		public System.Nullable<double> GiftCost
		{
			get
			{
				return this._GiftCost;
			}
			set
			{
				if ((this._GiftCost != value))
				{
					this._GiftCost = value;
				}
			}
		}
		
		[Column(Storage="_GiftPoints", DbType="Int")]
		public System.Nullable<int> GiftPoints
		{
			get
			{
				return this._GiftPoints;
			}
			set
			{
				if ((this._GiftPoints != value))
				{
					this._GiftPoints = value;
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[Column(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[Column(Storage="_GiftImage", DbType="NVarChar(250)")]
		public string GiftImage
		{
			get
			{
				return this._GiftImage;
			}
			set
			{
				if ((this._GiftImage != value))
				{
					this._GiftImage = value;
				}
			}
		}
	}
	
	public partial class BonusRules_SelectByClientIDResult
	{
		
		private long _ID;
		
		private long _ClientID;
		
		private System.Nullable<int> _RuleTypeID;
		
		private System.Nullable<int> _Points;
		
		private string _Value1;
		
		private string _Value2;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<bool> _Active;
		
		public BonusRules_SelectByClientIDResult()
		{
		}
		
		[Column(Storage="_ID", DbType="BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt NOT NULL")]
		public long ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_RuleTypeID", DbType="Int")]
		public System.Nullable<int> RuleTypeID
		{
			get
			{
				return this._RuleTypeID;
			}
			set
			{
				if ((this._RuleTypeID != value))
				{
					this._RuleTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Points", DbType="Int")]
		public System.Nullable<int> Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				if ((this._Points != value))
				{
					this._Points = value;
				}
			}
		}
		
		[Column(Storage="_Value1", DbType="NVarChar(200)")]
		public string Value1
		{
			get
			{
				return this._Value1;
			}
			set
			{
				if ((this._Value1 != value))
				{
					this._Value1 = value;
				}
			}
		}
		
		[Column(Storage="_Value2", DbType="NVarChar(200)")]
		public string Value2
		{
			get
			{
				return this._Value2;
			}
			set
			{
				if ((this._Value2 != value))
				{
					this._Value2 = value;
				}
			}
		}
		
		[Column(Storage="_StartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this._StartDate = value;
				}
			}
		}
		
		[Column(Storage="_EndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this._EndDate = value;
				}
			}
		}
		
		[Column(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
	}
	
	public partial class BonusRules_SelectByIdResult
	{
		
		private long _ID;
		
		private long _ClientID;
		
		private System.Nullable<int> _RuleTypeID;
		
		private System.Nullable<int> _Points;
		
		private string _Value1;
		
		private string _Value2;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<bool> _Active;
		
		public BonusRules_SelectByIdResult()
		{
		}
		
		[Column(Storage="_ID", DbType="BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt NOT NULL")]
		public long ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_RuleTypeID", DbType="Int")]
		public System.Nullable<int> RuleTypeID
		{
			get
			{
				return this._RuleTypeID;
			}
			set
			{
				if ((this._RuleTypeID != value))
				{
					this._RuleTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Points", DbType="Int")]
		public System.Nullable<int> Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				if ((this._Points != value))
				{
					this._Points = value;
				}
			}
		}
		
		[Column(Storage="_Value1", DbType="NVarChar(200)")]
		public string Value1
		{
			get
			{
				return this._Value1;
			}
			set
			{
				if ((this._Value1 != value))
				{
					this._Value1 = value;
				}
			}
		}
		
		[Column(Storage="_Value2", DbType="NVarChar(200)")]
		public string Value2
		{
			get
			{
				return this._Value2;
			}
			set
			{
				if ((this._Value2 != value))
				{
					this._Value2 = value;
				}
			}
		}
		
		[Column(Storage="_StartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this._StartDate = value;
				}
			}
		}
		
		[Column(Storage="_EndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this._EndDate = value;
				}
			}
		}
		
		[Column(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
	}
	
	public partial class BonusPointsTransactions_SelectCustomersTotalPointsResult
	{
		
		private System.Nullable<int> _Bonuspoints;
		
		public BonusPointsTransactions_SelectCustomersTotalPointsResult()
		{
		}
		
		[Column(Storage="_Bonuspoints", DbType="Int")]
		public System.Nullable<int> Bonuspoints
		{
			get
			{
				return this._Bonuspoints;
			}
			set
			{
				if ((this._Bonuspoints != value))
				{
					this._Bonuspoints = value;
				}
			}
		}
	}
	
	public partial class BonusPointsTransactions_SelectCustomersPointsResult
	{
		
		private string _CustomerName;
		
		private string _Gender;
		
		private string _Phone;
		
		private System.Nullable<int> _DebitAmount;
		
		private System.Nullable<int> _CreditAmount;
		
		private string _TransactionsDate;
		
		private string _Notes;
		
		private long _CustomerID;
		
		private long _ClientID;
		
		private long _TransactionsID;
		
		public BonusPointsTransactions_SelectCustomersPointsResult()
		{
		}
		
		[Column(Storage="_CustomerName", DbType="NVarChar(100)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this._CustomerName = value;
				}
			}
		}
		
		[Column(Storage="_Gender", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[Column(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[Column(Storage="_DebitAmount", DbType="Int")]
		public System.Nullable<int> DebitAmount
		{
			get
			{
				return this._DebitAmount;
			}
			set
			{
				if ((this._DebitAmount != value))
				{
					this._DebitAmount = value;
				}
			}
		}
		
		[Column(Storage="_CreditAmount", DbType="Int")]
		public System.Nullable<int> CreditAmount
		{
			get
			{
				return this._CreditAmount;
			}
			set
			{
				if ((this._CreditAmount != value))
				{
					this._CreditAmount = value;
				}
			}
		}
		
		[Column(Storage="_TransactionsDate", DbType="NVarChar(30)")]
		public string TransactionsDate
		{
			get
			{
				return this._TransactionsDate;
			}
			set
			{
				if ((this._TransactionsDate != value))
				{
					this._TransactionsDate = value;
				}
			}
		}
		
		[Column(Storage="_Notes", DbType="NVarChar(200)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this._Notes = value;
				}
			}
		}
		
		[Column(Storage="_CustomerID", DbType="BigInt NOT NULL")]
		public long CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[Column(Storage="_ClientID", DbType="BigInt NOT NULL")]
		public long ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this._ClientID = value;
				}
			}
		}
		
		[Column(Storage="_TransactionsID", DbType="BigInt NOT NULL")]
		public long TransactionsID
		{
			get
			{
				return this._TransactionsID;
			}
			set
			{
				if ((this._TransactionsID != value))
				{
					this._TransactionsID = value;
				}
			}
		}
	}
	
	public partial class BounsGifts_Given_To_Customers_In_PeriodResult
	{
		
		private System.Nullable<System.DateTime> _WinningDate;
		
		private System.Nullable<System.DateTime> _DeliveredDate;
		
		private string _DeliveryCode;
		
		private System.Nullable<bool> _Contest_Compain;
		
		private string _Description;
		
		private string _CustomerName;
		
		private string _Phone;
		
		private System.Nullable<double> _GiftCost;
		
		public BounsGifts_Given_To_Customers_In_PeriodResult()
		{
		}
		
		[Column(Storage="_WinningDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> WinningDate
		{
			get
			{
				return this._WinningDate;
			}
			set
			{
				if ((this._WinningDate != value))
				{
					this._WinningDate = value;
				}
			}
		}
		
		[Column(Storage="_DeliveredDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeliveredDate
		{
			get
			{
				return this._DeliveredDate;
			}
			set
			{
				if ((this._DeliveredDate != value))
				{
					this._DeliveredDate = value;
				}
			}
		}
		
		[Column(Storage="_DeliveryCode", DbType="NVarChar(50)")]
		public string DeliveryCode
		{
			get
			{
				return this._DeliveryCode;
			}
			set
			{
				if ((this._DeliveryCode != value))
				{
					this._DeliveryCode = value;
				}
			}
		}
		
		[Column(Storage="_Contest_Compain", DbType="Bit")]
		public System.Nullable<bool> Contest_Compain
		{
			get
			{
				return this._Contest_Compain;
			}
			set
			{
				if ((this._Contest_Compain != value))
				{
					this._Contest_Compain = value;
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[Column(Storage="_CustomerName", DbType="NVarChar(100)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this._CustomerName = value;
				}
			}
		}
		
		[Column(Storage="_Phone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[Column(Storage="_GiftCost", DbType="Float")]
		public System.Nullable<double> GiftCost
		{
			get
			{
				return this._GiftCost;
			}
			set
			{
				if ((this._GiftCost != value))
				{
					this._GiftCost = value;
				}
			}
		}
	}
}
#pragma warning restore 1591