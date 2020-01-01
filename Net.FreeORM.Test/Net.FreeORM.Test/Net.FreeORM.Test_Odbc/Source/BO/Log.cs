using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Log : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private DateTime _Date;
		public DateTime Date
		{
			set { _Date = value; OnPropertyChanged("Date"); }
			get { return _Date; }
		}

		private string _Title;
		public string Title
		{
			set { _Title = value; OnPropertyChanged("Title"); }
			get { return _Title; }
		}

		private int _Category;
		public int Category
		{
			set { _Category = value; OnPropertyChanged("Category"); }
			get { return _Category; }
		}

		private string _OriginalMessage;
		public string OriginalMessage
		{
			set { _OriginalMessage = value; OnPropertyChanged("OriginalMessage"); }
			get { return _OriginalMessage; }
		}

		private string _StackTrace;
		public string StackTrace
		{
			set { _StackTrace = value; OnPropertyChanged("StackTrace"); }
			get { return _StackTrace; }
		}

		private string _ResponseCode;
		public string ResponseCode
		{
			set { _ResponseCode = value; OnPropertyChanged("ResponseCode"); }
			get { return _ResponseCode; }
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

		public override string GetTableName()
		{
			return "Log";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(LogDL _logdlDL = new LogDL())
				{
					return _logdlDL.Insert(this);
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
				using(LogDL _logdlDL = new LogDL())
				{
					return _logdlDL.InsertAndGetId(this);
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
				using(LogDL _logdlDL = new LogDL())
				{
					return _logdlDL.Update(this);
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
				using(LogDL _logdlDL = new LogDL())
				{
					return _logdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
