using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class Student : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
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

		private int _UserTypeId;
		public int UserTypeId
		{
			set { _UserTypeId = value; OnPropertyChanged("UserTypeId"); }
			get { return _UserTypeId; }
		}

		private string _Pass;
		public string Pass
		{
			set { _Pass = value; OnPropertyChanged("Pass"); }
			get { return _Pass; }
		}

		private string _EMail;
		public string EMail
		{
			set { _EMail = value; OnPropertyChanged("EMail"); }
			get { return _EMail; }
		}

		private string _Phone;
		public string Phone
		{
			set { _Phone = value; OnPropertyChanged("Phone"); }
			get { return _Phone; }
		}

		private string _IdentityNo;
		public string IdentityNo
		{
			set { _IdentityNo = value; OnPropertyChanged("IdentityNo"); }
			get { return _IdentityNo; }
		}

		private DateTime _BirthDate;
		public DateTime BirthDate
		{
			set { _BirthDate = value; OnPropertyChanged("BirthDate"); }
			get { return _BirthDate; }
		}

		private string _Address;
		public string Address
		{
			set { _Address = value; OnPropertyChanged("Address"); }
			get { return _Address; }
		}

		private DateTime _UserCreationDate;
		public DateTime UserCreationDate
		{
			set { _UserCreationDate = value; OnPropertyChanged("UserCreationDate"); }
			get { return _UserCreationDate; }
		}

		private int _CreatedByUser;
		public int CreatedByUser
		{
			set { _CreatedByUser = value; OnPropertyChanged("CreatedByUser"); }
			get { return _CreatedByUser; }
		}

		private string _MobilePhone;
		public string MobilePhone
		{
			set { _MobilePhone = value; OnPropertyChanged("MobilePhone"); }
			get { return _MobilePhone; }
		}

		private int _GradeId;
		public int GradeId
		{
			set { _GradeId = value; OnPropertyChanged("GradeId"); }
			get { return _GradeId; }
		}

		private int _School;
		public int School
		{
			set { _School = value; OnPropertyChanged("School"); }
			get { return _School; }
		}

		private int _Department;
		public int Department
		{
			set { _Department = value; OnPropertyChanged("Department"); }
			get { return _Department; }
		}

		private int _WorkState;
		public int WorkState
		{
			set { _WorkState = value; OnPropertyChanged("WorkState"); }
			get { return _WorkState; }
		}

		private int _Position;
		public int Position
		{
			set { _Position = value; OnPropertyChanged("Position"); }
			get { return _Position; }
		}

		private string _WorkPhone;
		public string WorkPhone
		{
			set { _WorkPhone = value; OnPropertyChanged("WorkPhone"); }
			get { return _WorkPhone; }
		}

		private string _WorkEMail;
		public string WorkEMail
		{
			set { _WorkEMail = value; OnPropertyChanged("WorkEMail"); }
			get { return _WorkEMail; }
		}

		private string _WorkAdress;
		public string WorkAdress
		{
			set { _WorkAdress = value; OnPropertyChanged("WorkAdress"); }
			get { return _WorkAdress; }
		}

		private int _UpdateUser;
		public int UpdateUser
		{
			set { _UpdateUser = value; OnPropertyChanged("UpdateUser"); }
			get { return _UpdateUser; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		private int _CompanyId;
		public int CompanyId
		{
			set { _CompanyId = value; OnPropertyChanged("CompanyId"); }
			get { return _CompanyId; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Student";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(StudentDL _studentdlDL = new StudentDL())
				{
					return _studentdlDL.Insert(this);
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
				using(StudentDL _studentdlDL = new StudentDL())
				{
					return _studentdlDL.InsertAndGetId(this);
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
				using(StudentDL _studentdlDL = new StudentDL())
				{
					return _studentdlDL.Update(this);
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
				using(StudentDL _studentdlDL = new StudentDL())
				{
					return _studentdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
