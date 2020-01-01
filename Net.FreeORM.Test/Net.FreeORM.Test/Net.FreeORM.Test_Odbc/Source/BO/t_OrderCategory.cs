using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_OrderCategory : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _OrderCatName;
		public string OrderCatName
		{
			set { _OrderCatName = value; OnPropertyChanged("OrderCatName"); }
			get { return _OrderCatName; }
		}

		private Int16 _HasAdditives;
		public Int16 HasAdditives
		{
			set { _HasAdditives = value; OnPropertyChanged("HasAdditives"); }
			get { return _HasAdditives; }
		}

		private int _ParentId;
		public int ParentId
		{
			set { _ParentId = value; OnPropertyChanged("ParentId"); }
			get { return _ParentId; }
		}

		private Int16 _ShowInTree;
		public Int16 ShowInTree
		{
			set { _ShowInTree = value; OnPropertyChanged("ShowInTree"); }
			get { return _ShowInTree; }
		}

		private string _OrderCategoryXMLPattern;
		public string OrderCategoryXMLPattern
		{
			set { _OrderCategoryXMLPattern = value; OnPropertyChanged("OrderCategoryXMLPattern"); }
			get { return _OrderCategoryXMLPattern; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_OrderCategory";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_OrderCategoryDL _t_ordercategorydlDL = new t_OrderCategoryDL())
				{
					return _t_ordercategorydlDL.Insert(this);
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
				using(t_OrderCategoryDL _t_ordercategorydlDL = new t_OrderCategoryDL())
				{
					return _t_ordercategorydlDL.InsertAndGetId(this);
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
				using(t_OrderCategoryDL _t_ordercategorydlDL = new t_OrderCategoryDL())
				{
					return _t_ordercategorydlDL.Update(this);
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
				using(t_OrderCategoryDL _t_ordercategorydlDL = new t_OrderCategoryDL())
				{
					return _t_ordercategorydlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
