using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormItakiHeaderDetails : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _MasterFormId;
		public int MasterFormId
		{
			set { _MasterFormId = value; OnPropertyChanged("MasterFormId"); }
			get { return _MasterFormId; }
		}

		private int _RowCreatedBy;
		public int RowCreatedBy
		{
			set { _RowCreatedBy = value; OnPropertyChanged("RowCreatedBy"); }
			get { return _RowCreatedBy; }
		}

		private DateTime _RowCreationDate;
		public DateTime RowCreationDate
		{
			set { _RowCreationDate = value; OnPropertyChanged("RowCreationDate"); }
			get { return _RowCreationDate; }
		}

		private DateTime _DepartmentChangeDate;
		public DateTime DepartmentChangeDate
		{
			set { _DepartmentChangeDate = value; OnPropertyChanged("DepartmentChangeDate"); }
			get { return _DepartmentChangeDate; }
		}

		private DateTime _PatientFallDate;
		public DateTime PatientFallDate
		{
			set { _PatientFallDate = value; OnPropertyChanged("PatientFallDate"); }
			get { return _PatientFallDate; }
		}

		private DateTime _PostOperationalPeriodDate;
		public DateTime PostOperationalPeriodDate
		{
			set { _PostOperationalPeriodDate = value; OnPropertyChanged("PostOperationalPeriodDate"); }
			get { return _PostOperationalPeriodDate; }
		}

		private DateTime _StateChangeDate;
		public DateTime StateChangeDate
		{
			set { _StateChangeDate = value; OnPropertyChanged("StateChangeDate"); }
			get { return _StateChangeDate; }
		}

		public override string GetTableName()
		{
			return "FormItakiHeaderDetails";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormItakiHeaderDetailsDL _formıtakiheaderdetailsdlDL = new FormItakiHeaderDetailsDL())
				{
					return _formıtakiheaderdetailsdlDL.Insert(this);
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
				using(FormItakiHeaderDetailsDL _formıtakiheaderdetailsdlDL = new FormItakiHeaderDetailsDL())
				{
					return _formıtakiheaderdetailsdlDL.InsertAndGetId(this);
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
				using(FormItakiHeaderDetailsDL _formıtakiheaderdetailsdlDL = new FormItakiHeaderDetailsDL())
				{
					return _formıtakiheaderdetailsdlDL.Update(this);
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
				using(FormItakiHeaderDetailsDL _formıtakiheaderdetailsdlDL = new FormItakiHeaderDetailsDL())
				{
					return _formıtakiheaderdetailsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
