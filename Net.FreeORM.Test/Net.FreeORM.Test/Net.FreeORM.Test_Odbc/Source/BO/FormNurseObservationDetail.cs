using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormNurseObservationDetail : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _MasterFormId;
		public int MasterFormId
		{
			set { _MasterFormId = value; OnPropertyChanged("MasterFormId"); }
			get { return _MasterFormId; }
		}

		private int _RowCreatedBy;
		public int RowCreatedBy
		{
			set { _RowCreatedBy = value; OnPropertyChanged("RowCreatedBy"); }
			get { return _RowCreatedBy; }
		}

		private DateTime _RowCreatedDate;
		public DateTime RowCreatedDate
		{
			set { _RowCreatedDate = value; OnPropertyChanged("RowCreatedDate"); }
			get { return _RowCreatedDate; }
		}

		private double _Temperature;
		public double Temperature
		{
			set { _Temperature = value; OnPropertyChanged("Temperature"); }
			get { return _Temperature; }
		}

		private int _HeartBeat;
		public int HeartBeat
		{
			set { _HeartBeat = value; OnPropertyChanged("HeartBeat"); }
			get { return _HeartBeat; }
		}

		private double _BloodPressure;
		public double BloodPressure
		{
			set { _BloodPressure = value; OnPropertyChanged("BloodPressure"); }
			get { return _BloodPressure; }
		}

		private double _Respiratory;
		public double Respiratory
		{
			set { _Respiratory = value; OnPropertyChanged("Respiratory"); }
			get { return _Respiratory; }
		}

		private int _DrugId;
		public int DrugId
		{
			set { _DrugId = value; OnPropertyChanged("DrugId"); }
			get { return _DrugId; }
		}

		private int _RouteId;
		public int RouteId
		{
			set { _RouteId = value; OnPropertyChanged("RouteId"); }
			get { return _RouteId; }
		}

		private DateTime _ScheduleTimes;
		public DateTime ScheduleTimes
		{
			set { _ScheduleTimes = value; OnPropertyChanged("ScheduleTimes"); }
			get { return _ScheduleTimes; }
		}

		private int _Diet;
		public int Diet
		{
			set { _Diet = value; OnPropertyChanged("Diet"); }
			get { return _Diet; }
		}

		private string _ObservationNotes;
		public string ObservationNotes
		{
			set { _ObservationNotes = value; OnPropertyChanged("ObservationNotes"); }
			get { return _ObservationNotes; }
		}

		private byte[] _NurseSign;
		public byte[] NurseSign
		{
			set { _NurseSign = value; OnPropertyChanged("NurseSign"); }
			get { return _NurseSign; }
		}

		private int _StandartTimes;
		public int StandartTimes
		{
			set { _StandartTimes = value; OnPropertyChanged("StandartTimes"); }
			get { return _StandartTimes; }
		}

		private byte _IsDrugFromOrder;
		public byte IsDrugFromOrder
		{
			set { _IsDrugFromOrder = value; OnPropertyChanged("IsDrugFromOrder"); }
			get { return _IsDrugFromOrder; }
		}

		private byte _IsDietFromOrder;
		public byte IsDietFromOrder
		{
			set { _IsDietFromOrder = value; OnPropertyChanged("IsDietFromOrder"); }
			get { return _IsDietFromOrder; }
		}

		private int _Dose;
		public int Dose
		{
			set { _Dose = value; OnPropertyChanged("Dose"); }
			get { return _Dose; }
		}

		private int _DoseId;
		public int DoseId
		{
			set { _DoseId = value; OnPropertyChanged("DoseId"); }
			get { return _DoseId; }
		}

		private int _RowUpdatedBy;
		public int RowUpdatedBy
		{
			set { _RowUpdatedBy = value; OnPropertyChanged("RowUpdatedBy"); }
			get { return _RowUpdatedBy; }
		}

		private DateTime _RowUpdatedDate;
		public DateTime RowUpdatedDate
		{
			set { _RowUpdatedDate = value; OnPropertyChanged("RowUpdatedDate"); }
			get { return _RowUpdatedDate; }
		}

		public override string GetTableName()
		{
			return "FormNurseObservationDetail";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormNurseObservationDetailDL _formnurseobservationdetaildlDL = new FormNurseObservationDetailDL())
				{
					return _formnurseobservationdetaildlDL.Insert(this);
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
				using(FormNurseObservationDetailDL _formnurseobservationdetaildlDL = new FormNurseObservationDetailDL())
				{
					return _formnurseobservationdetaildlDL.InsertAndGetId(this);
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
				using(FormNurseObservationDetailDL _formnurseobservationdetaildlDL = new FormNurseObservationDetailDL())
				{
					return _formnurseobservationdetaildlDL.Update(this);
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
				using(FormNurseObservationDetailDL _formnurseobservationdetaildlDL = new FormNurseObservationDetailDL())
				{
					return _formnurseobservationdetaildlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
