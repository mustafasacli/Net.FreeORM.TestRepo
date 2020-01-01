using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class AvailableTrain : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _TrainId;
		public int TrainId
		{
			set { _TrainId = value; OnPropertyChanged("TrainId"); }
			get { return _TrainId; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private int _TrainClassId;
		public int TrainClassId
		{
			set { _TrainClassId = value; OnPropertyChanged("TrainClassId"); }
			get { return _TrainClassId; }
		}

		private int _TrainAmount;
		public int TrainAmount
		{
			set { _TrainAmount = value; OnPropertyChanged("TrainAmount"); }
			get { return _TrainAmount; }
		}

		private DateTime _StartTime;
		public DateTime StartTime
		{
			set { _StartTime = value; OnPropertyChanged("StartTime"); }
			get { return _StartTime; }
		}

		private DateTime _EndTime;
		public DateTime EndTime
		{
			set { _EndTime = value; OnPropertyChanged("EndTime"); }
			get { return _EndTime; }
		}

		private int _CourseType;
		public int CourseType
		{
			set { _CourseType = value; OnPropertyChanged("CourseType"); }
			get { return _CourseType; }
		}

		public override string GetTableName()
		{
			return "AvailableTrain";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(AvailableTrainDL _availabletraindlDL = new AvailableTrainDL())
				{
					return _availabletraindlDL.Insert(this);
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
				using(AvailableTrainDL _availabletraindlDL = new AvailableTrainDL())
				{
					return _availabletraindlDL.InsertAndGetId(this);
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
				using(AvailableTrainDL _availabletraindlDL = new AvailableTrainDL())
				{
					return _availabletraindlDL.Update(this);
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
				using(AvailableTrainDL _availabletraindlDL = new AvailableTrainDL())
				{
					return _availabletraindlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
