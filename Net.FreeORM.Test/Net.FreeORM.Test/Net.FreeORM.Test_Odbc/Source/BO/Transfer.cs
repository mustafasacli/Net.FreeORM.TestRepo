using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class Transfer : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _TransportId;
		public int TransportId
		{
			set { _TransportId = value; OnPropertyChanged("TransportId"); }
			get { return _TransportId; }
		}

		private int _DestinationId;
		public int DestinationId
		{
			set { _DestinationId = value; OnPropertyChanged("DestinationId"); }
			get { return _DestinationId; }
		}

		private DateTime _TransportTime;
		public DateTime TransportTime
		{
			set { _TransportTime = value; OnPropertyChanged("TransportTime"); }
			get { return _TransportTime; }
		}

		private int _EstimateTime;
		public int EstimateTime
		{
			set { _EstimateTime = value; OnPropertyChanged("EstimateTime"); }
			get { return _EstimateTime; }
		}

		public override string GetTableName()
		{
			return "Transfer";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(TransferDL _transferdlDL = new TransferDL())
				{
					return _transferdlDL.Insert(this);
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
				using(TransferDL _transferdlDL = new TransferDL())
				{
					return _transferdlDL.InsertAndGetId(this);
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
				using(TransferDL _transferdlDL = new TransferDL())
				{
					return _transferdlDL.Update(this);
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
				using(TransferDL _transferdlDL = new TransferDL())
				{
					return _transferdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
