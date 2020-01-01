using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class Position : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _PositionName;
		public string PositionName
		{
			set { _PositionName = value; OnPropertyChanged("PositionName"); }
			get { return _PositionName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Position";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(PositionDL _positiondlDL = new PositionDL())
				{
					return _positiondlDL.Insert(this);
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
				using(PositionDL _positiondlDL = new PositionDL())
				{
					return _positiondlDL.InsertAndGetId(this);
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
				using(PositionDL _positiondlDL = new PositionDL())
				{
					return _positiondlDL.Update(this);
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
				using(PositionDL _positiondlDL = new PositionDL())
				{
					return _positiondlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
