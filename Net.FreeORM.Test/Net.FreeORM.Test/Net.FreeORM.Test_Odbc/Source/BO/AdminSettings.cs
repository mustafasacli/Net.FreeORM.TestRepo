using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class AdminSettings : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _SettingCode;
		public int SettingCode
		{
			set { _SettingCode = value; OnPropertyChanged("SettingCode"); }
			get { return _SettingCode; }
		}

		private string _SettingName;
		public string SettingName
		{
			set { _SettingName = value; OnPropertyChanged("SettingName"); }
			get { return _SettingName; }
		}

		private string _SettingValue;
		public string SettingValue
		{
			set { _SettingValue = value; OnPropertyChanged("SettingValue"); }
			get { return _SettingValue; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "AdminSettings";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(AdminSettingsDL _adminsettingsdlDL = new AdminSettingsDL())
				{
					return _adminsettingsdlDL.Insert(this);
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
				using(AdminSettingsDL _adminsettingsdlDL = new AdminSettingsDL())
				{
					return _adminsettingsdlDL.InsertAndGetId(this);
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
				using(AdminSettingsDL _adminsettingsdlDL = new AdminSettingsDL())
				{
					return _adminsettingsdlDL.Update(this);
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
				using(AdminSettingsDL _adminsettingsdlDL = new AdminSettingsDL())
				{
					return _adminsettingsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
