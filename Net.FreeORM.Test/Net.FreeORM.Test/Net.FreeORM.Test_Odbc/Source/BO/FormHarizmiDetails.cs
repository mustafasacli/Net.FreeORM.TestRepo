using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormHarizmiDetails : BaseBO
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

		private DateTime _FactorDate;
		public DateTime FactorDate
		{
			set { _FactorDate = value; OnPropertyChanged("FactorDate"); }
			get { return _FactorDate; }
		}

		private int _FactorId;
		public int FactorId
		{
			set { _FactorId = value; OnPropertyChanged("FactorId"); }
			get { return _FactorId; }
		}

		private byte _FactorAnswer;
		public byte FactorAnswer
		{
			set { _FactorAnswer = value; OnPropertyChanged("FactorAnswer"); }
			get { return _FactorAnswer; }
		}

		public override string GetTableName()
		{
			return "FormHarizmiDetails";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormHarizmiDetailsDL _formharizmidetailsdlDL = new FormHarizmiDetailsDL())
				{
					return _formharizmidetailsdlDL.Insert(this);
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
				using(FormHarizmiDetailsDL _formharizmidetailsdlDL = new FormHarizmiDetailsDL())
				{
					return _formharizmidetailsdlDL.InsertAndGetId(this);
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
				using(FormHarizmiDetailsDL _formharizmidetailsdlDL = new FormHarizmiDetailsDL())
				{
					return _formharizmidetailsdlDL.Update(this);
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
				using(FormHarizmiDetailsDL _formharizmidetailsdlDL = new FormHarizmiDetailsDL())
				{
					return _formharizmidetailsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
