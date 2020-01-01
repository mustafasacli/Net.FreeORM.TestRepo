using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class OrderPriority : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _PriorityName;
		public string PriorityName
		{
			set { _PriorityName = value; OnPropertyChanged("PriorityName"); }
			get { return _PriorityName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "OrderPriority";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(OrderPriorityDL _orderprioritydlDL = new OrderPriorityDL())
				{
					return _orderprioritydlDL.Insert(this);
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
				using(OrderPriorityDL _orderprioritydlDL = new OrderPriorityDL())
				{
					return _orderprioritydlDL.InsertAndGetId(this);
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
				using(OrderPriorityDL _orderprioritydlDL = new OrderPriorityDL())
				{
					return _orderprioritydlDL.Update(this);
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
				using(OrderPriorityDL _orderprioritydlDL = new OrderPriorityDL())
				{
					return _orderprioritydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
