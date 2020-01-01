using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class TransactionLog : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private DateTime _LogTime;
		public DateTime LogTime
		{
			set { _LogTime = value; OnPropertyChanged("LogTime"); }
			get { return _LogTime; }
		}

		private string _FormName;
		public string FormName
		{
			set { _FormName = value; OnPropertyChanged("FormName"); }
			get { return _FormName; }
		}

		private string _ControlTag;
		public string ControlTag
		{
			set { _ControlTag = value; OnPropertyChanged("ControlTag"); }
			get { return _ControlTag; }
		}

		private string _ControlName;
		public string ControlName
		{
			set { _ControlName = value; OnPropertyChanged("ControlName"); }
			get { return _ControlName; }
		}

		private int _LogObject;
		public int LogObject
		{
			set { _LogObject = value; OnPropertyChanged("LogObject"); }
			get { return _LogObject; }
		}

		private string _TransactionType;
		public string TransactionType
		{
			set { _TransactionType = value; OnPropertyChanged("TransactionType"); }
			get { return _TransactionType; }
		}

		public override string GetTableName()
		{
			return "TransactionLog";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(TransactionLogDL _transactionlogdlDL = new TransactionLogDL())
				{
					return _transactionlogdlDL.Insert(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int InsertAndGetId()
		{
			try
			{
				using(TransactionLogDL _transactionlogdlDL = new TransactionLogDL())
				{
					return _transactionlogdlDL.InsertAndGetId(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Update()
		{
			try
			{
				using(TransactionLogDL _transactionlogdlDL = new TransactionLogDL())
				{
					return _transactionlogdlDL.Update(this);
				}
			}
			catch
			{
				throw;
			}
		}

		public int Delete()
		{
			try
			{
				using(TransactionLogDL _transactionlogdlDL = new TransactionLogDL())
				{
					return _transactionlogdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
