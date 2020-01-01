using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Religion : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ReligionName;
		public string ReligionName
		{
			set { _ReligionName = value; OnPropertyChanged("ReligionName"); }
			get { return _ReligionName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Religion";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_ReligionDL _t_religiondlDL = new t_ReligionDL())
				{
					return _t_religiondlDL.Insert(this);
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
				using(t_ReligionDL _t_religiondlDL = new t_ReligionDL())
				{
					return _t_religiondlDL.InsertAndGetId(this);
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
				using(t_ReligionDL _t_religiondlDL = new t_ReligionDL())
				{
					return _t_religiondlDL.Update(this);
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
				using(t_ReligionDL _t_religiondlDL = new t_ReligionDL())
				{
					return _t_religiondlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
