using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Role : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _RoleName;
		public string RoleName
		{
			set { _RoleName = value; OnPropertyChanged("RoleName"); }
			get { return _RoleName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Role";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(RoleDL _roledlDL = new RoleDL())
				{
					return _roledlDL.Insert(this);
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
				using(RoleDL _roledlDL = new RoleDL())
				{
					return _roledlDL.InsertAndGetId(this);
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
				using(RoleDL _roledlDL = new RoleDL())
				{
					return _roledlDL.Update(this);
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
				using(RoleDL _roledlDL = new RoleDL())
				{
					return _roledlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
