using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class Urunler : BaseBO
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

        private int _ID;
        public int ID
        {
            set { _ID = value; OnPropertyChanged("ID"); }
            get { return _ID; }
        }

        private string _UrunAdi;
        public string UrunAdi
        {
            set { _UrunAdi = value; OnPropertyChanged("UrunAdi"); }
            get { return _UrunAdi; }
        }

        public override string GetTableName()
        {
            return "Urunler";
        }

        public override string GetIdColumn()
        {
            return "ID";
        }

        internal int Insert()
        {
            try
            {
                using (UrunlerDL _urunlerdlDL = new UrunlerDL())
                {
                    return _urunlerdlDL.Insert(this);
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
                using (UrunlerDL _urunlerdlDL = new UrunlerDL())
                {
                    return _urunlerdlDL.InsertAndGetId(this);
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
                using (UrunlerDL _urunlerdlDL = new UrunlerDL())
                {
                    return _urunlerdlDL.Update(this);
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
                using (UrunlerDL _urunlerdlDL = new UrunlerDL())
                {
                    return _urunlerdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
