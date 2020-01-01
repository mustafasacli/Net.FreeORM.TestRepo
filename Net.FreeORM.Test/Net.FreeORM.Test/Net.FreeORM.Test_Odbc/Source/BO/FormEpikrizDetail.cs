using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormEpikrizDetail : BaseBO
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

		private int _RowUpdatedBy;
		public int RowUpdatedBy
		{
			set { _RowUpdatedBy = value; OnPropertyChanged("RowUpdatedBy"); }
			get { return _RowUpdatedBy; }
		}

		private DateTime _RowUpdateTime;
		public DateTime RowUpdateTime
		{
			set { _RowUpdateTime = value; OnPropertyChanged("RowUpdateTime"); }
			get { return _RowUpdateTime; }
		}

		private string _LastVitalSigns;
		public string LastVitalSigns
		{
			set { _LastVitalSigns = value; OnPropertyChanged("LastVitalSigns"); }
			get { return _LastVitalSigns; }
		}

		private string _Serums;
		public string Serums
		{
			set { _Serums = value; OnPropertyChanged("Serums"); }
			get { return _Serums; }
		}

		private string _Perfusions;
		public string Perfusions
		{
			set { _Perfusions = value; OnPropertyChanged("Perfusions"); }
			get { return _Perfusions; }
		}

		private string _LastUsedDrugs;
		public string LastUsedDrugs
		{
			set { _LastUsedDrugs = value; OnPropertyChanged("LastUsedDrugs"); }
			get { return _LastUsedDrugs; }
		}

		private string _UnResultedExaminations;
		public string UnResultedExaminations
		{
			set { _UnResultedExaminations = value; OnPropertyChanged("UnResultedExaminations"); }
			get { return _UnResultedExaminations; }
		}

		private string _BloodAndBloodProducts;
		public string BloodAndBloodProducts
		{
			set { _BloodAndBloodProducts = value; OnPropertyChanged("BloodAndBloodProducts"); }
			get { return _BloodAndBloodProducts; }
		}

		private string _OtherNotes;
		public string OtherNotes
		{
			set { _OtherNotes = value; OnPropertyChanged("OtherNotes"); }
			get { return _OtherNotes; }
		}

		public override string GetTableName()
		{
			return "FormEpikrizDetail";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormEpikrizDetailDL _formepikrizdetaildlDL = new FormEpikrizDetailDL())
				{
					return _formepikrizdetaildlDL.Insert(this);
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
				using(FormEpikrizDetailDL _formepikrizdetaildlDL = new FormEpikrizDetailDL())
				{
					return _formepikrizdetaildlDL.InsertAndGetId(this);
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
				using(FormEpikrizDetailDL _formepikrizdetaildlDL = new FormEpikrizDetailDL())
				{
					return _formepikrizdetaildlDL.Update(this);
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
				using(FormEpikrizDetailDL _formepikrizdetaildlDL = new FormEpikrizDetailDL())
				{
					return _formepikrizdetaildlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
