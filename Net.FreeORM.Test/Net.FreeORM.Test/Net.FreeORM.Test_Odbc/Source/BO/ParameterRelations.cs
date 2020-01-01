using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ParameterRelations : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _OrderCategoryId;
		public int OrderCategoryId
		{
			set { _OrderCategoryId = value; OnPropertyChanged("OrderCategoryId"); }
			get { return _OrderCategoryId; }
		}

		private int _ParameterId;
		public int ParameterId
		{
			set { _ParameterId = value; OnPropertyChanged("ParameterId"); }
			get { return _ParameterId; }
		}

		private int _RelatedParameterId;
		public int RelatedParameterId
		{
			set { _RelatedParameterId = value; OnPropertyChanged("RelatedParameterId"); }
			get { return _RelatedParameterId; }
		}

		private Int16 _IsActive;
		public Int16 IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "ParameterRelations";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ParameterRelationsDL _parameterrelationsdlDL = new ParameterRelationsDL())
				{
					return _parameterrelationsdlDL.Insert(this);
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
				using(ParameterRelationsDL _parameterrelationsdlDL = new ParameterRelationsDL())
				{
					return _parameterrelationsdlDL.InsertAndGetId(this);
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
				using(ParameterRelationsDL _parameterrelationsdlDL = new ParameterRelationsDL())
				{
					return _parameterrelationsdlDL.Update(this);
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
				using(ParameterRelationsDL _parameterrelationsdlDL = new ParameterRelationsDL())
				{
					return _parameterrelationsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
