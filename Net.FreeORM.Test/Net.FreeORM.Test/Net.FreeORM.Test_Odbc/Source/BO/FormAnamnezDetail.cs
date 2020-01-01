using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormAnamnezDetail : BaseBO
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

		private string _AnamnezDetailInfo;
		public string AnamnezDetailInfo
		{
			set { _AnamnezDetailInfo = value; OnPropertyChanged("AnamnezDetailInfo"); }
			get { return _AnamnezDetailInfo; }
		}

		public override string GetTableName()
		{
			return "FormAnamnezDetail";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormAnamnezDetailDL _formanamnezdetaildlDL = new FormAnamnezDetailDL())
				{
					return _formanamnezdetaildlDL.Insert(this);
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
				using(FormAnamnezDetailDL _formanamnezdetaildlDL = new FormAnamnezDetailDL())
				{
					return _formanamnezdetaildlDL.InsertAndGetId(this);
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
				using(FormAnamnezDetailDL _formanamnezdetaildlDL = new FormAnamnezDetailDL())
				{
					return _formanamnezdetaildlDL.Update(this);
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
				using(FormAnamnezDetailDL _formanamnezdetaildlDL = new FormAnamnezDetailDL())
				{
					return _formanamnezdetaildlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
