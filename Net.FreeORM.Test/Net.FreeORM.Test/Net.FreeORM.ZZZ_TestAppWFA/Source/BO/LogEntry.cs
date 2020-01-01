using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class LogEntry : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _Title;
		public string Title
		{
			set { _Title = value; OnPropertyChanged("Title"); }
			get { return _Title; }
		}

		private string _Message;
		public string Message
		{
			set { _Message = value; OnPropertyChanged("Message"); }
			get { return _Message; }
		}

		private string _StackTrace;
		public string StackTrace
		{
			set { _StackTrace = value; OnPropertyChanged("StackTrace"); }
			get { return _StackTrace; }
		}

		private DateTime _LogTime;
		public DateTime LogTime
		{
			set { _LogTime = value; OnPropertyChanged("LogTime"); }
			get { return _LogTime; }
		}

		private string _ErrorCode;
		public string ErrorCode
		{
			set { _ErrorCode = value; OnPropertyChanged("ErrorCode"); }
			get { return _ErrorCode; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private int _AppType;
		public int AppType
		{
			set { _AppType = value; OnPropertyChanged("AppType"); }
			get { return _AppType; }
		}

		private string _MachineName;
		public string MachineName
		{
			set { _MachineName = value; OnPropertyChanged("MachineName"); }
			get { return _MachineName; }
		}

		public override string GetTableName()
		{
			return "LogEntry";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(LogEntryDL _logentrydlDL = new LogEntryDL())
				{
					return _logentrydlDL.Insert(this);
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
				using(LogEntryDL _logentrydlDL = new LogEntryDL())
				{
					return _logentrydlDL.InsertAndGetId(this);
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
				using(LogEntryDL _logentrydlDL = new LogEntryDL())
				{
					return _logentrydlDL.Update(this);
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
				using(LogEntryDL _logentrydlDL = new LogEntryDL())
				{
					return _logentrydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
