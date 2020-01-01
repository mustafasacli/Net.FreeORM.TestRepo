using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PatientCheckpoint : BaseBO
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

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		private string _ParameterName;
		public string ParameterName
		{
			set { _ParameterName = value; OnPropertyChanged("ParameterName"); }
			get { return _ParameterName; }
		}

		private int _Value;
		public int Value
		{
			set { _Value = value; OnPropertyChanged("Value"); }
			get { return _Value; }
		}

		private char _Operator;
		public char Operator
		{
			set { _Operator = value; OnPropertyChanged("Operator"); }
			get { return _Operator; }
		}

		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{
			set { _CreatedDate = value; OnPropertyChanged("CreatedDate"); }
			get { return _CreatedDate; }
		}

		private int _CreatedUser;
		public int CreatedUser
		{
			set { _CreatedUser = value; OnPropertyChanged("CreatedUser"); }
			get { return _CreatedUser; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "PatientCheckpoint";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientCheckpointDL _patientcheckpointdlDL = new PatientCheckpointDL())
				{
					return _patientcheckpointdlDL.Insert(this);
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
				using(PatientCheckpointDL _patientcheckpointdlDL = new PatientCheckpointDL())
				{
					return _patientcheckpointdlDL.InsertAndGetId(this);
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
				using(PatientCheckpointDL _patientcheckpointdlDL = new PatientCheckpointDL())
				{
					return _patientcheckpointdlDL.Update(this);
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
				using(PatientCheckpointDL _patientcheckpointdlDL = new PatientCheckpointDL())
				{
					return _patientcheckpointdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
