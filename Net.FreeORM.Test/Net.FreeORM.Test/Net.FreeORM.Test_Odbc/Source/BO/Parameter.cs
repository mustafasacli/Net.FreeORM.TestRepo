using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Parameter : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ParameterName;
		public string ParameterName
		{
			set { _ParameterName = value; OnPropertyChanged("ParameterName"); }
			get { return _ParameterName; }
		}

		private int _ParameterType;
		public int ParameterType
		{
			set { _ParameterType = value; OnPropertyChanged("ParameterType"); }
			get { return _ParameterType; }
		}

		private int _UnitSetId;
		public int UnitSetId
		{
			set { _UnitSetId = value; OnPropertyChanged("UnitSetId"); }
			get { return _UnitSetId; }
		}

		private string _Abbreviation;
		public string Abbreviation
		{
			set { _Abbreviation = value; OnPropertyChanged("Abbreviation"); }
			get { return _Abbreviation; }
		}

		private Int16 _InfuseActive;
		public Int16 InfuseActive
		{
			set { _InfuseActive = value; OnPropertyChanged("InfuseActive"); }
			get { return _InfuseActive; }
		}

		private Int16 _RepeatedSetActive;
		public Int16 RepeatedSetActive
		{
			set { _RepeatedSetActive = value; OnPropertyChanged("RepeatedSetActive"); }
			get { return _RepeatedSetActive; }
		}

		private int _DefaultSetTimes;
		public int DefaultSetTimes
		{
			set { _DefaultSetTimes = value; OnPropertyChanged("DefaultSetTimes"); }
			get { return _DefaultSetTimes; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		private string _Barcode;
		public string Barcode
		{
			set { _Barcode = value; OnPropertyChanged("Barcode"); }
			get { return _Barcode; }
		}

		private string _AtcCode;
		public string AtcCode
		{
			set { _AtcCode = value; OnPropertyChanged("AtcCode"); }
			get { return _AtcCode; }
		}

		private byte _PrescriptionType;
		public byte PrescriptionType
		{
			set { _PrescriptionType = value; OnPropertyChanged("PrescriptionType"); }
			get { return _PrescriptionType; }
		}

		private int _Status;
		public int Status
		{
			set { _Status = value; OnPropertyChanged("Status"); }
			get { return _Status; }
		}

		public override string GetTableName()
		{
			return "Parameter";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ParameterDL _parameterdlDL = new ParameterDL())
				{
					return _parameterdlDL.Insert(this);
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
				using(ParameterDL _parameterdlDL = new ParameterDL())
				{
					return _parameterdlDL.InsertAndGetId(this);
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
				using(ParameterDL _parameterdlDL = new ParameterDL())
				{
					return _parameterdlDL.Update(this);
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
				using(ParameterDL _parameterdlDL = new ParameterDL())
				{
					return _parameterdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
