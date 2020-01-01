using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PatientEpisode : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _EpisodeNo;
		public string EpisodeNo
		{
			set { _EpisodeNo = value; OnPropertyChanged("EpisodeNo"); }
			get { return _EpisodeNo; }
		}

		private int _PatientId;
		public int PatientId
		{
			set { _PatientId = value; OnPropertyChanged("PatientId"); }
			get { return _PatientId; }
		}

		private DateTime _AdmissionDate;
		public DateTime AdmissionDate
		{
			set { _AdmissionDate = value; OnPropertyChanged("AdmissionDate"); }
			get { return _AdmissionDate; }
		}

		private int _CreatedBy;
		public int CreatedBy
		{
			set { _CreatedBy = value; OnPropertyChanged("CreatedBy"); }
			get { return _CreatedBy; }
		}

		private DateTime _DischargeDate;
		public DateTime DischargeDate
		{
			set { _DischargeDate = value; OnPropertyChanged("DischargeDate"); }
			get { return _DischargeDate; }
		}

		private int _UpdatedBy;
		public int UpdatedBy
		{
			set { _UpdatedBy = value; OnPropertyChanged("UpdatedBy"); }
			get { return _UpdatedBy; }
		}

		public override string GetTableName()
		{
			return "PatientEpisode";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientEpisodeDL _patientepisodedlDL = new PatientEpisodeDL())
				{
					return _patientepisodedlDL.Insert(this);
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
				using(PatientEpisodeDL _patientepisodedlDL = new PatientEpisodeDL())
				{
					return _patientepisodedlDL.InsertAndGetId(this);
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
				using(PatientEpisodeDL _patientepisodedlDL = new PatientEpisodeDL())
				{
					return _patientepisodedlDL.Update(this);
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
				using(PatientEpisodeDL _patientepisodedlDL = new PatientEpisodeDL())
				{
					return _patientepisodedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
