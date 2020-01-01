using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Department : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _DepartmentName;
		public string DepartmentName
		{
			set { _DepartmentName = value; OnPropertyChanged("DepartmentName"); }
			get { return _DepartmentName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Department";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(DepartmentDL _departmentdlDL = new DepartmentDL())
				{
					return _departmentdlDL.Insert(this);
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
				using(DepartmentDL _departmentdlDL = new DepartmentDL())
				{
					return _departmentdlDL.InsertAndGetId(this);
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
				using(DepartmentDL _departmentdlDL = new DepartmentDL())
				{
					return _departmentdlDL.Update(this);
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
				using(DepartmentDL _departmentdlDL = new DepartmentDL())
				{
					return _departmentdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
