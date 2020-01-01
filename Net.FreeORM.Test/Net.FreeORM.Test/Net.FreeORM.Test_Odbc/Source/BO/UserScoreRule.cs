using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class UserScoreRule : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _RuleId;
		public int RuleId
		{
			set { _RuleId = value; OnPropertyChanged("RuleId"); }
			get { return _RuleId; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		public override string GetTableName()
		{
			return "UserScoreRule";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(UserScoreRuleDL _userscoreruledlDL = new UserScoreRuleDL())
				{
					return _userscoreruledlDL.Insert(this);
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
				using(UserScoreRuleDL _userscoreruledlDL = new UserScoreRuleDL())
				{
					return _userscoreruledlDL.InsertAndGetId(this);
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
				using(UserScoreRuleDL _userscoreruledlDL = new UserScoreRuleDL())
				{
					return _userscoreruledlDL.Update(this);
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
				using(UserScoreRuleDL _userscoreruledlDL = new UserScoreRuleDL())
				{
					return _userscoreruledlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
