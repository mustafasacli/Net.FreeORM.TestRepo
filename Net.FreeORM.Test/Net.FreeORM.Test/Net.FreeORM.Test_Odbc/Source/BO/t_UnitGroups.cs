using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_UnitGroups : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _UnitGroupName;
		public string UnitGroupName
		{
			set { _UnitGroupName = value; OnPropertyChanged("UnitGroupName"); }
			get { return _UnitGroupName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_UnitGroups";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_UnitGroupsDL _t_unitgroupsdlDL = new t_UnitGroupsDL())
				{
					return _t_unitgroupsdlDL.Insert(this);
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
				using(t_UnitGroupsDL _t_unitgroupsdlDL = new t_UnitGroupsDL())
				{
					return _t_unitgroupsdlDL.InsertAndGetId(this);
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
				using(t_UnitGroupsDL _t_unitgroupsdlDL = new t_UnitGroupsDL())
				{
					return _t_unitgroupsdlDL.Update(this);
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
				using(t_UnitGroupsDL _t_unitgroupsdlDL = new t_UnitGroupsDL())
				{
					return _t_unitgroupsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
