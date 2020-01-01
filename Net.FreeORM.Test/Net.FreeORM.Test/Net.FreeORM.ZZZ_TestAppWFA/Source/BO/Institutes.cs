using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class Institutes : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _InstituteName;
		public string InstituteName
		{
			set { _InstituteName = value; OnPropertyChanged("InstituteName"); }
			get { return _InstituteName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Institutes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(InstitutesDL _t_ınstitutesdlDL = new InstitutesDL())
				{
					return _t_ınstitutesdlDL.Insert(this);
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
				using(InstitutesDL _t_ınstitutesdlDL = new InstitutesDL())
				{
					return _t_ınstitutesdlDL.InsertAndGetId(this);
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
				using(InstitutesDL _t_ınstitutesdlDL = new InstitutesDL())
				{
					return _t_ınstitutesdlDL.Update(this);
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
				using(InstitutesDL _t_ınstitutesdlDL = new InstitutesDL())
				{
					return _t_ınstitutesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
