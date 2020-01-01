using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ReportPatterns : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _PatternName;
		public string PatternName
		{
			set { _PatternName = value; OnPropertyChanged("PatternName"); }
			get { return _PatternName; }
		}

		private string _PatternString;
		public string PatternString
		{
			set { _PatternString = value; OnPropertyChanged("PatternString"); }
			get { return _PatternString; }
		}

		public override string GetTableName()
		{
			return "ReportPatterns";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ReportPatternsDL _reportpatternsdlDL = new ReportPatternsDL())
				{
					return _reportpatternsdlDL.Insert(this);
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
				using(ReportPatternsDL _reportpatternsdlDL = new ReportPatternsDL())
				{
					return _reportpatternsdlDL.InsertAndGetId(this);
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
				using(ReportPatternsDL _reportpatternsdlDL = new ReportPatternsDL())
				{
					return _reportpatternsdlDL.Update(this);
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
				using(ReportPatternsDL _reportpatternsdlDL = new ReportPatternsDL())
				{
					return _reportpatternsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
