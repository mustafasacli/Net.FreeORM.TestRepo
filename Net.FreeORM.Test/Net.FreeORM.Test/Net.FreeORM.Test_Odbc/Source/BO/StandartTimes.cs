using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class StandartTimes : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TimeName;
		public string TimeName
		{
			set { _TimeName = value; OnPropertyChanged("TimeName"); }
			get { return _TimeName; }
		}

		private int _TimeNumber;
		public int TimeNumber
		{
			set { _TimeNumber = value; OnPropertyChanged("TimeNumber"); }
			get { return _TimeNumber; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "StandartTimes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(StandartTimesDL _standarttimesdlDL = new StandartTimesDL())
				{
					return _standarttimesdlDL.Insert(this);
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
				using(StandartTimesDL _standarttimesdlDL = new StandartTimesDL())
				{
					return _standarttimesdlDL.InsertAndGetId(this);
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
				using(StandartTimesDL _standarttimesdlDL = new StandartTimesDL())
				{
					return _standarttimesdlDL.Update(this);
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
				using(StandartTimesDL _standarttimesdlDL = new StandartTimesDL())
				{
					return _standarttimesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
