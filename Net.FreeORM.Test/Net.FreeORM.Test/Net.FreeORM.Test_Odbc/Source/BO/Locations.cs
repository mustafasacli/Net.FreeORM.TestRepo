using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Locations : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _LocationName;
		public string LocationName
		{
			set { _LocationName = value; OnPropertyChanged("LocationName"); }
			get { return _LocationName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Locations";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(LocationsDL _locationsdlDL = new LocationsDL())
				{
					return _locationsdlDL.Insert(this);
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
				using(LocationsDL _locationsdlDL = new LocationsDL())
				{
					return _locationsdlDL.InsertAndGetId(this);
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
				using(LocationsDL _locationsdlDL = new LocationsDL())
				{
					return _locationsdlDL.Update(this);
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
				using(LocationsDL _locationsdlDL = new LocationsDL())
				{
					return _locationsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
