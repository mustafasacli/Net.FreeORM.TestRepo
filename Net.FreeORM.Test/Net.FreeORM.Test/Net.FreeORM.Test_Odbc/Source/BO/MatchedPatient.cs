using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class MatchedPatient : BaseBO
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

		private DateTime _MatchedDate;
		public DateTime MatchedDate
		{
			set { _MatchedDate = value; OnPropertyChanged("MatchedDate"); }
			get { return _MatchedDate; }
		}

		private string _MatchedType;
		public string MatchedType
		{
			set { _MatchedType = value; OnPropertyChanged("MatchedType"); }
			get { return _MatchedType; }
		}

		private int _DescriptionId;
		public int DescriptionId
		{
			set { _DescriptionId = value; OnPropertyChanged("DescriptionId"); }
			get { return _DescriptionId; }
		}

		private int _InPatientId;
		public int InPatientId
		{
			set { _InPatientId = value; OnPropertyChanged("InPatientId"); }
			get { return _InPatientId; }
		}

		public override string GetTableName()
		{
			return "MatchedPatient";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(MatchedPatientDL _matchedpatientdlDL = new MatchedPatientDL())
				{
					return _matchedpatientdlDL.Insert(this);
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
				using(MatchedPatientDL _matchedpatientdlDL = new MatchedPatientDL())
				{
					return _matchedpatientdlDL.InsertAndGetId(this);
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
				using(MatchedPatientDL _matchedpatientdlDL = new MatchedPatientDL())
				{
					return _matchedpatientdlDL.Update(this);
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
				using(MatchedPatientDL _matchedpatientdlDL = new MatchedPatientDL())
				{
					return _matchedpatientdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
