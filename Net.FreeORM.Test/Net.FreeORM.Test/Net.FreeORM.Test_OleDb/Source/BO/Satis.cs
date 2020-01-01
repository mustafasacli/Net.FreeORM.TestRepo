using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class Satis : BaseBO
    {
        private int _Adet;
        public int Adet
        {
            set { _Adet = value; OnPropertyChanged("Adet"); }
            get { return _Adet; }
        }

        private int _Fiyat;
        public int Fiyat
        {
            set { _Fiyat = value; OnPropertyChanged("Fiyat"); }
            get { return _Fiyat; }
        }

        private int _UrunID;
        public int UrunID
        {
            set { _UrunID = value; OnPropertyChanged("UrunID"); }
            get { return _UrunID; }
        }

        public override string GetTableName()
        {
            return "Satis";
        }

        public override string GetIdColumn()
        {
            return "UrunID";
        }

        internal int Insert()
        {
            try
            {
                using (SatisDL _satisdlDL = new SatisDL())
                {
                    return _satisdlDL.Insert(this);
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
                using (SatisDL _satisdlDL = new SatisDL())
                {
                    return _satisdlDL.InsertAndGetId(this);
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
                using (SatisDL _satisdlDL = new SatisDL())
                {
                    return _satisdlDL.Update(this);
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
                using (SatisDL _satisdlDL = new SatisDL())
                {
                    return _satisdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
