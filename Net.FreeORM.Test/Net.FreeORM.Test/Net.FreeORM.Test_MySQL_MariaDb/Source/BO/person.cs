using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_MySQL_MariaDb.Source.DL;

namespace Net.FreeORM.Test_MySQL_MariaDb.Source.BO
{
    public class person : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _FirstName;
        public string FirstName
        {
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
            get { return _FirstName; }
        }

        private string _LastName;
        public string LastName
        {
            set { _LastName = value; OnPropertyChanged("LastName"); }
            get { return _LastName; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "person";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
