using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class School : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _SchoolName;
		public string SchoolName
		{
			set { _SchoolName = value; OnPropertyChanged("SchoolName"); }
			get { return _SchoolName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "School";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(SchoolDL _schooldlDL = new SchoolDL())
				{
					return _schooldlDL.Insert(this);
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
				using(SchoolDL _schooldlDL = new SchoolDL())
				{
					return _schooldlDL.InsertAndGetId(this);
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
				using(SchoolDL _schooldlDL = new SchoolDL())
				{
					return _schooldlDL.Update(this);
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
				using(SchoolDL _schooldlDL = new SchoolDL())
				{
					return _schooldlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
