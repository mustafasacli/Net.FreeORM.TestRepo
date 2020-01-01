using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Occupation : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _OccupationName;
		public string OccupationName
		{
			set { _OccupationName = value; OnPropertyChanged("OccupationName"); }
			get { return _OccupationName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Occupation";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_OccupationDL _t_occupationdlDL = new t_OccupationDL())
				{
					return _t_occupationdlDL.Insert(this);
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
				using(t_OccupationDL _t_occupationdlDL = new t_OccupationDL())
				{
					return _t_occupationdlDL.InsertAndGetId(this);
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
				using(t_OccupationDL _t_occupationdlDL = new t_OccupationDL())
				{
					return _t_occupationdlDL.Update(this);
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
				using(t_OccupationDL _t_occupationdlDL = new t_OccupationDL())
				{
					return _t_occupationdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
