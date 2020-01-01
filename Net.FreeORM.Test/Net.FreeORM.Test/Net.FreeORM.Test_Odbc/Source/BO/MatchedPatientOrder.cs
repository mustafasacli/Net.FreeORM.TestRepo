using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class MatchedPatientOrder : BaseBO
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

		private int _OrderId;
		public int OrderId
		{
			set { _OrderId = value; OnPropertyChanged("OrderId"); }
			get { return _OrderId; }
		}

		private string _ParameterString;
		public string ParameterString
		{
			set { _ParameterString = value; OnPropertyChanged("ParameterString"); }
			get { return _ParameterString; }
		}

		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{
			set { _CreatedDate = value; OnPropertyChanged("CreatedDate"); }
			get { return _CreatedDate; }
		}

		public override string GetTableName()
		{
			return "MatchedPatientOrder";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(MatchedPatientOrderDL _matchedpatientorderdlDL = new MatchedPatientOrderDL())
				{
					return _matchedpatientorderdlDL.Insert(this);
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
				using(MatchedPatientOrderDL _matchedpatientorderdlDL = new MatchedPatientOrderDL())
				{
					return _matchedpatientorderdlDL.InsertAndGetId(this);
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
				using(MatchedPatientOrderDL _matchedpatientorderdlDL = new MatchedPatientOrderDL())
				{
					return _matchedpatientorderdlDL.Update(this);
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
				using(MatchedPatientOrderDL _matchedpatientorderdlDL = new MatchedPatientOrderDL())
				{
					return _matchedpatientorderdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
