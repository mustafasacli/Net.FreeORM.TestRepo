using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Nationality : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _NationalityCode;
		public int NationalityCode
		{
			set { _NationalityCode = value; OnPropertyChanged("NationalityCode"); }
			get { return _NationalityCode; }
		}

		private string _NationalityName;
		public string NationalityName
		{
			set { _NationalityName = value; OnPropertyChanged("NationalityName"); }
			get { return _NationalityName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Nationality";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_NationalityDL _t_nationalitydlDL = new t_NationalityDL())
				{
					return _t_nationalitydlDL.Insert(this);
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
				using(t_NationalityDL _t_nationalitydlDL = new t_NationalityDL())
				{
					return _t_nationalitydlDL.InsertAndGetId(this);
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
				using(t_NationalityDL _t_nationalitydlDL = new t_NationalityDL())
				{
					return _t_nationalitydlDL.Update(this);
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
				using(t_NationalityDL _t_nationalitydlDL = new t_NationalityDL())
				{
					return _t_nationalitydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
