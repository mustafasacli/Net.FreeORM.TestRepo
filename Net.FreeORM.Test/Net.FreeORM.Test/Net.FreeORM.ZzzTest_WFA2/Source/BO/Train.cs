using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class Train : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TrainName;
		public string TrainName
		{
			set { _TrainName = value; OnPropertyChanged("TrainName"); }
			get { return _TrainName; }
		}

		private string _Definiton;
		public string Definiton
		{
			set { _Definiton = value; OnPropertyChanged("Definiton"); }
			get { return _Definiton; }
		}

		private int _Vendor;
		public int Vendor
		{
			set { _Vendor = value; OnPropertyChanged("Vendor"); }
			get { return _Vendor; }
		}

		public override string GetTableName()
		{
			return "Train";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(TrainDL _traindlDL = new TrainDL())
				{
					return _traindlDL.Insert(this);
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
				using(TrainDL _traindlDL = new TrainDL())
				{
					return _traindlDL.InsertAndGetId(this);
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
				using(TrainDL _traindlDL = new TrainDL())
				{
					return _traindlDL.Update(this);
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
				using(TrainDL _traindlDL = new TrainDL())
				{
					return _traindlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
