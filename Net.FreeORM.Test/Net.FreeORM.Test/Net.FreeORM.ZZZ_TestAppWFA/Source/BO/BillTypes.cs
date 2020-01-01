using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class BillTypes : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _BillTypeName;
		public string BillTypeName
		{
			set { _BillTypeName = value; OnPropertyChanged("BillTypeName"); }
			get { return _BillTypeName; }
		}

		public override string GetTableName()
		{
			return "t_BillTypes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(BillTypesDL _t_billtypesdlDL = new BillTypesDL())
				{
					return _t_billtypesdlDL.Insert(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int InsertAndGetId()
		{
			try
			{
				using(BillTypesDL _t_billtypesdlDL = new BillTypesDL())
				{
					return _t_billtypesdlDL.InsertAndGetId(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Update()
		{
			try
			{
				using(BillTypesDL _t_billtypesdlDL = new BillTypesDL())
				{
					return _t_billtypesdlDL.Update(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Delete()
		{
			try
			{
				using(BillTypesDL _t_billtypesdlDL = new BillTypesDL())
				{
					return _t_billtypesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
