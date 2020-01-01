using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class UserToUserNote : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _UserFrom;
		public int UserFrom
		{
			set { _UserFrom = value; OnPropertyChanged("UserFrom"); }
			get { return _UserFrom; }
		}

		private int _UserTo;
		public int UserTo
		{
			set { _UserTo = value; OnPropertyChanged("UserTo"); }
			get { return _UserTo; }
		}

		private DateTime _CreationDate;
		public DateTime CreationDate
		{
			set { _CreationDate = value; OnPropertyChanged("CreationDate"); }
			get { return _CreationDate; }
		}

		private string _Title;
		public string Title
		{
			set { _Title = value; OnPropertyChanged("Title"); }
			get { return _Title; }
		}

		private string _Description;
		public string Description
		{
			set { _Description = value; OnPropertyChanged("Description"); }
			get { return _Description; }
		}

		private bool _Active;
		public bool Active
		{
			set { _Active = value; OnPropertyChanged("Active"); }
			get { return _Active; }
		}

		public override string GetTableName()
		{
			return "UserToUserNote";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(UserToUserNoteDL _usertousernotedlDL = new UserToUserNoteDL())
				{
					return _usertousernotedlDL.Insert(this);
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
				using(UserToUserNoteDL _usertousernotedlDL = new UserToUserNoteDL())
				{
					return _usertousernotedlDL.InsertAndGetId(this);
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
				using(UserToUserNoteDL _usertousernotedlDL = new UserToUserNoteDL())
				{
					return _usertousernotedlDL.Update(this);
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
				using(UserToUserNoteDL _usertousernotedlDL = new UserToUserNoteDL())
				{
					return _usertousernotedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
