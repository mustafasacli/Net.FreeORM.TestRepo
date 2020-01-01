using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class HarizmiFactors : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _HarizmiFactorName;
		public string HarizmiFactorName
		{
			set { _HarizmiFactorName = value; OnPropertyChanged("HarizmiFactorName"); }
			get { return _HarizmiFactorName; }
		}

		private char _PageDescriptor;
		public char PageDescriptor
		{
			set { _PageDescriptor = value; OnPropertyChanged("PageDescriptor"); }
			get { return _PageDescriptor; }
		}

		private byte _RiskFactorPoint;
		public byte RiskFactorPoint
		{
			set { _RiskFactorPoint = value; OnPropertyChanged("RiskFactorPoint"); }
			get { return _RiskFactorPoint; }
		}

		private byte _IsActive;
		public byte IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "HarizmiFactors";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(HarizmiFactorsDL _harizmifactorsdlDL = new HarizmiFactorsDL())
				{
					return _harizmifactorsdlDL.Insert(this);
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
				using(HarizmiFactorsDL _harizmifactorsdlDL = new HarizmiFactorsDL())
				{
					return _harizmifactorsdlDL.InsertAndGetId(this);
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
				using(HarizmiFactorsDL _harizmifactorsdlDL = new HarizmiFactorsDL())
				{
					return _harizmifactorsdlDL.Update(this);
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
				using(HarizmiFactorsDL _harizmifactorsdlDL = new HarizmiFactorsDL())
				{
					return _harizmifactorsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
