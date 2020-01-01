using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class CulturalStatusData : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TableName;
		public string TableName
		{
			set { _TableName = value; OnPropertyChanged("TableName"); }
			get { return _TableName; }
		}

		private string _RowData;
		public string RowData
		{
			set { _RowData = value; OnPropertyChanged("RowData"); }
			get { return _RowData; }
		}

		private string _Description;
		public string Description
		{
			set { _Description = value; OnPropertyChanged("Description"); }
			get { return _Description; }
		}

		private string _CultureInfo;
		public string CultureInfo
		{
			set { _CultureInfo = value; OnPropertyChanged("CultureInfo"); }
			get { return _CultureInfo; }
		}

		public override string GetTableName()
		{
			return "CulturalStatusData";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(CulturalStatusDataDL _culturalstatusdatadlDL = new CulturalStatusDataDL())
				{
					return _culturalstatusdatadlDL.Insert(this);
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
				using(CulturalStatusDataDL _culturalstatusdatadlDL = new CulturalStatusDataDL())
				{
					return _culturalstatusdatadlDL.InsertAndGetId(this);
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
				using(CulturalStatusDataDL _culturalstatusdatadlDL = new CulturalStatusDataDL())
				{
					return _culturalstatusdatadlDL.Update(this);
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
				using(CulturalStatusDataDL _culturalstatusdatadlDL = new CulturalStatusDataDL())
				{
					return _culturalstatusdatadlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
