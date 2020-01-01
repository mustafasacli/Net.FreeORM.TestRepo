using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class CourseTypes : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _CourseTypeName;
		public string CourseTypeName
		{
			set { _CourseTypeName = value; OnPropertyChanged("CourseTypeName"); }
			get { return _CourseTypeName; }
		}

		private string _CourseTypeCode;
		public string CourseTypeCode
		{
			set { _CourseTypeCode = value; OnPropertyChanged("CourseTypeCode"); }
			get { return _CourseTypeCode; }
		}

		public override string GetTableName()
		{
			return "t_CourseTypes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(CourseTypesDL _t_coursetypesdlDL = new CourseTypesDL())
				{
					return _t_coursetypesdlDL.Insert(this);
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
				using(CourseTypesDL _t_coursetypesdlDL = new CourseTypesDL())
				{
					return _t_coursetypesdlDL.InsertAndGetId(this);
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
				using(CourseTypesDL _t_coursetypesdlDL = new CourseTypesDL())
				{
					return _t_coursetypesdlDL.Update(this);
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
				using(CourseTypesDL _t_coursetypesdlDL = new CourseTypesDL())
				{
					return _t_coursetypesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
