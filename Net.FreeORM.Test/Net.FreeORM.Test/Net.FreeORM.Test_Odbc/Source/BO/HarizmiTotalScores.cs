using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class HarizmiTotalScores : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _PatientId;
		public int PatientId
		{
			set { _PatientId = value; OnPropertyChanged("PatientId"); }
			get { return _PatientId; }
		}

		private int _FormId;
		public int FormId
		{
			set { _FormId = value; OnPropertyChanged("FormId"); }
			get { return _FormId; }
		}

		private DateTime _ScoreDate;
		public DateTime ScoreDate
		{
			set { _ScoreDate = value; OnPropertyChanged("ScoreDate"); }
			get { return _ScoreDate; }
		}

		private int _TotalScore;
		public int TotalScore
		{
			set { _TotalScore = value; OnPropertyChanged("TotalScore"); }
			get { return _TotalScore; }
		}

		public override string GetTableName()
		{
			return "HarizmiTotalScores";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(HarizmiTotalScoresDL _harizmitotalscoresdlDL = new HarizmiTotalScoresDL())
				{
					return _harizmitotalscoresdlDL.Insert(this);
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
				using(HarizmiTotalScoresDL _harizmitotalscoresdlDL = new HarizmiTotalScoresDL())
				{
					return _harizmitotalscoresdlDL.InsertAndGetId(this);
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
				using(HarizmiTotalScoresDL _harizmitotalscoresdlDL = new HarizmiTotalScoresDL())
				{
					return _harizmitotalscoresdlDL.Update(this);
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
				using(HarizmiTotalScoresDL _harizmitotalscoresdlDL = new HarizmiTotalScoresDL())
				{
					return _harizmitotalscoresdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
