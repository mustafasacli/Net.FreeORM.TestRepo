using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PatientDashBoardSnapShot : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _FileName;
		public string FileName
		{
			set { _FileName = value; OnPropertyChanged("FileName"); }
			get { return _FileName; }
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

		private DateTime _CreationDate;
		public DateTime CreationDate
		{
			set { _CreationDate = value; OnPropertyChanged("CreationDate"); }
			get { return _CreationDate; }
		}

		private int _CreationUser;
		public int CreationUser
		{
			set { _CreationUser = value; OnPropertyChanged("CreationUser"); }
			get { return _CreationUser; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "PatientDashBoardSnapShot";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientDashBoardSnapShotDL _patientdashboardsnapshotdlDL = new PatientDashBoardSnapShotDL())
				{
					return _patientdashboardsnapshotdlDL.Insert(this);
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
				using(PatientDashBoardSnapShotDL _patientdashboardsnapshotdlDL = new PatientDashBoardSnapShotDL())
				{
					return _patientdashboardsnapshotdlDL.InsertAndGetId(this);
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
				using(PatientDashBoardSnapShotDL _patientdashboardsnapshotdlDL = new PatientDashBoardSnapShotDL())
				{
					return _patientdashboardsnapshotdlDL.Update(this);
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
				using(PatientDashBoardSnapShotDL _patientdashboardsnapshotdlDL = new PatientDashBoardSnapShotDL())
				{
					return _patientdashboardsnapshotdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
