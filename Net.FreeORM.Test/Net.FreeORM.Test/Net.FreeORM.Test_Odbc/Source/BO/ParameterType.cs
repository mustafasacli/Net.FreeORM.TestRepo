using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ParameterType : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TypeName;
		public string TypeName
		{
			set { _TypeName = value; OnPropertyChanged("TypeName"); }
			get { return _TypeName; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "ParameterType";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ParameterTypeDL _parametertypedlDL = new ParameterTypeDL())
				{
					return _parametertypedlDL.Insert(this);
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
				using(ParameterTypeDL _parametertypedlDL = new ParameterTypeDL())
				{
					return _parametertypedlDL.InsertAndGetId(this);
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
				using(ParameterTypeDL _parametertypedlDL = new ParameterTypeDL())
				{
					return _parametertypedlDL.Update(this);
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
				using(ParameterTypeDL _parametertypedlDL = new ParameterTypeDL())
				{
					return _parametertypedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
