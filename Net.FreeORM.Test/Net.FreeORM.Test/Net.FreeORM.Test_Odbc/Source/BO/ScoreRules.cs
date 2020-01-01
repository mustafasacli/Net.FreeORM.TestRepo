using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ScoreRules : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private DateTime _CreationDate;
		public DateTime CreationDate
		{
			set { _CreationDate = value; OnPropertyChanged("CreationDate"); }
			get { return _CreationDate; }
		}

		private string _RuleName;
		public string RuleName
		{
			set { _RuleName = value; OnPropertyChanged("RuleName"); }
			get { return _RuleName; }
		}

		private string _RuleBody;
		public string RuleBody
		{
			set { _RuleBody = value; OnPropertyChanged("RuleBody"); }
			get { return _RuleBody; }
		}

		private bool _Success;
		public bool Success
		{
			set { _Success = value; OnPropertyChanged("Success"); }
			get { return _Success; }
		}

		private bool _IsCustom;
		public bool IsCustom
		{
			set { _IsCustom = value; OnPropertyChanged("IsCustom"); }
			get { return _IsCustom; }
		}

		public override string GetTableName()
		{
			return "ScoreRules";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ScoreRulesDL _scorerulesdlDL = new ScoreRulesDL())
				{
					return _scorerulesdlDL.Insert(this);
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
				using(ScoreRulesDL _scorerulesdlDL = new ScoreRulesDL())
				{
					return _scorerulesdlDL.InsertAndGetId(this);
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
				using(ScoreRulesDL _scorerulesdlDL = new ScoreRulesDL())
				{
					return _scorerulesdlDL.Update(this);
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
				using(ScoreRulesDL _scorerulesdlDL = new ScoreRulesDL())
				{
					return _scorerulesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
