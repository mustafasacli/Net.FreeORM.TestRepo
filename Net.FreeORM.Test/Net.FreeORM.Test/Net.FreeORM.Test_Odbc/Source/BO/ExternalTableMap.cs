using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ExternalTableMap : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _QueryKey;
		public string QueryKey
		{
			set { _QueryKey = value; OnPropertyChanged("QueryKey"); }
			get { return _QueryKey; }
		}

		private string _Query;
		public string Query
		{
			set { _Query = value; OnPropertyChanged("Query"); }
			get { return _Query; }
		}

		private string _Mapping;
		public string Mapping
		{
			set { _Mapping = value; OnPropertyChanged("Mapping"); }
			get { return _Mapping; }
		}

		public override string GetTableName()
		{
			return "ExternalTableMap";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ExternalTableMapDL _externaltablemapdlDL = new ExternalTableMapDL())
				{
					return _externaltablemapdlDL.Insert(this);
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
				using(ExternalTableMapDL _externaltablemapdlDL = new ExternalTableMapDL())
				{
					return _externaltablemapdlDL.InsertAndGetId(this);
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
				using(ExternalTableMapDL _externaltablemapdlDL = new ExternalTableMapDL())
				{
					return _externaltablemapdlDL.Update(this);
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
				using(ExternalTableMapDL _externaltablemapdlDL = new ExternalTableMapDL())
				{
					return _externaltablemapdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
