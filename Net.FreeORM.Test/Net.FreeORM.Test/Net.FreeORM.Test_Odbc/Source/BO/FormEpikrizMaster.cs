using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormEpikrizMaster : BaseBO
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

		private int _FormCreatedBy;
		public int FormCreatedBy
		{
			set { _FormCreatedBy = value; OnPropertyChanged("FormCreatedBy"); }
			get { return _FormCreatedBy; }
		}

		private DateTime _FormCreatedDate;
		public DateTime FormCreatedDate
		{
			set { _FormCreatedDate = value; OnPropertyChanged("FormCreatedDate"); }
			get { return _FormCreatedDate; }
		}

		private string _ProtocolNo;
		public string ProtocolNo
		{
			set { _ProtocolNo = value; OnPropertyChanged("ProtocolNo"); }
			get { return _ProtocolNo; }
		}

		private string _Diagnosis;
		public string Diagnosis
		{
			set { _Diagnosis = value; OnPropertyChanged("Diagnosis"); }
			get { return _Diagnosis; }
		}

		private DateTime _AdmissionDate;
		public DateTime AdmissionDate
		{
			set { _AdmissionDate = value; OnPropertyChanged("AdmissionDate"); }
			get { return _AdmissionDate; }
		}

		private DateTime _ExitDate;
		public DateTime ExitDate
		{
			set { _ExitDate = value; OnPropertyChanged("ExitDate"); }
			get { return _ExitDate; }
		}

		private int _DepartmentId;
		public int DepartmentId
		{
			set { _DepartmentId = value; OnPropertyChanged("DepartmentId"); }
			get { return _DepartmentId; }
		}

		private int _OldResponsiblePerson;
		public int OldResponsiblePerson
		{
			set { _OldResponsiblePerson = value; OnPropertyChanged("OldResponsiblePerson"); }
			get { return _OldResponsiblePerson; }
		}

		private string _PatientIdNumber;
		public string PatientIdNumber
		{
			set { _PatientIdNumber = value; OnPropertyChanged("PatientIdNumber"); }
			get { return _PatientIdNumber; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "FormEpikrizMaster";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormEpikrizMasterDL _formepikrizmasterdlDL = new FormEpikrizMasterDL())
				{
					return _formepikrizmasterdlDL.Insert(this);
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
				using(FormEpikrizMasterDL _formepikrizmasterdlDL = new FormEpikrizMasterDL())
				{
					return _formepikrizmasterdlDL.InsertAndGetId(this);
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
				using(FormEpikrizMasterDL _formepikrizmasterdlDL = new FormEpikrizMasterDL())
				{
					return _formepikrizmasterdlDL.Update(this);
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
				using(FormEpikrizMasterDL _formepikrizmasterdlDL = new FormEpikrizMasterDL())
				{
					return _formepikrizmasterdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
