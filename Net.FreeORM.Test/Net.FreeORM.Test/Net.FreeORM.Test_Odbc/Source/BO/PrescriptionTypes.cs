using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PrescriptionTypes : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _PrescriptionTypeName;
		public string PrescriptionTypeName
		{
			set { _PrescriptionTypeName = value; OnPropertyChanged("PrescriptionTypeName"); }
			get { return _PrescriptionTypeName; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "PrescriptionTypes";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PrescriptionTypesDL _prescriptiontypesdlDL = new PrescriptionTypesDL())
				{
					return _prescriptiontypesdlDL.Insert(this);
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
				using(PrescriptionTypesDL _prescriptiontypesdlDL = new PrescriptionTypesDL())
				{
					return _prescriptiontypesdlDL.InsertAndGetId(this);
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
				using(PrescriptionTypesDL _prescriptiontypesdlDL = new PrescriptionTypesDL())
				{
					return _prescriptiontypesdlDL.Update(this);
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
				using(PrescriptionTypesDL _prescriptiontypesdlDL = new PrescriptionTypesDL())
				{
					return _prescriptiontypesdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
