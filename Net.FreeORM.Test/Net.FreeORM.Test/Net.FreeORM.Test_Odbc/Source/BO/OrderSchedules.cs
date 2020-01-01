using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class OrderSchedules : BaseBO
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

		private int _ParameterId;
		public int ParameterId
		{
			set { _ParameterId = value; OnPropertyChanged("ParameterId"); }
			get { return _ParameterId; }
		}

		private DateTime _ScheduleTime;
		public DateTime ScheduleTime
		{
			set { _ScheduleTime = value; OnPropertyChanged("ScheduleTime"); }
			get { return _ScheduleTime; }
		}

		private int _ScheduleStatus;
		public int ScheduleStatus
		{
			set { _ScheduleStatus = value; OnPropertyChanged("ScheduleStatus"); }
			get { return _ScheduleStatus; }
		}

		private byte _ScheduleStandartTimeId;
		public byte ScheduleStandartTimeId
		{
			set { _ScheduleStandartTimeId = value; OnPropertyChanged("ScheduleStandartTimeId"); }
			get { return _ScheduleStandartTimeId; }
		}

		public override string GetTableName()
		{
			return "OrderSchedules";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(OrderSchedulesDL _orderschedulesdlDL = new OrderSchedulesDL())
				{
					return _orderschedulesdlDL.Insert(this);
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
				using(OrderSchedulesDL _orderschedulesdlDL = new OrderSchedulesDL())
				{
					return _orderschedulesdlDL.InsertAndGetId(this);
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
				using(OrderSchedulesDL _orderschedulesdlDL = new OrderSchedulesDL())
				{
					return _orderschedulesdlDL.Update(this);
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
				using(OrderSchedulesDL _orderschedulesdlDL = new OrderSchedulesDL())
				{
					return _orderschedulesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
