using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ItakiFactors : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ItakiFactorName;
		public string ItakiFactorName
		{
			set { _ItakiFactorName = value; OnPropertyChanged("ItakiFactorName"); }
			get { return _ItakiFactorName; }
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
			return "ItakiFactors";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ItakiFactorsDL _ıtakifactorsdlDL = new ItakiFactorsDL())
				{
					return _ıtakifactorsdlDL.Insert(this);
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
				using(ItakiFactorsDL _ıtakifactorsdlDL = new ItakiFactorsDL())
				{
					return _ıtakifactorsdlDL.InsertAndGetId(this);
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
				using(ItakiFactorsDL _ıtakifactorsdlDL = new ItakiFactorsDL())
				{
					return _ıtakifactorsdlDL.Update(this);
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
				using(ItakiFactorsDL _ıtakifactorsdlDL = new ItakiFactorsDL())
				{
					return _ıtakifactorsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
