using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ParameterActiveSubstance : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _ParameterId;
		public int ParameterId
		{
			set { _ParameterId = value; OnPropertyChanged("ParameterId"); }
			get { return _ParameterId; }
		}

		private int _ActiveSubstanceId;
		public int ActiveSubstanceId
		{
			set { _ActiveSubstanceId = value; OnPropertyChanged("ActiveSubstanceId"); }
			get { return _ActiveSubstanceId; }
		}

		public override string GetTableName()
		{
			return "ParameterActiveSubstance";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ParameterActiveSubstanceDL _parameteractivesubstancedlDL = new ParameterActiveSubstanceDL())
				{
					return _parameteractivesubstancedlDL.Insert(this);
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
				using(ParameterActiveSubstanceDL _parameteractivesubstancedlDL = new ParameterActiveSubstanceDL())
				{
					return _parameteractivesubstancedlDL.InsertAndGetId(this);
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
				using(ParameterActiveSubstanceDL _parameteractivesubstancedlDL = new ParameterActiveSubstanceDL())
				{
					return _parameteractivesubstancedlDL.Update(this);
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
				using(ParameterActiveSubstanceDL _parameteractivesubstancedlDL = new ParameterActiveSubstanceDL())
				{
					return _parameteractivesubstancedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
