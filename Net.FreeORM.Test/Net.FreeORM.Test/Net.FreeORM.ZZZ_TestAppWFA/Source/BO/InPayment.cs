using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;

namespace Net.FreeORM.ZZZ_TestAppWFA.Source.BO
{
	public class InPayment : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private int _StudentId;
		public int StudentId
		{
			set { _StudentId = value; OnPropertyChanged("StudentId"); }
			get { return _StudentId; }
		}

		private float _Amount;
		public float Amount
		{
			set { _Amount = value; OnPropertyChanged("Amount"); }
			get { return _Amount; }
		}

		private DateTime _PaymentTime;
		public DateTime PaymentTime
		{
			set { _PaymentTime = value; OnPropertyChanged("PaymentTime"); }
			get { return _PaymentTime; }
		}

		private int _PaymentType;
		public int PaymentType
		{
			set { _PaymentType = value; OnPropertyChanged("PaymentType"); }
			get { return _PaymentType; }
		}

		private int _BillType;
		public int BillType
		{
			set { _BillType = value; OnPropertyChanged("BillType"); }
			get { return _BillType; }
		}

		public override string GetTableName()
		{
			return "InPayment";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		public int Insert()
		{
			try
			{
				using(InPaymentDL _ınpaymentdlDL = new InPaymentDL())
				{
					return _ınpaymentdlDL.Insert(this);
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
				using(InPaymentDL _ınpaymentdlDL = new InPaymentDL())
				{
					return _ınpaymentdlDL.InsertAndGetId(this);
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
				using(InPaymentDL _ınpaymentdlDL = new InPaymentDL())
				{
					return _ınpaymentdlDL.Update(this);
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
				using(InPaymentDL _ınpaymentdlDL = new InPaymentDL())
				{
					return _ınpaymentdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
