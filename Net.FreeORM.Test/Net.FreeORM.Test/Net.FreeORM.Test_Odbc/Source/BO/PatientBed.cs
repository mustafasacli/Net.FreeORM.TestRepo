using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class PatientBed : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _PatientId;
		public int PatientId
		{
			set { _PatientId = value; OnPropertyChanged("PatientId"); }
			get { return _PatientId; }
		}

		private DateTime _FromTime;
		public DateTime FromTime
		{
			set { _FromTime = value; OnPropertyChanged("FromTime"); }
			get { return _FromTime; }
		}

		private int _BedId;
		public int BedId
		{
			set { _BedId = value; OnPropertyChanged("BedId"); }
			get { return _BedId; }
		}

		private int _UpdateUserId;
		public int UpdateUserId
		{
			set { _UpdateUserId = value; OnPropertyChanged("UpdateUserId"); }
			get { return _UpdateUserId; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		public override string GetTableName()
		{
			return "PatientBed";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(PatientBedDL _patientbeddlDL = new PatientBedDL())
				{
					return _patientbeddlDL.Insert(this);
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
				using(PatientBedDL _patientbeddlDL = new PatientBedDL())
				{
					return _patientbeddlDL.InsertAndGetId(this);
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
				using(PatientBedDL _patientbeddlDL = new PatientBedDL())
				{
					return _patientbeddlDL.Update(this);
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
				using(PatientBedDL _patientbeddlDL = new PatientBedDL())
				{
					return _patientbeddlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
