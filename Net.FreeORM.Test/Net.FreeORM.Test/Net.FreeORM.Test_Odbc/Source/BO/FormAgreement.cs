using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormAgreement : BaseBO
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

		private string _PatientIdentificationNumber;
		public string PatientIdentificationNumber
		{
			set { _PatientIdentificationNumber = value; OnPropertyChanged("PatientIdentificationNumber"); }
			get { return _PatientIdentificationNumber; }
		}

		private string _ProtocolNo;
		public string ProtocolNo
		{
			set { _ProtocolNo = value; OnPropertyChanged("ProtocolNo"); }
			get { return _ProtocolNo; }
		}

		private string _PatientRelative;
		public string PatientRelative
		{
			set { _PatientRelative = value; OnPropertyChanged("PatientRelative"); }
			get { return _PatientRelative; }
		}

		private int _DoctorId;
		public int DoctorId
		{
			set { _DoctorId = value; OnPropertyChanged("DoctorId"); }
			get { return _DoctorId; }
		}

		private string _Translator;
		public string Translator
		{
			set { _Translator = value; OnPropertyChanged("Translator"); }
			get { return _Translator; }
		}

		private byte _Unconcious;
		public byte Unconcious
		{
			set { _Unconcious = value; OnPropertyChanged("Unconcious"); }
			get { return _Unconcious; }
		}

		private byte _NotMinor;
		public byte NotMinor
		{
			set { _NotMinor = value; OnPropertyChanged("NotMinor"); }
			get { return _NotMinor; }
		}

		private byte _NonDecisionMaker;
		public byte NonDecisionMaker
		{
			set { _NonDecisionMaker = value; OnPropertyChanged("NonDecisionMaker"); }
			get { return _NonDecisionMaker; }
		}

		private byte _Urgent;
		public byte Urgent
		{
			set { _Urgent = value; OnPropertyChanged("Urgent"); }
			get { return _Urgent; }
		}

		private DateTime _SignedDate;
		public DateTime SignedDate
		{
			set { _SignedDate = value; OnPropertyChanged("SignedDate"); }
			get { return _SignedDate; }
		}

		private string _PatientRelativeDegree;
		public string PatientRelativeDegree
		{
			set { _PatientRelativeDegree = value; OnPropertyChanged("PatientRelativeDegree"); }
			get { return _PatientRelativeDegree; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "FormAgreement";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormAgreementDL _formagreementdlDL = new FormAgreementDL())
				{
					return _formagreementdlDL.Insert(this);
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
				using(FormAgreementDL _formagreementdlDL = new FormAgreementDL())
				{
					return _formagreementdlDL.InsertAndGetId(this);
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
				using(FormAgreementDL _formagreementdlDL = new FormAgreementDL())
				{
					return _formagreementdlDL.Update(this);
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
				using(FormAgreementDL _formagreementdlDL = new FormAgreementDL())
				{
					return _formagreementdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
