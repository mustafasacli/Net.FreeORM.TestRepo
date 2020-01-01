using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ActiveSubstance : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ActiveSubstanceName;
		public string ActiveSubstanceName
		{
			set { _ActiveSubstanceName = value; OnPropertyChanged("ActiveSubstanceName"); }
			get { return _ActiveSubstanceName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "ActiveSubstance";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ActiveSubstanceDL _activesubstancedlDL = new ActiveSubstanceDL())
				{
					return _activesubstancedlDL.Insert(this);
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
				using(ActiveSubstanceDL _activesubstancedlDL = new ActiveSubstanceDL())
				{
					return _activesubstancedlDL.InsertAndGetId(this);
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
				using(ActiveSubstanceDL _activesubstancedlDL = new ActiveSubstanceDL())
				{
					return _activesubstancedlDL.Update(this);
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
				using(ActiveSubstanceDL _activesubstancedlDL = new ActiveSubstanceDL())
				{
					return _activesubstancedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
