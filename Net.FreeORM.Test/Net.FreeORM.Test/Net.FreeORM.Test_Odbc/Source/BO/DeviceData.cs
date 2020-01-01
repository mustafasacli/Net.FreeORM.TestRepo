using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class DeviceData : BaseBO
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

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		private int _DeviceId;
		public int DeviceId
		{
			set { _DeviceId = value; OnPropertyChanged("DeviceId"); }
			get { return _DeviceId; }
		}

		private DateTime _Date;
		public DateTime Date
		{
			set { _Date = value; OnPropertyChanged("Date"); }
			get { return _Date; }
		}

		private string _Data;
		public string Data
		{
			set { _Data = value; OnPropertyChanged("Data"); }
			get { return _Data; }
		}

		public override string GetTableName()
		{
			return "DeviceData";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(DeviceDataDL _devicedatadlDL = new DeviceDataDL())
				{
					return _devicedatadlDL.Insert(this);
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
				using(DeviceDataDL _devicedatadlDL = new DeviceDataDL())
				{
					return _devicedatadlDL.InsertAndGetId(this);
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
				using(DeviceDataDL _devicedatadlDL = new DeviceDataDL())
				{
					return _devicedatadlDL.Update(this);
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
				using(DeviceDataDL _devicedatadlDL = new DeviceDataDL())
				{
					return _devicedatadlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
