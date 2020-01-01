using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class PaymentType : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _PaymentTypeName;
		public string PaymentTypeName
		{
			set { _PaymentTypeName = value; OnPropertyChanged("PaymentTypeName"); }
			get { return _PaymentTypeName; }
		}

		public override string GetTableName()
		{
			return "PaymentType";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(PaymentTypeDL _paymenttypedlDL = new PaymentTypeDL())
				{
					return _paymenttypedlDL.Insert(this);
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
				using(PaymentTypeDL _paymenttypedlDL = new PaymentTypeDL())
				{
					return _paymenttypedlDL.InsertAndGetId(this);
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
				using(PaymentTypeDL _paymenttypedlDL = new PaymentTypeDL())
				{
					return _paymenttypedlDL.Update(this);
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
				using(PaymentTypeDL _paymenttypedlDL = new PaymentTypeDL())
				{
					return _paymenttypedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
