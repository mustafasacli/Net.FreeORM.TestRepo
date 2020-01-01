using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class Operations : BaseBO
	{
		private int _OBJID;
		public int OBJID
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

		private string _OperationCode;
		public string OperationCode
		{
			set { _OperationCode = value; OnPropertyChanged("OperationCode"); }
			get { return _OperationCode; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "Operations";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(OperationsDL _operationsdlDL = new OperationsDL())
				{
					return _operationsdlDL.Insert(this);
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
				using(OperationsDL _operationsdlDL = new OperationsDL())
				{
					return _operationsdlDL.InsertAndGetId(this);
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
				using(OperationsDL _operationsdlDL = new OperationsDL())
				{
					return _operationsdlDL.Update(this);
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
				using(OperationsDL _operationsdlDL = new OperationsDL())
				{
					return _operationsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
