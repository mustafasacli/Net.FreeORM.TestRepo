using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class StudentTrain : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _StudentId;
		public int StudentId
		{
			set { _StudentId = value; OnPropertyChanged("StudentId"); }
			get { return _StudentId; }
		}

		private int _AvailableTrainId;
		public int AvailableTrainId
		{
			set { _AvailableTrainId = value; OnPropertyChanged("AvailableTrainId"); }
			get { return _AvailableTrainId; }
		}

		private int _TrainTypeId;
		public int TrainTypeId
		{
			set { _TrainTypeId = value; OnPropertyChanged("TrainTypeId"); }
			get { return _TrainTypeId; }
		}

		public override string GetTableName()
		{
			return "StudentTrain";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(StudentTrainDL _studenttraindlDL = new StudentTrainDL())
				{
					return _studenttraindlDL.Insert(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int InsertAndGetId()
		{
			try
			{
				using(StudentTrainDL _studenttraindlDL = new StudentTrainDL())
				{
					return _studenttraindlDL.InsertAndGetId(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Update()
		{
			try
			{
				using(StudentTrainDL _studenttraindlDL = new StudentTrainDL())
				{
					return _studenttraindlDL.Update(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Delete()
		{
			try
			{
				using(StudentTrainDL _studenttraindlDL = new StudentTrainDL())
				{
					return _studenttraindlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
