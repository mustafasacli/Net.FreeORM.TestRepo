using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Ethnicity : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _EthnicityName;
		public string EthnicityName
		{
			set { _EthnicityName = value; OnPropertyChanged("EthnicityName"); }
			get { return _EthnicityName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Ethnicity";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_EthnicityDL _t_ethnicitydlDL = new t_EthnicityDL())
				{
					return _t_ethnicitydlDL.Insert(this);
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
				using(t_EthnicityDL _t_ethnicitydlDL = new t_EthnicityDL())
				{
					return _t_ethnicitydlDL.InsertAndGetId(this);
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
				using(t_EthnicityDL _t_ethnicitydlDL = new t_EthnicityDL())
				{
					return _t_ethnicitydlDL.Update(this);
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
				using(t_EthnicityDL _t_ethnicitydlDL = new t_EthnicityDL())
				{
					return _t_ethnicitydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
