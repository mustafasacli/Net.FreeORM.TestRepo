using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class RejectedOrders : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _OrderId;
		public int OrderId
		{
			set { _OrderId = value; OnPropertyChanged("OrderId"); }
			get { return _OrderId; }
		}

		private int _RejectedByUser;
		public int RejectedByUser
		{
			set { _RejectedByUser = value; OnPropertyChanged("RejectedByUser"); }
			get { return _RejectedByUser; }
		}

		private DateTime _RejectedDate;
		public DateTime RejectedDate
		{
			set { _RejectedDate = value; OnPropertyChanged("RejectedDate"); }
			get { return _RejectedDate; }
		}

		private string _RejectReason;
		public string RejectReason
		{
			set { _RejectReason = value; OnPropertyChanged("RejectReason"); }
			get { return _RejectReason; }
		}

		public override string GetTableName()
		{
			return "RejectedOrders";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(RejectedOrdersDL _rejectedordersdlDL = new RejectedOrdersDL())
				{
					return _rejectedordersdlDL.Insert(this);
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
				using(RejectedOrdersDL _rejectedordersdlDL = new RejectedOrdersDL())
				{
					return _rejectedordersdlDL.InsertAndGetId(this);
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
				using(RejectedOrdersDL _rejectedordersdlDL = new RejectedOrdersDL())
				{
					return _rejectedordersdlDL.Update(this);
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
				using(RejectedOrdersDL _rejectedordersdlDL = new RejectedOrdersDL())
				{
					return _rejectedordersdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
