using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_EducationStates : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _EducationStateName;
		public string EducationStateName
		{
			set { _EducationStateName = value; OnPropertyChanged("EducationStateName"); }
			get { return _EducationStateName; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_EducationStates";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_EducationStatesDL _t_educationstatesdlDL = new t_EducationStatesDL())
				{
					return _t_educationstatesdlDL.Insert(this);
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
				using(t_EducationStatesDL _t_educationstatesdlDL = new t_EducationStatesDL())
				{
					return _t_educationstatesdlDL.InsertAndGetId(this);
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
				using(t_EducationStatesDL _t_educationstatesdlDL = new t_EducationStatesDL())
				{
					return _t_educationstatesdlDL.Update(this);
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
				using(t_EducationStatesDL _t_educationstatesdlDL = new t_EducationStatesDL())
				{
					return _t_educationstatesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
