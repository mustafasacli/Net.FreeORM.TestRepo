using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class OrderStatus : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _OrderStatusName;
		public string OrderStatusName
		{
			set { _OrderStatusName = value; OnPropertyChanged("OrderStatusName"); }
			get { return _OrderStatusName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "OrderStatus";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(OrderStatusDL _orderstatusdlDL = new OrderStatusDL())
				{
					return _orderstatusdlDL.Insert(this);
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
				using(OrderStatusDL _orderstatusdlDL = new OrderStatusDL())
				{
					return _orderstatusdlDL.InsertAndGetId(this);
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
				using(OrderStatusDL _orderstatusdlDL = new OrderStatusDL())
				{
					return _orderstatusdlDL.Update(this);
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
				using(OrderStatusDL _orderstatusdlDL = new OrderStatusDL())
				{
					return _orderstatusdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
