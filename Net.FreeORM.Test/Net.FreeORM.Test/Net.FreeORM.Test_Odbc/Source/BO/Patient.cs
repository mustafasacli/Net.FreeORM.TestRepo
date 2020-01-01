using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Patient : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private Int16 _GenderId;
		public Int16 GenderId
		{
			set { _GenderId = value; OnPropertyChanged("GenderId"); }
			get { return _GenderId; }
		}

		private string _HospitalId;
		public string HospitalId
		{
			set { _HospitalId = value; OnPropertyChanged("HospitalId"); }
			get { return _HospitalId; }
		}

		private string _FirstName;
		public string FirstName
		{
			set { _FirstName = value; OnPropertyChanged("FirstName"); }
			get { return _FirstName; }
		}

		private string _LastName;
		public string LastName
		{
			set { _LastName = value; OnPropertyChanged("LastName"); }
			get { return _LastName; }
		}

		private string _OtherForename;
		public string OtherForename
		{
			set { _OtherForename = value; OnPropertyChanged("OtherForename"); }
			get { return _OtherForename; }
		}

		private string _MaidenName;
		public string MaidenName
		{
			set { _MaidenName = value; OnPropertyChanged("MaidenName"); }
			get { return _MaidenName; }
		}

		private string _FatherName;
		public string FatherName
		{
			set { _FatherName = value; OnPropertyChanged("FatherName"); }
			get { return _FatherName; }
		}

		private string _MotherName;
		public string MotherName
		{
			set { _MotherName = value; OnPropertyChanged("MotherName"); }
			get { return _MotherName; }
		}

		private string _PatientIdentityNumber;
		public string PatientIdentityNumber
		{
			set { _PatientIdentityNumber = value; OnPropertyChanged("PatientIdentityNumber"); }
			get { return _PatientIdentityNumber; }
		}

		private string _SocialSecurityNumber;
		public string SocialSecurityNumber
		{
			set { _SocialSecurityNumber = value; OnPropertyChanged("SocialSecurityNumber"); }
			get { return _SocialSecurityNumber; }
		}

		private int _CreatedBy;
		public int CreatedBy
		{
			set { _CreatedBy = value; OnPropertyChanged("CreatedBy"); }
			get { return _CreatedBy; }
		}

		private DateTime _BirthDate;
		public DateTime BirthDate
		{
			set { _BirthDate = value; OnPropertyChanged("BirthDate"); }
			get { return _BirthDate; }
		}

		private float _Age;
		public float Age
		{
			set { _Age = value; OnPropertyChanged("Age"); }
			get { return _Age; }
		}

		private Int16 _MaritalStatusId;
		public Int16 MaritalStatusId
		{
			set { _MaritalStatusId = value; OnPropertyChanged("MaritalStatusId"); }
			get { return _MaritalStatusId; }
		}

		private int _NationalityId;
		public int NationalityId
		{
			set { _NationalityId = value; OnPropertyChanged("NationalityId"); }
			get { return _NationalityId; }
		}

		private int _EthnicGroupId;
		public int EthnicGroupId
		{
			set { _EthnicGroupId = value; OnPropertyChanged("EthnicGroupId"); }
			get { return _EthnicGroupId; }
		}

		private int _ReligionId;
		public int ReligionId
		{
			set { _ReligionId = value; OnPropertyChanged("ReligionId"); }
			get { return _ReligionId; }
		}

		private DateTime _AddmissionDate;
		public DateTime AddmissionDate
		{
			set { _AddmissionDate = value; OnPropertyChanged("AddmissionDate"); }
			get { return _AddmissionDate; }
		}

		private DateTime _FromTime;
		public DateTime FromTime
		{
			set { _FromTime = value; OnPropertyChanged("FromTime"); }
			get { return _FromTime; }
		}

		private float _AdmissionWeight;
		public float AdmissionWeight
		{
			set { _AdmissionWeight = value; OnPropertyChanged("AdmissionWeight"); }
			get { return _AdmissionWeight; }
		}

		private float _Height;
		public float Height
		{
			set { _Height = value; OnPropertyChanged("Height"); }
			get { return _Height; }
		}

		private string _HomePhone;
		public string HomePhone
		{
			set { _HomePhone = value; OnPropertyChanged("HomePhone"); }
			get { return _HomePhone; }
		}

		private string _WorkPhone;
		public string WorkPhone
		{
			set { _WorkPhone = value; OnPropertyChanged("WorkPhone"); }
			get { return _WorkPhone; }
		}

		private string _Address;
		public string Address
		{
			set { _Address = value; OnPropertyChanged("Address"); }
			get { return _Address; }
		}

		private string _ReferredFrom;
		public string ReferredFrom
		{
			set { _ReferredFrom = value; OnPropertyChanged("ReferredFrom"); }
			get { return _ReferredFrom; }
		}

		private string _ReferredBy;
		public string ReferredBy
		{
			set { _ReferredBy = value; OnPropertyChanged("ReferredBy"); }
			get { return _ReferredBy; }
		}

		private string _ReferredPhone;
		public string ReferredPhone
		{
			set { _ReferredPhone = value; OnPropertyChanged("ReferredPhone"); }
			get { return _ReferredPhone; }
		}

		private string _BirthPlace;
		public string BirthPlace
		{
			set { _BirthPlace = value; OnPropertyChanged("BirthPlace"); }
			get { return _BirthPlace; }
		}

		private int _AttendingPhysicianId;
		public int AttendingPhysicianId
		{
			set { _AttendingPhysicianId = value; OnPropertyChanged("AttendingPhysicianId"); }
			get { return _AttendingPhysicianId; }
		}

		private string _PhysicianService;
		public string PhysicianService
		{
			set { _PhysicianService = value; OnPropertyChanged("PhysicianService"); }
			get { return _PhysicianService; }
		}

		private int _AttendingNurseId;
		public int AttendingNurseId
		{
			set { _AttendingNurseId = value; OnPropertyChanged("AttendingNurseId"); }
			get { return _AttendingNurseId; }
		}

		private string _Remarks;
		public string Remarks
		{
			set { _Remarks = value; OnPropertyChanged("Remarks"); }
			get { return _Remarks; }
		}

		private string _ContactName;
		public string ContactName
		{
			set { _ContactName = value; OnPropertyChanged("ContactName"); }
			get { return _ContactName; }
		}

		private string _ContactPhone;
		public string ContactPhone
		{
			set { _ContactPhone = value; OnPropertyChanged("ContactPhone"); }
			get { return _ContactPhone; }
		}

		private int _BloodGroup;
		public int BloodGroup
		{
			set { _BloodGroup = value; OnPropertyChanged("BloodGroup"); }
			get { return _BloodGroup; }
		}

		private string _Allergies;
		public string Allergies
		{
			set { _Allergies = value; OnPropertyChanged("Allergies"); }
			get { return _Allergies; }
		}

		private string _Title;
		public string Title
		{
			set { _Title = value; OnPropertyChanged("Title"); }
			get { return _Title; }
		}

		private int _OccupationId;
		public int OccupationId
		{
			set { _OccupationId = value; OnPropertyChanged("OccupationId"); }
			get { return _OccupationId; }
		}

		private string _MailingAddress;
		public string MailingAddress
		{
			set { _MailingAddress = value; OnPropertyChanged("MailingAddress"); }
			get { return _MailingAddress; }
		}

		private int _OfflineFlag;
		public int OfflineFlag
		{
			set { _OfflineFlag = value; OnPropertyChanged("OfflineFlag"); }
			get { return _OfflineFlag; }
		}

		private int _StatusId;
		public int StatusId
		{
			set { _StatusId = value; OnPropertyChanged("StatusId"); }
			get { return _StatusId; }
		}

		private string _FileNumber;
		public string FileNumber
		{
			set { _FileNumber = value; OnPropertyChanged("FileNumber"); }
			get { return _FileNumber; }
		}

		private int _BedId;
		public int BedId
		{
			set { _BedId = value; OnPropertyChanged("BedId"); }
			get { return _BedId; }
		}

		private char _InCareDischargeType;
		public char InCareDischargeType
		{
			set { _InCareDischargeType = value; OnPropertyChanged("InCareDischargeType"); }
			get { return _InCareDischargeType; }
		}

		private int _UpdatedBy;
		public int UpdatedBy
		{
			set { _UpdatedBy = value; OnPropertyChanged("UpdatedBy"); }
			get { return _UpdatedBy; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		private string _HbysPatId;
		public string HbysPatId
		{
			set { _HbysPatId = value; OnPropertyChanged("HbysPatId"); }
			get { return _HbysPatId; }
		}

		private byte _IsForeign;
		public byte IsForeign
		{
			set { _IsForeign = value; OnPropertyChanged("IsForeign"); }
			get { return _IsForeign; }
		}

		public override string GetTableName()
		{
			return "Patient";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientDL _patientdlDL = new PatientDL())
				{
					return _patientdlDL.Insert(this);
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
				using(PatientDL _patientdlDL = new PatientDL())
				{
					return _patientdlDL.InsertAndGetId(this);
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
				using(PatientDL _patientdlDL = new PatientDL())
				{
					return _patientdlDL.Update(this);
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
				using(PatientDL _patientdlDL = new PatientDL())
				{
					return _patientdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
