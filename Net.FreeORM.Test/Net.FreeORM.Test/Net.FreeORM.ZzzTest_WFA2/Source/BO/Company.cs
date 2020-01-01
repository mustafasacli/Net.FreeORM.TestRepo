using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class Company : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _CompanyName;
		public string CompanyName
		{
			set { _CompanyName = value; OnPropertyChanged("CompanyName"); }
			get { return _CompanyName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Company";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(CompanyDL _companydlDL = new CompanyDL())
				{
					return _companydlDL.Insert(this);
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
				using(CompanyDL _companydlDL = new CompanyDL())
				{
					return _companydlDL.InsertAndGetId(this);
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
				using(CompanyDL _companydlDL = new CompanyDL())
				{
					return _companydlDL.Update(this);
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
				using(CompanyDL _companydlDL = new CompanyDL())
				{
					return _companydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
