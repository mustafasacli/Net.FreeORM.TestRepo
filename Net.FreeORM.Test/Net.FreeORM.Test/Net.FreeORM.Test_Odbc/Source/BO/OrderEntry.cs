using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class OrderEntry : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _PatientId;
		public int PatientId
		{
			set { _PatientId = value; OnPropertyChanged("PatientId"); }
			get { return _PatientId; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		private int _CreatedByUser;
		public int CreatedByUser
		{
			set { _CreatedByUser = value; OnPropertyChanged("CreatedByUser"); }
			get { return _CreatedByUser; }
		}

		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{
			set { _CreatedDate = value; OnPropertyChanged("CreatedDate"); }
			get { return _CreatedDate; }
		}

		private int _Priority;
		public int Priority
		{
			set { _Priority = value; OnPropertyChanged("Priority"); }
			get { return _Priority; }
		}

		private DateTime _OrderStartTime;
		public DateTime OrderStartTime
		{
			set { _OrderStartTime = value; OnPropertyChanged("OrderStartTime"); }
			get { return _OrderStartTime; }
		}

		private DateTime _OrderEndTime;
		public DateTime OrderEndTime
		{
			set { _OrderEndTime = value; OnPropertyChanged("OrderEndTime"); }
			get { return _OrderEndTime; }
		}

		private int _OrderStatus;
		public int OrderStatus
		{
			set { _OrderStatus = value; OnPropertyChanged("OrderStatus"); }
			get { return _OrderStatus; }
		}

		private int _ApprovedByUser;
		public int ApprovedByUser
		{
			set { _ApprovedByUser = value; OnPropertyChanged("ApprovedByUser"); }
			get { return _ApprovedByUser; }
		}

		private DateTime _ApprovedDate;
		public DateTime ApprovedDate
		{
			set { _ApprovedDate = value; OnPropertyChanged("ApprovedDate"); }
			get { return _ApprovedDate; }
		}

		private int _Administer;
		public int Administer
		{
			set { _Administer = value; OnPropertyChanged("Administer"); }
			get { return _Administer; }
		}

		private int _OrderCategory;
		public int OrderCategory
		{
			set { _OrderCategory = value; OnPropertyChanged("OrderCategory"); }
			get { return _OrderCategory; }
		}

		private int _Location;
		public int Location
		{
			set { _Location = value; OnPropertyChanged("Location"); }
			get { return _Location; }
		}

		private string _Remarks;
		public string Remarks
		{
			set { _Remarks = value; OnPropertyChanged("Remarks"); }
			get { return _Remarks; }
		}

		private int _GiveInPerKg;
		public int GiveInPerKg
		{
			set { _GiveInPerKg = value; OnPropertyChanged("GiveInPerKg"); }
			get { return _GiveInPerKg; }
		}

		private int _PatientWeight;
		public int PatientWeight
		{
			set { _PatientWeight = value; OnPropertyChanged("PatientWeight"); }
			get { return _PatientWeight; }
		}

		private string _OrderParametersXML;
		public string OrderParametersXML
		{
			set { _OrderParametersXML = value; OnPropertyChanged("OrderParametersXML"); }
			get { return _OrderParametersXML; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		private int _UpdateByUser;
		public int UpdateByUser
		{
			set { _UpdateByUser = value; OnPropertyChanged("UpdateByUser"); }
			get { return _UpdateByUser; }
		}

		private int _IsVerbal;
		public int IsVerbal
		{
			set { _IsVerbal = value; OnPropertyChanged("IsVerbal"); }
			get { return _IsVerbal; }
		}

		private int _OrderOwner;
		public int OrderOwner
		{
			set { _OrderOwner = value; OnPropertyChanged("OrderOwner"); }
			get { return _OrderOwner; }
		}

		public override string GetTableName()
		{
			return "OrderEntry";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(OrderEntryDL _orderentrydlDL = new OrderEntryDL())
				{
					return _orderentrydlDL.Insert(this);
				}
			}
			catch
			{
				throw;
			}
		}

		internal int InsertAndGetId()
		{
			try
			{
				using(OrderEntryDL _orderentrydlDL = new OrderEntryDL())
				{
					return _orderentrydlDL.InsertAndGetId(this);
				}
			}
			catch
			{
				throw;
			}
		}

		internal int Update()
		{
			try
			{
				using(OrderEntryDL _orderentrydlDL = new OrderEntryDL())
				{
					return _orderentrydlDL.Update(this);
				}
			}
			catch
			{
				throw;
			}
		}

		internal int Delete()
		{
			try
			{
				using(OrderEntryDL _orderentrydlDL = new OrderEntryDL())
				{
					return _orderentrydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
