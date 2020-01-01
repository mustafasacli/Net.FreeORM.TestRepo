using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class GCSParameters : BaseBO
	{
		private string _OBJID;
		public string OBJID
		{
			set { _OBJID = value; OnPropertyChanged("OBJID"); }
			get { return _OBJID; }
		}

		private string _ParameterName;
		public string ParameterName
		{
			set { _ParameterName = value; OnPropertyChanged("ParameterName"); }
			get { return _ParameterName; }
		}

		private string _ParameterNameTr;
		public string ParameterNameTr
		{
			set { _ParameterNameTr = value; OnPropertyChanged("ParameterNameTr"); }
			get { return _ParameterNameTr; }
		}

		private string _ParameterAbbr;
		public string ParameterAbbr
		{
			set { _ParameterAbbr = value; OnPropertyChanged("ParameterAbbr"); }
			get { return _ParameterAbbr; }
		}

		private int _ScoreTypeId;
		public int ScoreTypeId
		{
			set { _ScoreTypeId = value; OnPropertyChanged("ScoreTypeId"); }
			get { return _ScoreTypeId; }
		}

		private int _GCSGroup;
		public int GCSGroup
		{
			set { _GCSGroup = value; OnPropertyChanged("GCSGroup"); }
			get { return _GCSGroup; }
		}

		private int _Pediatric;
		public int Pediatric
		{
			set { _Pediatric = value; OnPropertyChanged("Pediatric"); }
			get { return _Pediatric; }
		}

		public override string GetTableName()
		{
			return "GCSParameters";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(GCSParametersDL _gcsparametersdlDL = new GCSParametersDL())
				{
					return _gcsparametersdlDL.Insert(this);
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
				using(GCSParametersDL _gcsparametersdlDL = new GCSParametersDL())
				{
					return _gcsparametersdlDL.InsertAndGetId(this);
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
				using(GCSParametersDL _gcsparametersdlDL = new GCSParametersDL())
				{
					return _gcsparametersdlDL.Update(this);
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
				using(GCSParametersDL _gcsparametersdlDL = new GCSParametersDL())
				{
					return _gcsparametersdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
