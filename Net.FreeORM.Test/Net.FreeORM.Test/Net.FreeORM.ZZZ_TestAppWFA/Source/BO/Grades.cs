using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class Grades : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _GradeName;
		public string GradeName
		{
			set { _GradeName = value; OnPropertyChanged("GradeName"); }
			get { return _GradeName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Grades";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(GradesDL _gradesdlDL = new GradesDL())
				{
					return _gradesdlDL.Insert(this);
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
				using(GradesDL _gradesdlDL = new GradesDL())
				{
					return _gradesdlDL.InsertAndGetId(this);
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
				using(GradesDL _gradesdlDL = new GradesDL())
				{
					return _gradesdlDL.Update(this);
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
				using(GradesDL _gradesdlDL = new GradesDL())
				{
					return _gradesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
