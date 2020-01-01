using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class UserRole : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private int _RoleId;
		public int RoleId
		{
			set { _RoleId = value; OnPropertyChanged("RoleId"); }
			get { return _RoleId; }
		}

		public override string GetTableName()
		{
			return "UserRole";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(UserRoleDL _userroledlDL = new UserRoleDL())
				{
					return _userroledlDL.Insert(this);
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
				using(UserRoleDL _userroledlDL = new UserRoleDL())
				{
					return _userroledlDL.InsertAndGetId(this);
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
				using(UserRoleDL _userroledlDL = new UserRoleDL())
				{
					return _userroledlDL.Update(this);
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
				using(UserRoleDL _userroledlDL = new UserRoleDL())
				{
					return _userroledlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
