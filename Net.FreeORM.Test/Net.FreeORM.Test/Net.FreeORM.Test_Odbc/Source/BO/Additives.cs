using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Additives : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _AdditiveName;
		public string AdditiveName
		{
			set { _AdditiveName = value; OnPropertyChanged("AdditiveName"); }
			get { return _AdditiveName; }
		}

		private int _UnitSetId;
		public int UnitSetId
		{
			set { _UnitSetId = value; OnPropertyChanged("UnitSetId"); }
			get { return _UnitSetId; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Additives";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(AdditivesDL _additivesdlDL = new AdditivesDL())
				{
					return _additivesdlDL.Insert(this);
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
				using(AdditivesDL _additivesdlDL = new AdditivesDL())
				{
					return _additivesdlDL.InsertAndGetId(this);
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
				using(AdditivesDL _additivesdlDL = new AdditivesDL())
				{
					return _additivesdlDL.Update(this);
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
				using(AdditivesDL _additivesdlDL = new AdditivesDL())
				{
					return _additivesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
