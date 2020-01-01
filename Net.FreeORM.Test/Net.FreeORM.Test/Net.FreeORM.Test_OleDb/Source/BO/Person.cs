using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class Person : BaseBO
    {
        private string _FIRST_NAME;
        public string FIRST_NAME
        {
            set { _FIRST_NAME = value; OnPropertyChanged("FIRST_NAME"); }
            get { return _FIRST_NAME; }
        }

        private bool _IS_ACTIVE;
        public bool IS_ACTIVE
        {
            set { _IS_ACTIVE = value; OnPropertyChanged("IS_ACTIVE"); }
            get { return _IS_ACTIVE; }
        }

        private string _LAST_NAME;
        public string LAST_NAME
        {
            set { _LAST_NAME = value; OnPropertyChanged("LAST_NAME"); }
            get { return _LAST_NAME; }
        }

        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        public override string GetTableName()
        {
            return "Person";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Insert(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.InsertAndGetId(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Update(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
