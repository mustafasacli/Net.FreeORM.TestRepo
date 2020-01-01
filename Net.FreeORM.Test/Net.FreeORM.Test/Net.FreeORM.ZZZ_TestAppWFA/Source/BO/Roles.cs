using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class Roles : BaseBO
	{
		private int _OBJID;
		public int OBJID
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
			return "Roles";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(RolesDL _rolesdlDL = new RolesDL())
				{
					return _rolesdlDL.Insert(this);
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
				using(RolesDL _rolesdlDL = new RolesDL())
				{
					return _rolesdlDL.InsertAndGetId(this);
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
				using(RolesDL _rolesdlDL = new RolesDL())
				{
					return _rolesdlDL.Update(this);
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
				using(RolesDL _rolesdlDL = new RolesDL())
				{
					return _rolesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
