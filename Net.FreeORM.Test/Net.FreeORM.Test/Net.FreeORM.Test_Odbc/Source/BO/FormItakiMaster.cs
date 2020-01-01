using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class FormItakiMaster : BaseBO
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

		private int _FormCreatedBy;
		public int FormCreatedBy
		{
			set { _FormCreatedBy = value; OnPropertyChanged("FormCreatedBy"); }
			get { return _FormCreatedBy; }
		}

		private DateTime _FormCreatedDate;
		public DateTime FormCreatedDate
		{
			set { _FormCreatedDate = value; OnPropertyChanged("FormCreatedDate"); }
			get { return _FormCreatedDate; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "FormItakiMaster";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(FormItakiMasterDL _formıtakimasterdlDL = new FormItakiMasterDL())
				{
					return _formıtakimasterdlDL.Insert(this);
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
				using(FormItakiMasterDL _formıtakimasterdlDL = new FormItakiMasterDL())
				{
					return _formıtakimasterdlDL.InsertAndGetId(this);
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
				using(FormItakiMasterDL _formıtakimasterdlDL = new FormItakiMasterDL())
				{
					return _formıtakimasterdlDL.Update(this);
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
				using(FormItakiMasterDL _formıtakimasterdlDL = new FormItakiMasterDL())
				{
					return _formıtakimasterdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
