using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ReportSettings : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ReportTag;
		public string ReportTag
		{
			set { _ReportTag = value; OnPropertyChanged("ReportTag"); }
			get { return _ReportTag; }
		}

		private string _ReportName;
		public string ReportName
		{
			set { _ReportName = value; OnPropertyChanged("ReportName"); }
			get { return _ReportName; }
		}

		private string _LeftLogoPath;
		public string LeftLogoPath
		{
			set { _LeftLogoPath = value; OnPropertyChanged("LeftLogoPath"); }
			get { return _LeftLogoPath; }
		}

		private string _RightLogoPath;
		public string RightLogoPath
		{
			set { _RightLogoPath = value; OnPropertyChanged("RightLogoPath"); }
			get { return _RightLogoPath; }
		}

		private string _ReportHeaderText;
		public string ReportHeaderText
		{
			set { _ReportHeaderText = value; OnPropertyChanged("ReportHeaderText"); }
			get { return _ReportHeaderText; }
		}

		private string _ReportDefaultContent;
		public string ReportDefaultContent
		{
			set { _ReportDefaultContent = value; OnPropertyChanged("ReportDefaultContent"); }
			get { return _ReportDefaultContent; }
		}

		private string _DocumentNo;
		public string DocumentNo
		{
			set { _DocumentNo = value; OnPropertyChanged("DocumentNo"); }
			get { return _DocumentNo; }
		}

		private DateTime _PublishDate;
		public DateTime PublishDate
		{
			set { _PublishDate = value; OnPropertyChanged("PublishDate"); }
			get { return _PublishDate; }
		}

		private DateTime _RevisionDate;
		public DateTime RevisionDate
		{
			set { _RevisionDate = value; OnPropertyChanged("RevisionDate"); }
			get { return _RevisionDate; }
		}

		private int _RevisionNo;
		public int RevisionNo
		{
			set { _RevisionNo = value; OnPropertyChanged("RevisionNo"); }
			get { return _RevisionNo; }
		}

		public override string GetTableName()
		{
			return "ReportSettings";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ReportSettingsDL _reportsettingsdlDL = new ReportSettingsDL())
				{
					return _reportsettingsdlDL.Insert(this);
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
				using(ReportSettingsDL _reportsettingsdlDL = new ReportSettingsDL())
				{
					return _reportsettingsdlDL.InsertAndGetId(this);
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
				using(ReportSettingsDL _reportsettingsdlDL = new ReportSettingsDL())
				{
					return _reportsettingsdlDL.Update(this);
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
				using(ReportSettingsDL _reportsettingsdlDL = new ReportSettingsDL())
				{
					return _reportsettingsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
