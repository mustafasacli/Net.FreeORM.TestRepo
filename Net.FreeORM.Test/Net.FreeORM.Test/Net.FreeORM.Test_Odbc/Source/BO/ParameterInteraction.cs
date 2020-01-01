using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ParameterInteraction : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _ActiveSubstanceId;
		public int ActiveSubstanceId
		{
			set { _ActiveSubstanceId = value; OnPropertyChanged("ActiveSubstanceId"); }
			get { return _ActiveSubstanceId; }
		}

		private int _RelatedActiveSubstanceId;
		public int RelatedActiveSubstanceId
		{
			set { _RelatedActiveSubstanceId = value; OnPropertyChanged("RelatedActiveSubstanceId"); }
			get { return _RelatedActiveSubstanceId; }
		}

		private string _MatchPattern;
		public string MatchPattern
		{
			set { _MatchPattern = value; OnPropertyChanged("MatchPattern"); }
			get { return _MatchPattern; }
		}

		private string _Warning;
		public string Warning
		{
			set { _Warning = value; OnPropertyChanged("Warning"); }
			get { return _Warning; }
		}

		private string _Suggestion;
		public string Suggestion
		{
			set { _Suggestion = value; OnPropertyChanged("Suggestion"); }
			get { return _Suggestion; }
		}

		private int _CreateUser;
		public int CreateUser
		{
			set { _CreateUser = value; OnPropertyChanged("CreateUser"); }
			get { return _CreateUser; }
		}

		private DateTime _CreationDate;
		public DateTime CreationDate
		{
			set { _CreationDate = value; OnPropertyChanged("CreationDate"); }
			get { return _CreationDate; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		private string _WarningTR;
		public string WarningTR
		{
			set { _WarningTR = value; OnPropertyChanged("WarningTR"); }
			get { return _WarningTR; }
		}

		private string _SuggestionTR;
		public string SuggestionTR
		{
			set { _SuggestionTR = value; OnPropertyChanged("SuggestionTR"); }
			get { return _SuggestionTR; }
		}

		public override string GetTableName()
		{
			return "ParameterInteraction";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ParameterInteractionDL _parameterınteractiondlDL = new ParameterInteractionDL())
				{
					return _parameterınteractiondlDL.Insert(this);
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
				using(ParameterInteractionDL _parameterınteractiondlDL = new ParameterInteractionDL())
				{
					return _parameterınteractiondlDL.InsertAndGetId(this);
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
				using(ParameterInteractionDL _parameterınteractiondlDL = new ParameterInteractionDL())
				{
					return _parameterınteractiondlDL.Update(this);
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
				using(ParameterInteractionDL _parameterınteractiondlDL = new ParameterInteractionDL())
				{
					return _parameterınteractiondlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
