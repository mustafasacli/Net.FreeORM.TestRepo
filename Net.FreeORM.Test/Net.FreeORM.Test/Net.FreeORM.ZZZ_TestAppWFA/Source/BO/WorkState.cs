using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class WorkState : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _WorkStateName;
		public string WorkStateName
		{
			set { _WorkStateName = value; OnPropertyChanged("WorkStateName"); }
			get { return _WorkStateName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "WorkState";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(WorkStateDL _workstatedlDL = new WorkStateDL())
				{
					return _workstatedlDL.Insert(this);
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
				using(WorkStateDL _workstatedlDL = new WorkStateDL())
				{
					return _workstatedlDL.InsertAndGetId(this);
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
				using(WorkStateDL _workstatedlDL = new WorkStateDL())
				{
					return _workstatedlDL.Update(this);
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
				using(WorkStateDL _workstatedlDL = new WorkStateDL())
				{
					return _workstatedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
