using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class Personel : BaseBO
    {
        private string _Ad;
        public string Ad
        {
            set { _Ad = value; OnPropertyChanged("Ad"); }
            get { return _Ad; }
        }

        private Int16 _Cinsiyet;
        public Int16 Cinsiyet
        {
            set { _Cinsiyet = value; OnPropertyChanged("Cinsiyet"); }
            get { return _Cinsiyet; }
        }

        private DateTime _DTarihi;
        public DateTime DTarihi
        {
            set { _DTarihi = value; OnPropertyChanged("DTarihi"); }
            get { return _DTarihi; }
        }

        private int _ID;
        public int ID
        {
            set { _ID = value; OnPropertyChanged("ID"); }
            get { return _ID; }
        }

        private int _Maas;
        public int Maas
        {
            set { _Maas = value; OnPropertyChanged("Maas"); }
            get { return _Maas; }
        }

        private string _Soyad;
        public string Soyad
        {
            set { _Soyad = value; OnPropertyChanged("Soyad"); }
            get { return _Soyad; }
        }

        private string _TCNO;
        public string TCNO
        {
            set { _TCNO = value; OnPropertyChanged("TCNO"); }
            get { return _TCNO; }
        }

        public override string GetTableName()
        {
            return "Personel";
        }

        public override string GetIdColumn()
        {
            return "ID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonelDL _personeldlDL = new PersonelDL())
                {
                    return _personeldlDL.Insert(this);
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
                using (PersonelDL _personeldlDL = new PersonelDL())
                {
                    return _personeldlDL.InsertAndGetId(this);
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
                using (PersonelDL _personeldlDL = new PersonelDL())
                {
                    return _personeldlDL.Update(this);
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
                using (PersonelDL _personeldlDL = new PersonelDL())
                {
                    return _personeldlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
