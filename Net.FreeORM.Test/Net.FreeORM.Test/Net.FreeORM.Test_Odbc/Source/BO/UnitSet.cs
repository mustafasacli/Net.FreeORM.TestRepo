using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class UnitSet : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _UnitId;
		public int UnitId
		{
			set { _UnitId = value; OnPropertyChanged("UnitId"); }
			get { return _UnitId; }
		}

		private int _SetId;
		public int SetId
		{
			set { _SetId = value; OnPropertyChanged("SetId"); }
			get { return _SetId; }
		}

		private int _UnitType;
		public int UnitType
		{
			set { _UnitType = value; OnPropertyChanged("UnitType"); }
			get { return _UnitType; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "UnitSet";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(UnitSetDL _unitsetdlDL = new UnitSetDL())
				{
					return _unitsetdlDL.Insert(this);
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
				using(UnitSetDL _unitsetdlDL = new UnitSetDL())
				{
					return _unitsetdlDL.InsertAndGetId(this);
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
				using(UnitSetDL _unitsetdlDL = new UnitSetDL())
				{
					return _unitsetdlDL.Update(this);
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
				using(UnitSetDL _unitsetdlDL = new UnitSetDL())
				{
					return _unitsetdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
