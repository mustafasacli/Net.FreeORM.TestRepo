using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_UnitTypes : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _UnitTypeName;
		public string UnitTypeName
		{
			set { _UnitTypeName = value; OnPropertyChanged("UnitTypeName"); }
			get { return _UnitTypeName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_UnitTypes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_UnitTypesDL _t_unittypesdlDL = new t_UnitTypesDL())
				{
					return _t_unittypesdlDL.Insert(this);
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
				using(t_UnitTypesDL _t_unittypesdlDL = new t_UnitTypesDL())
				{
					return _t_unittypesdlDL.InsertAndGetId(this);
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
				using(t_UnitTypesDL _t_unittypesdlDL = new t_UnitTypesDL())
				{
					return _t_unittypesdlDL.Update(this);
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
				using(t_UnitTypesDL _t_unittypesdlDL = new t_UnitTypesDL())
				{
					return _t_unittypesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
