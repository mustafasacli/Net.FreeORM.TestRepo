using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class UserType : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _UserTypeName;
		public string UserTypeName
		{
			set { _UserTypeName = value; OnPropertyChanged("UserTypeName"); }
			get { return _UserTypeName; }
		}

		private int _ColorCode;
		public int ColorCode
		{
			set { _ColorCode = value; OnPropertyChanged("ColorCode"); }
			get { return _ColorCode; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "UserType";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(UserTypeDL _usertypedlDL = new UserTypeDL())
				{
					return _usertypedlDL.Insert(this);
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
				using(UserTypeDL _usertypedlDL = new UserTypeDL())
				{
					return _usertypedlDL.InsertAndGetId(this);
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
				using(UserTypeDL _usertypedlDL = new UserTypeDL())
				{
					return _usertypedlDL.Update(this);
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
				using(UserTypeDL _usertypedlDL = new UserTypeDL())
				{
					return _usertypedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
