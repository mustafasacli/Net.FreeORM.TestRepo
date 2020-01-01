using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
	public class TrainClass : BaseBO
	{
		private int _OBJID;
		public int OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _TrainClassName;
		public string TrainClassName
		{
			set { _TrainClassName = value; OnPropertyChanged("TrainClassName"); }
			get { return _TrainClassName; }
		}

		private string _TrainClassCode;
		public string TrainClassCode
		{
			set { _TrainClassCode = value; OnPropertyChanged("TrainClassCode"); }
			get { return _TrainClassCode; }
		}

		public override string GetTableName()
		{
			return "TrainClass";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(TrainClassDL _trainclassdlDL = new TrainClassDL())
				{
					return _trainclassdlDL.Insert(this);
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
				using(TrainClassDL _trainclassdlDL = new TrainClassDL())
				{
					return _trainclassdlDL.InsertAndGetId(this);
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
				using(TrainClassDL _trainclassdlDL = new TrainClassDL())
				{
					return _trainclassdlDL.Update(this);
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
				using(TrainClassDL _trainclassdlDL = new TrainClassDL())
				{
					return _trainclassdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
