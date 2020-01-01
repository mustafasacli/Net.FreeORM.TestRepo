using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Status : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _StatusName;
		public string StatusName
		{
			set { _StatusName = value; OnPropertyChanged("StatusName"); }
			get { return _StatusName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Status";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_StatusDL _t_statusdlDL = new t_StatusDL())
				{
					return _t_statusdlDL.Insert(this);
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
				using(t_StatusDL _t_statusdlDL = new t_StatusDL())
				{
					return _t_statusdlDL.InsertAndGetId(this);
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
				using(t_StatusDL _t_statusdlDL = new t_StatusDL())
				{
					return _t_statusdlDL.Update(this);
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
				using(t_StatusDL _t_statusdlDL = new t_StatusDL())
				{
					return _t_statusdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
