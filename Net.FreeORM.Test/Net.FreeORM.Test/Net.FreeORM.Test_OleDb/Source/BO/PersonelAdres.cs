using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class PersonelAdres : BaseBO
    {
        private string _Adres;
        public string Adres
        {
            set { _Adres = value; OnPropertyChanged("Adres"); }
            get { return _Adres; }
        }

        private int _ID;
        public int ID
        {
            set { _ID = value; OnPropertyChanged("ID"); }
            get { return _ID; }
        }

        private string _Ilce;
        public string Ilce
        {
            set { _Ilce = value; OnPropertyChanged("Ilce"); }
            get { return _Ilce; }
        }

        private int _PersonelID;
        public int PersonelID
        {
            set { _PersonelID = value; OnPropertyChanged("PersonelID"); }
            get { return _PersonelID; }
        }

        private string _Sehir;
        public string Sehir
        {
            set { _Sehir = value; OnPropertyChanged("Sehir"); }
            get { return _Sehir; }
        }

        public override string GetTableName()
        {
            return "PersonelAdres";
        }

        public override string GetIdColumn()
        {
            return "ID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonelAdresDL _personeladresdlDL = new PersonelAdresDL())
                {
                    return _personeladresdlDL.Insert(this);
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
                using (PersonelAdresDL _personeladresdlDL = new PersonelAdresDL())
                {
                    return _personeladresdlDL.InsertAndGetId(this);
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
                using (PersonelAdresDL _personeladresdlDL = new PersonelAdresDL())
                {
                    return _personeladresdlDL.Update(this);
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
                using (PersonelAdresDL _personeladresdlDL = new PersonelAdresDL())
                {
                    return _personeladresdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
