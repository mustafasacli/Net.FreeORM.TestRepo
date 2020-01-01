using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Gender : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _GenderName;
		public string GenderName
		{
			set { _GenderName = value; OnPropertyChanged("GenderName"); }
			get { return _GenderName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Gender";
		}

		public override string GetIdColumn()
		{
			return "";
		}

		internal int Insert()
		{
			try
			{
				using(t_GenderDL _t_genderdlDL = new t_GenderDL())
				{
					return _t_genderdlDL.Insert(this);
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
				using(t_GenderDL _t_genderdlDL = new t_GenderDL())
				{
					return _t_genderdlDL.InsertAndGetId(this);
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
				using(t_GenderDL _t_genderdlDL = new t_GenderDL())
				{
					return _t_genderdlDL.Update(this);
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
				using(t_GenderDL _t_genderdlDL = new t_GenderDL())
				{
					return _t_genderdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
