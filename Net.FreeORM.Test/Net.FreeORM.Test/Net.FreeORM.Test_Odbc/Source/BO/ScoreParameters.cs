using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class ScoreParameters : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private int _ScoreTypeId;
		public int ScoreTypeId
		{
			set { _ScoreTypeId = value; OnPropertyChanged("ScoreTypeId"); }
			get { return _ScoreTypeId; }
		}

		private string _ParameterName;
		public string ParameterName
		{
			set { _ParameterName = value; OnPropertyChanged("ParameterName"); }
			get { return _ParameterName; }
		}

		private string _ParameterAbbr;
		public string ParameterAbbr
		{
			set { _ParameterAbbr = value; OnPropertyChanged("ParameterAbbr"); }
			get { return _ParameterAbbr; }
		}

		private int _ParameterUnit;
		public int ParameterUnit
		{
			set { _ParameterUnit = value; OnPropertyChanged("ParameterUnit"); }
			get { return _ParameterUnit; }
		}

		private string _ParameterNameTr;
		public string ParameterNameTr
		{
			set { _ParameterNameTr = value; OnPropertyChanged("ParameterNameTr"); }
			get { return _ParameterNameTr; }
		}

		public override string GetTableName()
		{
			return "ScoreParameters";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(ScoreParametersDL _scoreparametersdlDL = new ScoreParametersDL())
				{
					return _scoreparametersdlDL.Insert(this);
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
				using(ScoreParametersDL _scoreparametersdlDL = new ScoreParametersDL())
				{
					return _scoreparametersdlDL.InsertAndGetId(this);
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
				using(ScoreParametersDL _scoreparametersdlDL = new ScoreParametersDL())
				{
					return _scoreparametersdlDL.Update(this);
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
				using(ScoreParametersDL _scoreparametersdlDL = new ScoreParametersDL())
				{
					return _scoreparametersdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
