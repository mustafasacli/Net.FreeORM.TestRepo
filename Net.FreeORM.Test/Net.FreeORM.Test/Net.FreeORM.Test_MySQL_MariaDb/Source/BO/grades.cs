using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_MySQL_MariaDb.Source.DL;

namespace Net.FreeORM.Test_MySQL_MariaDb.Source.BO
{
    public class grades : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _GradeName;
        public string GradeName
        {
            set { _GradeName = value; OnPropertyChanged("GradeName"); }
            get { return _GradeName; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "grades";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (gradesDL _gradesdlDL = new gradesDL())
                {
                    return _gradesdlDL.Insert(this);
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
                using (gradesDL _gradesdlDL = new gradesDL())
                {
                    return _gradesdlDL.InsertAndGetId(this);
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
                using (gradesDL _gradesdlDL = new gradesDL())
                {
                    return _gradesdlDL.Update(this);
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
                using (gradesDL _gradesdlDL = new gradesDL())
                {
                    return _gradesdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
