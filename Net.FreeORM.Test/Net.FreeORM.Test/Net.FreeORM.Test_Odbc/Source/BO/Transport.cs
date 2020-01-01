using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Transport : BaseBO
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

		private int _SNurseId;
		public int SNurseId
		{
			set { _SNurseId = value; OnPropertyChanged("SNurseId"); }
			get { return _SNurseId; }
		}

		private DateTime _EndTime;
		public DateTime EndTime
		{
			set { _EndTime = value; OnPropertyChanged("EndTime"); }
			get { return _EndTime; }
		}

		private int _RNurseId;
		public int RNurseId
		{
			set { _RNurseId = value; OnPropertyChanged("RNurseId"); }
			get { return _RNurseId; }
		}

		private int _FromBed;
		public int FromBed
		{
			set { _FromBed = value; OnPropertyChanged("FromBed"); }
			get { return _FromBed; }
		}

		private int _ToBed;
		public int ToBed
		{
			set { _ToBed = value; OnPropertyChanged("ToBed"); }
			get { return _ToBed; }
		}

		private DateTime _UpdateTime;
		public DateTime UpdateTime
		{
			set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
			get { return _UpdateTime; }
		}

		private int _EpisodeId;
		public int EpisodeId
		{
			set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
			get { return _EpisodeId; }
		}

		public override string GetTableName()
		{
			return "Transport";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(TransportDL _transportdlDL = new TransportDL())
				{
					return _transportdlDL.Insert(this);
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
				using(TransportDL _transportdlDL = new TransportDL())
				{
					return _transportdlDL.InsertAndGetId(this);
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
				using(TransportDL _transportdlDL = new TransportDL())
				{
					return _transportdlDL.Update(this);
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
				using(TransportDL _transportdlDL = new TransportDL())
				{
					return _transportdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
