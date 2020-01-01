using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_MaritalStatus : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _MaritalStatusName;
		public string MaritalStatusName
		{
			set { _MaritalStatusName = value; OnPropertyChanged("MaritalStatusName"); }
			get { return _MaritalStatusName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_MaritalStatus";
		}

		public override string GetIdColumn()
		{
			return "";
		}

		internal int Insert()
		{
			try
			{
				using(t_MaritalStatusDL _t_maritalstatusdlDL = new t_MaritalStatusDL())
				{
					return _t_maritalstatusdlDL.Insert(this);
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
				using(t_MaritalStatusDL _t_maritalstatusdlDL = new t_MaritalStatusDL())
				{
					return _t_maritalstatusdlDL.InsertAndGetId(this);
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
				using(t_MaritalStatusDL _t_maritalstatusdlDL = new t_MaritalStatusDL())
				{
					return _t_maritalstatusdlDL.Update(this);
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
				using(t_MaritalStatusDL _t_maritalstatusdlDL = new t_MaritalStatusDL())
				{
					return _t_maritalstatusdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
