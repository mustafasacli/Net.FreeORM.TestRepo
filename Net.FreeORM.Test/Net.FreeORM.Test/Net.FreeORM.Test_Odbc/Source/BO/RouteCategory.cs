using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class RouteCategory : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _RouteId;
		public int RouteId
		{
			set { _RouteId = value; OnPropertyChanged("RouteId"); }
			get { return _RouteId; }
		}

		private int _OrderCategoryId;
		public int OrderCategoryId
		{
			set { _OrderCategoryId = value; OnPropertyChanged("OrderCategoryId"); }
			get { return _OrderCategoryId; }
		}

		public override string GetTableName()
		{
			return "RouteCategory";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(RouteCategoryDL _routecategorydlDL = new RouteCategoryDL())
				{
					return _routecategorydlDL.Insert(this);
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
				using(RouteCategoryDL _routecategorydlDL = new RouteCategoryDL())
				{
					return _routecategorydlDL.InsertAndGetId(this);
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
				using(RouteCategoryDL _routecategorydlDL = new RouteCategoryDL())
				{
					return _routecategorydlDL.Update(this);
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
				using(RouteCategoryDL _routecategorydlDL = new RouteCategoryDL())
				{
					return _routecategorydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
