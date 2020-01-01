using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
	public class t_GridParams : BaseBO
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

		private int _Displayed;
		public int Displayed
		{
			set { _Displayed = value; OnPropertyChanged("Displayed"); }
			get { return _Displayed; }
		}

		private string _Tooltip;
		public string Tooltip
		{
			set { _Tooltip = value; OnPropertyChanged("Tooltip"); }
			get { return _Tooltip; }
		}

		public override string GetTableName()
		{
			return "t_GridParams";
		}

		public override string GetIdColumn()
		{
			return "OBJID";
		}

		internal int Insert()
		{
			try
			{
				using(t_GridParamsDL _t_gridparamsdlDL = new t_GridParamsDL())
				{
					return _t_gridparamsdlDL.Insert(this);
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
				using(t_GridParamsDL _t_gridparamsdlDL = new t_GridParamsDL())
				{
					return _t_gridparamsdlDL.InsertAndGetId(this);
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
				using(t_GridParamsDL _t_gridparamsdlDL = new t_GridParamsDL())
				{
					return _t_gridparamsdlDL.Update(this);
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
				using(t_GridParamsDL _t_gridparamsdlDL = new t_GridParamsDL())
				{
					return _t_gridparamsdlDL.Delete(this);
				}
			}
			catch
			{
				throw;
			}
		}

	}
}
