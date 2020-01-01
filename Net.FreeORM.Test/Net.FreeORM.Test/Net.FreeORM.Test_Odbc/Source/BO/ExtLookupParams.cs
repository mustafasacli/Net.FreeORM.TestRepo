using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_Odbc.Source.DL;

namespace Net.FreeORM.Test_Odbc.Source.BO
{
    public class ExtLookupParams : BaseBO
    {
        private string _OBJID;
        public string OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _Control;
        public string Control
        {
            set { _Control = value; OnPropertyChanged("Control"); }
            get { return _Control; }
        }

        private string _TableName;
        public string TableName
        {
            set { _TableName = value; OnPropertyChanged("TableName"); }
            get { return _TableName; }
        }

        private string _DisplayMember;
        public string DisplayMember
        {
            set { _DisplayMember = value; OnPropertyChanged("DisplayMember"); }
            get { return _DisplayMember; }
        }

        private string _ValueMember;
        public string ValueMember
        {
            set { _ValueMember = value; OnPropertyChanged("ValueMember"); }
            get { return _ValueMember; }
        }

        public override string GetTableName()
        {
            return "ExtLookupParams";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (ExtLookupParamsDL _extlookupparamsdlDL = new ExtLookupParamsDL())
                {
                    return _extlookupparamsdlDL.Insert(this);
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
                using (ExtLookupParamsDL _extlookupparamsdlDL = new ExtLookupParamsDL())
                {
                    return _extlookupparamsdlDL.InsertAndGetId(this);
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
                using (ExtLookupParamsDL _extlookupparamsdlDL = new ExtLookupParamsDL())
                {
                    return _extlookupparamsdlDL.Update(this);
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
                using (ExtLookupParamsDL _extlookupparamsdlDL = new ExtLookupParamsDL())
                {
                    return _extlookupparamsdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
