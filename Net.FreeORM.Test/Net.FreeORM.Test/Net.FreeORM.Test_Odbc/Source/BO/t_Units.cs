using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_Units : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _UnitName;
		public string UnitName
		{
			set { _UnitName = value; OnPropertyChanged("UnitName"); }
			get { return _UnitName; }
		}

		private float _Multiplier;
		public float Multiplier
		{
			set { _Multiplier = value; OnPropertyChanged("Multiplier"); }
			get { return _Multiplier; }
		}

		private float _Addition;
		public float Addition
		{
			set { _Addition = value; OnPropertyChanged("Addition"); }
			get { return _Addition; }
		}

		private Int16 _IsBaseUnit;
		public Int16 IsBaseUnit
		{
			set { _IsBaseUnit = value; OnPropertyChanged("IsBaseUnit"); }
			get { return _IsBaseUnit; }
		}

		private Int16 _PerInKg;
		public Int16 PerInKg
		{
			set { _PerInKg = value; OnPropertyChanged("PerInKg"); }
			get { return _PerInKg; }
		}

		private int _ParentUnitId;
		public int ParentUnitId
		{
			set { _ParentUnitId = value; OnPropertyChanged("ParentUnitId"); }
			get { return _ParentUnitId; }
		}

		private int _UnitGroupId;
		public int UnitGroupId
		{
			set { _UnitGroupId = value; OnPropertyChanged("UnitGroupId"); }
			get { return _UnitGroupId; }
		}

		private int _IsActive;
		public int IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "t_Units";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_UnitsDL _t_unitsdlDL = new t_UnitsDL())
				{
					return _t_unitsdlDL.Insert(this);
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
				using(t_UnitsDL _t_unitsdlDL = new t_UnitsDL())
				{
					return _t_unitsdlDL.InsertAndGetId(this);
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
				using(t_UnitsDL _t_unitsdlDL = new t_UnitsDL())
				{
					return _t_unitsdlDL.Update(this);
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
				using(t_UnitsDL _t_unitsdlDL = new t_UnitsDL())
				{
					return _t_unitsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
