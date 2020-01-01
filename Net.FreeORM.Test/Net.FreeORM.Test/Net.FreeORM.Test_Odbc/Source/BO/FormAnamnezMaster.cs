using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormAnamnezMaster : BaseBO
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

		private string _PatientName;
		public string PatientName
		{
			set { _PatientName = value; OnPropertyChanged("PatientName"); }
			get { return _PatientName; }
		}

		private string _ProtocolNo;
		public string ProtocolNo
		{
			set { _ProtocolNo = value; OnPropertyChanged("ProtocolNo"); }
			get { return _ProtocolNo; }
		}

		private int _DepartmentId;
		public int DepartmentId
		{
			set { _DepartmentId = value; OnPropertyChanged("DepartmentId"); }
			get { return _DepartmentId; }
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

		private string _DischargeKind;
		public string DischargeKind
		{
			set { _DischargeKind = value; OnPropertyChanged("DischargeKind"); }
			get { return _DischargeKind; }
		}

		private string _LivingConditions;
		public string LivingConditions
		{
			set { _LivingConditions = value; OnPropertyChanged("LivingConditions"); }
			get { return _LivingConditions; }
		}

		private string _DischargedEducation;
		public string DischargedEducation
		{
			set { _DischargedEducation = value; OnPropertyChanged("DischargedEducation"); }
			get { return _DischargedEducation; }
		}

		private string _DischargeDevices;
		public string DischargeDevices
		{
			set { _DischargeDevices = value; OnPropertyChanged("DischargeDevices"); }
			get { return _DischargeDevices; }
		}

		private int _DischargedPersonId;
		public int DischargedPersonId
		{
			set { _DischargedPersonId = value; OnPropertyChanged("DischargedPersonId"); }
			get { return _DischargedPersonId; }
		}

		private DateTime _DischargeDate;
		public DateTime DischargeDate
		{
			set { _DischargeDate = value; OnPropertyChanged("DischargeDate"); }
			get { return _DischargeDate; }
		}

		private string _PatientRelativeName;
		public string PatientRelativeName
		{
			set { _PatientRelativeName = value; OnPropertyChanged("PatientRelativeName"); }
			get { return _PatientRelativeName; }
		}

		private string _PatientRelativeType;
		public string PatientRelativeType
		{
			set { _PatientRelativeType = value; OnPropertyChanged("PatientRelativeType"); }
			get { return _PatientRelativeType; }
		}

		private string _PatientRelativeAddress;
		public string PatientRelativeAddress
		{
			set { _PatientRelativeAddress = value; OnPropertyChanged("PatientRelativeAddress"); }
			get { return _PatientRelativeAddress; }
		}

		private string _PatientRelativePhoneNo;
		public string PatientRelativePhoneNo
		{
			set { _PatientRelativePhoneNo = value; OnPropertyChanged("PatientRelativePhoneNo"); }
			get { return _PatientRelativePhoneNo; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "FormAnamnezMaster";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormAnamnezMasterDL _formanamnezmasterdlDL = new FormAnamnezMasterDL())
				{
					return _formanamnezmasterdlDL.Insert(this);
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
				using(FormAnamnezMasterDL _formanamnezmasterdlDL = new FormAnamnezMasterDL())
				{
					return _formanamnezmasterdlDL.InsertAndGetId(this);
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
				using(FormAnamnezMasterDL _formanamnezmasterdlDL = new FormAnamnezMasterDL())
				{
					return _formanamnezmasterdlDL.Update(this);
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
				using(FormAnamnezMasterDL _formanamnezmasterdlDL = new FormAnamnezMasterDL())
				{
					return _formanamnezmasterdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
