using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class DeviceBedAssignment : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _BedId;
		public int BedId
		{
			set { _BedId = value; OnPropertyChanged("BedId"); }
			get { return _BedId; }
		}

		private int _DeviceId;
		public int DeviceId
		{
			set { _DeviceId = value; OnPropertyChanged("DeviceId"); }
			get { return _DeviceId; }
		}

		public override string GetTableName()
		{
			return "DeviceBedAssignment";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(DeviceBedAssignmentDL _devicebedassignmentdlDL = new DeviceBedAssignmentDL())
				{
					return _devicebedassignmentdlDL.Insert(this);
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
				using(DeviceBedAssignmentDL _devicebedassignmentdlDL = new DeviceBedAssignmentDL())
				{
					return _devicebedassignmentdlDL.InsertAndGetId(this);
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
				using(DeviceBedAssignmentDL _devicebedassignmentdlDL = new DeviceBedAssignmentDL())
				{
					return _devicebedassignmentdlDL.Update(this);
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
				using(DeviceBedAssignmentDL _devicebedassignmentdlDL = new DeviceBedAssignmentDL())
				{
					return _devicebedassignmentdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
