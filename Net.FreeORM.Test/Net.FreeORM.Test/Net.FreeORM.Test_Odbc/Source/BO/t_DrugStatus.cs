using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_DrugStatus : BaseBO
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

		public override string GetTableName()
		{
			return "t_DrugStatus";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_DrugStatusDL _t_drugstatusdlDL = new t_DrugStatusDL())
				{
					return _t_drugstatusdlDL.Insert(this);
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
				using(t_DrugStatusDL _t_drugstatusdlDL = new t_DrugStatusDL())
				{
					return _t_drugstatusdlDL.InsertAndGetId(this);
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
				using(t_DrugStatusDL _t_drugstatusdlDL = new t_DrugStatusDL())
				{
					return _t_drugstatusdlDL.Update(this);
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
				using(t_DrugStatusDL _t_drugstatusdlDL = new t_DrugStatusDL())
				{
					return _t_drugstatusdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
