using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_BloodGroups : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _BloodGroupName;
		public string BloodGroupName
		{
			set { _BloodGroupName = value; OnPropertyChanged("BloodGroupName"); }
			get { return _BloodGroupName; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_BloodGroups";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_BloodGroupsDL _t_bloodgroupsdlDL = new t_BloodGroupsDL())
				{
					return _t_bloodgroupsdlDL.Insert(this);
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
				using(t_BloodGroupsDL _t_bloodgroupsdlDL = new t_BloodGroupsDL())
				{
					return _t_bloodgroupsdlDL.InsertAndGetId(this);
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
				using(t_BloodGroupsDL _t_bloodgroupsdlDL = new t_BloodGroupsDL())
				{
					return _t_bloodgroupsdlDL.Update(this);
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
				using(t_BloodGroupsDL _t_bloodgroupsdlDL = new t_BloodGroupsDL())
				{
					return _t_bloodgroupsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
