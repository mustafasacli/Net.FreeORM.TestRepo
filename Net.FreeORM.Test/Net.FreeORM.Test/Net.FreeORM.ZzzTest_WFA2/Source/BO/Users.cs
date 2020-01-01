using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class Users : BaseBO
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

		private string _UserName;
		public string UserName
		{
			set { _UserName = value; OnPropertyChanged("UserName"); }
			get { return _UserName; }
		}

		private string _Pass;
		public string Pass
		{
			set { _Pass = value; OnPropertyChanged("Pass"); }
			get { return _Pass; }
		}

		private string _IdentityNo;
		public string IdentityNo
		{
			set { _IdentityNo = value; OnPropertyChanged("IdentityNo"); }
			get { return _IdentityNo; }
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

		private int _UpdateUserId;
		public int UpdateUserId
		{
			set { _UpdateUserId = value; OnPropertyChanged("UpdateUserId"); }
			get { return _UpdateUserId; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Users";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(UsersDL _usersdlDL = new UsersDL())
				{
					return _usersdlDL.Insert(this);
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
				using(UsersDL _usersdlDL = new UsersDL())
				{
					return _usersdlDL.InsertAndGetId(this);
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
				using(UsersDL _usersdlDL = new UsersDL())
				{
					return _usersdlDL.Update(this);
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
				using(UsersDL _usersdlDL = new UsersDL())
				{
					return _usersdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
