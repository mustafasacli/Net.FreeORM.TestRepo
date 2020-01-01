using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Routes : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _RouteName;
		public string RouteName
		{
			set { _RouteName = value; OnPropertyChanged("RouteName"); }
			get { return _RouteName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Routes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_RoutesDL _t_routesdlDL = new t_RoutesDL())
				{
					return _t_routesdlDL.Insert(this);
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
				using(t_RoutesDL _t_routesdlDL = new t_RoutesDL())
				{
					return _t_routesdlDL.InsertAndGetId(this);
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
				using(t_RoutesDL _t_routesdlDL = new t_RoutesDL())
				{
					return _t_routesdlDL.Update(this);
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
				using(t_RoutesDL _t_routesdlDL = new t_RoutesDL())
				{
					return _t_routesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
