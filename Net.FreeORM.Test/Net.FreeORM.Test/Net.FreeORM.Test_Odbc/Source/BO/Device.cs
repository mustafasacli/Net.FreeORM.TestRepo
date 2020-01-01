using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Device : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _DeviceId;
		public int DeviceId
		{
			set { _DeviceId = value; OnPropertyChanged("DeviceId"); }
			get { return _DeviceId; }
		}

		private string _DeviceName;
		public string DeviceName
		{
			set { _DeviceName = value; OnPropertyChanged("DeviceName"); }
			get { return _DeviceName; }
		}

		private string _DeviceType;
		public string DeviceType
		{
			set { _DeviceType = value; OnPropertyChanged("DeviceType"); }
			get { return _DeviceType; }
		}

		private string _Vendor;
		public string Vendor
		{
			set { _Vendor = value; OnPropertyChanged("Vendor"); }
			get { return _Vendor; }
		}

		private string _DllName;
		public string DllName
		{
			set { _DllName = value; OnPropertyChanged("DllName"); }
			get { return _DllName; }
		}

		private string _DllVersion;
		public string DllVersion
		{
			set { _DllVersion = value; OnPropertyChanged("DllVersion"); }
			get { return _DllVersion; }
		}

		private string _Wrapper;
		public string Wrapper
		{
			set { _Wrapper = value; OnPropertyChanged("Wrapper"); }
			get { return _Wrapper; }
		}

		public override string GetTableName()
		{
			return "Device";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(DeviceDL _devicedlDL = new DeviceDL())
				{
					return _devicedlDL.Insert(this);
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
				using(DeviceDL _devicedlDL = new DeviceDL())
				{
					return _devicedlDL.InsertAndGetId(this);
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
				using(DeviceDL _devicedlDL = new DeviceDL())
				{
					return _devicedlDL.Update(this);
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
				using(DeviceDL _devicedlDL = new DeviceDL())
				{
					return _devicedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
