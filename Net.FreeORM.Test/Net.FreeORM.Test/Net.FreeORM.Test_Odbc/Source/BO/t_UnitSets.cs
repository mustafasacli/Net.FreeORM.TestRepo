using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_UnitSets : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _SetTitle;
		public string SetTitle
		{
			set { _SetTitle = value; OnPropertyChanged("SetTitle"); }
			get { return _SetTitle; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_UnitSets";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_UnitSetsDL _t_unitsetsdlDL = new t_UnitSetsDL())
				{
					return _t_unitsetsdlDL.Insert(this);
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
				using(t_UnitSetsDL _t_unitsetsdlDL = new t_UnitSetsDL())
				{
					return _t_unitsetsdlDL.InsertAndGetId(this);
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
				using(t_UnitSetsDL _t_unitsetsdlDL = new t_UnitSetsDL())
				{
					return _t_unitsetsdlDL.Update(this);
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
				using(t_UnitSetsDL _t_unitsetsdlDL = new t_UnitSetsDL())
				{
					return _t_unitsetsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
