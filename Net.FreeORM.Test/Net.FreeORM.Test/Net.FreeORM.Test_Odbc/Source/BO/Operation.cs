using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Operation : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _OperationName;
		public string OperationName
		{
			set { _OperationName = value; OnPropertyChanged("OperationName"); }
			get { return _OperationName; }
		}

		private string _Operationcode;
		public string Operationcode
		{
			set { _Operationcode = value; OnPropertyChanged("Operationcode"); }
			get { return _Operationcode; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Operation";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(OperationDL _operationdlDL = new OperationDL())
				{
					return _operationdlDL.Insert(this);
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
				using(OperationDL _operationdlDL = new OperationDL())
				{
					return _operationdlDL.InsertAndGetId(this);
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
				using(OperationDL _operationdlDL = new OperationDL())
				{
					return _operationdlDL.Update(this);
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
				using(OperationDL _operationdlDL = new OperationDL())
				{
					return _operationdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
