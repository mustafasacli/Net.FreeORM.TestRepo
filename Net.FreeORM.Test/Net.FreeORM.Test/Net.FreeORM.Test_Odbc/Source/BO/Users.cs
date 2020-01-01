using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Users : BaseBO
	{
		private string _OBJID;
		public string OBJID
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

		private string _Email;
		public string Email
		{
			set { _Email = value; OnPropertyChanged("Email"); }
			get { return _Email; }
		}

		private string _UserName;
		public string UserName
		{
			set { _UserName = value; OnPropertyChanged("UserName"); }
			get { return _UserName; }
		}

		private string _Password;
		public string Password
		{
			set { _Password = value; OnPropertyChanged("Password"); }
			get { return _Password; }
		}

		private int _UserTypeId;
		public int UserTypeId
		{
			set { _UserTypeId = value; OnPropertyChanged("UserTypeId"); }
			get { return _UserTypeId; }
		}

		private string _Address;
		public string Address
		{
			set { _Address = value; OnPropertyChanged("Address"); }
			get { return _Address; }
		}

		private DateTime _BirthDate;
		public DateTime BirthDate
		{
			set { _BirthDate = value; OnPropertyChanged("BirthDate"); }
			get { return _BirthDate; }
		}

		private string _Picture;
		public string Picture
		{
			set { _Picture = value; OnPropertyChanged("Picture"); }
			get { return _Picture; }
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

		private Int16 _IsActive;
		public Int16 IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		private string _HbysUserId;
		public string HbysUserId
		{
			set { _HbysUserId = value; OnPropertyChanged("HbysUserId"); }
			get { return _HbysUserId; }
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
