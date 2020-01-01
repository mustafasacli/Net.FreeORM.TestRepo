using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
    public class FiredDeviceParameterRule : BaseBO
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

        private int _EpisodeId;
        public int EpisodeId
        {
            set { _EpisodeId = value; OnPropertyChanged("EpisodeId"); }
            get { return _EpisodeId; }
        }

        private string _BedName;
        public string BedName
        {
            set { _BedName = value; OnPropertyChanged("BedName"); }
            get { return _BedName; }
        }

        private string _ParameterName;
        public string ParameterName
        {
            set { _ParameterName = value; OnPropertyChanged("ParameterName"); }
            get { return _ParameterName; }
        }

        private string _FiredRule;
        public string FiredRule
        {
            set { _FiredRule = value; OnPropertyChanged("FiredRule"); }
            get { return _FiredRule; }
        }

        private string _Value;
        public string Value
        {
            set { _Value = value; OnPropertyChanged("Value"); }
            get { return _Value; }
        }

        private DateTime _Date;
        public DateTime Date
        {
            set { _Date = value; OnPropertyChanged("Date"); }
            get { return _Date; }
        }

        public override string GetTableName()
        {
            return "FiredDeviceParameterRule";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (FiredDeviceParameterRuleDL _fireddeviceparameterruledlDL = new FiredDeviceParameterRuleDL())
                {
                    return _fireddeviceparameterruledlDL.Insert(this);
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
                using (FiredDeviceParameterRuleDL _fireddeviceparameterruledlDL = new FiredDeviceParameterRuleDL())
                {
                    return _fireddeviceparameterruledlDL.InsertAndGetId(this);
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
                using (FiredDeviceParameterRuleDL _fireddeviceparameterruledlDL = new FiredDeviceParameterRuleDL())
                {
                    return _fireddeviceparameterruledlDL.Update(this);
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
                using (FiredDeviceParameterRuleDL _fireddeviceparameterruledlDL = new FiredDeviceParameterRuleDL())
                {
                    return _fireddeviceparameterruledlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
