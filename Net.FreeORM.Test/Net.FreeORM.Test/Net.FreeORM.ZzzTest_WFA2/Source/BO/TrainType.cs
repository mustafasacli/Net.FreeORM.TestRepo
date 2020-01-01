using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class TrainType : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TrainTypeName;
		public string TrainTypeName
		{
			set { _TrainTypeName = value; OnPropertyChanged("TrainTypeName"); }
			get { return _TrainTypeName; }
		}

		public override string GetTableName()
		{
			return "TrainType";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(TrainTypeDL _traintypedlDL = new TrainTypeDL())
				{
					return _traintypedlDL.Insert(this);
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
				using(TrainTypeDL _traintypedlDL = new TrainTypeDL())
				{
					return _traintypedlDL.InsertAndGetId(this);
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
				using(TrainTypeDL _traintypedlDL = new TrainTypeDL())
				{
					return _traintypedlDL.Update(this);
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
				using(TrainTypeDL _traintypedlDL = new TrainTypeDL())
				{
					return _traintypedlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
