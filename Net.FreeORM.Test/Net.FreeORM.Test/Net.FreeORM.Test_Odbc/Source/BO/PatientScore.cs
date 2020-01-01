using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PatientScore : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _ScoreTypeId;
		public int ScoreTypeId
		{
			set { _ScoreTypeId = value; OnPropertyChanged("ScoreTypeId"); }
			get { return _ScoreTypeId; }
		}

		private int _PatientId;
		public int PatientId
		{
			set { _PatientId = value; OnPropertyChanged("PatientId"); }
			get { return _PatientId; }
		}

		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{
			set { _CreatedDate = value; OnPropertyChanged("CreatedDate"); }
			get { return _CreatedDate; }
		}

		private string _Parameters;
		public string Parameters
		{
			set { _Parameters = value; OnPropertyChanged("Parameters"); }
			get { return _Parameters; }
		}

		private Int16 _Score;
		public Int16 Score
		{
			set { _Score = value; OnPropertyChanged("Score"); }
			get { return _Score; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "PatientScore";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientScoreDL _patientscoredlDL = new PatientScoreDL())
				{
					return _patientscoredlDL.Insert(this);
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
				using(PatientScoreDL _patientscoredlDL = new PatientScoreDL())
				{
					return _patientscoredlDL.InsertAndGetId(this);
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
				using(PatientScoreDL _patientscoredlDL = new PatientScoreDL())
				{
					return _patientscoredlDL.Update(this);
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
				using(PatientScoreDL _patientscoredlDL = new PatientScoreDL())
				{
					return _patientscoredlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
