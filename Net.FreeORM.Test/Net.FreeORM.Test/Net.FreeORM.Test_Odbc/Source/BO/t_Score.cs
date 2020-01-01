using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Score : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ScoreName;
		public string ScoreName
		{
			set { _ScoreName = value; OnPropertyChanged("ScoreName"); }
			get { return _ScoreName; }
		}

		private string _ScoreAbbr;
		public string ScoreAbbr
		{
			set { _ScoreAbbr = value; OnPropertyChanged("ScoreAbbr"); }
			get { return _ScoreAbbr; }
		}

		public override string GetTableName()
		{
			return "t_Score";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_ScoreDL _t_scoredlDL = new t_ScoreDL())
				{
					return _t_scoredlDL.Insert(this);
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
				using(t_ScoreDL _t_scoredlDL = new t_ScoreDL())
				{
					return _t_scoredlDL.InsertAndGetId(this);
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
				using(t_ScoreDL _t_scoredlDL = new t_ScoreDL())
				{
					return _t_scoredlDL.Update(this);
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
				using(t_ScoreDL _t_scoredlDL = new t_ScoreDL())
				{
					return _t_scoredlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
