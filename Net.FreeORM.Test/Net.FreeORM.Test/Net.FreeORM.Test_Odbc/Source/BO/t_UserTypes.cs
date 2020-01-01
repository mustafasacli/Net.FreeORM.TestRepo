using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_UserTypes : BaseBO
	{
		private string _OBJID;
		public string OBJID
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

		private string _Abbreviate;
		public string Abbreviate
		{
			set { _Abbreviate = value; OnPropertyChanged("Abbreviate"); }
			get { return _Abbreviate; }
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
			return "t_UserTypes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_UserTypesDL _t_usertypesdlDL = new t_UserTypesDL())
				{
					return _t_usertypesdlDL.Insert(this);
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
				using(t_UserTypesDL _t_usertypesdlDL = new t_UserTypesDL())
				{
					return _t_usertypesdlDL.InsertAndGetId(this);
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
				using(t_UserTypesDL _t_usertypesdlDL = new t_UserTypesDL())
				{
					return _t_usertypesdlDL.Update(this);
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
				using(t_UserTypesDL _t_usertypesdlDL = new t_UserTypesDL())
				{
					return _t_usertypesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
