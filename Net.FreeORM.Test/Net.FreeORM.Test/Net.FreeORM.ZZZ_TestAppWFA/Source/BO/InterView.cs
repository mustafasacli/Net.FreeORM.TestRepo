using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class InterView : BaseBO
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

		private int _StudentId;
		public int StudentId
		{
			set { _StudentId = value; OnPropertyChanged("StudentId"); }
			get { return _StudentId; }
		}

		private DateTime _InterViewTime;
		public DateTime InterViewTime
		{
			set { _InterViewTime = value; OnPropertyChanged("InterViewTime"); }
			get { return _InterViewTime; }
		}

		private string _Remarks;
		public string Remarks
		{
			set { _Remarks = value; OnPropertyChanged("Remarks"); }
			get { return _Remarks; }
		}

		private string _Comments;
		public string Comments
		{
			set { _Comments = value; OnPropertyChanged("Comments"); }
			get { return _Comments; }
		}

		public override string GetTableName()
		{
			return "InterView";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(InterViewDL _ınterviewdlDL = new InterViewDL())
				{
					return _ınterviewdlDL.Insert(this);
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
				using(InterViewDL _ınterviewdlDL = new InterViewDL())
				{
					return _ınterviewdlDL.InsertAndGetId(this);
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
				using(InterViewDL _ınterviewdlDL = new InterViewDL())
				{
					return _ınterviewdlDL.Update(this);
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
				using(InterViewDL _ınterviewdlDL = new InterViewDL())
				{
					return _ınterviewdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
