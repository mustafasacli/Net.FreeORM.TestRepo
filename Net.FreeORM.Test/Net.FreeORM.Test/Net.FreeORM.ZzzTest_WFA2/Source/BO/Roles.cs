using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
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

		internal int Insert()
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

		internal int InsertAndGetId()
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

		internal int Update()
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

		internal int Delete()
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
