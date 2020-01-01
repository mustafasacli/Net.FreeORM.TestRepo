using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class Vendors : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _VendorName;
		public string VendorName
		{
			set { _VendorName = value; OnPropertyChanged("VendorName"); }
			get { return _VendorName; }
		}

		public override string GetTableName()
		{
			return "t_Vendors";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(VendorsDL _t_vendorsdlDL = new VendorsDL())
				{
					return _t_vendorsdlDL.Insert(this);
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
				using(VendorsDL _t_vendorsdlDL = new VendorsDL())
				{
					return _t_vendorsdlDL.InsertAndGetId(this);
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
				using(VendorsDL _t_vendorsdlDL = new VendorsDL())
				{
					return _t_vendorsdlDL.Update(this);
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
				using(VendorsDL _t_vendorsdlDL = new VendorsDL())
				{
					return _t_vendorsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
