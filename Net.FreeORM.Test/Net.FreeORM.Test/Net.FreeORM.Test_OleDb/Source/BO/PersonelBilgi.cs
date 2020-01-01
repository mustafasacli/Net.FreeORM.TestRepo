using Net.FreeORM.Framework.Base;
using System;
using Net.FreeORM.Test_OleDb.Source.DL;

namespace Net.FreeORM.Test_OleDb.Source.BO
{
    public class PersonelBilgi : BaseBO
    {
        private int _CocukSayisi;
        public int CocukSayisi
        {
            set { _CocukSayisi = value; OnPropertyChanged("CocukSayisi"); }
            get { return _CocukSayisi; }
        }

        private string _EMail;
        public string EMail
        {
            set { _EMail = value; OnPropertyChanged("EMail"); }
            get { return _EMail; }
        }

        private int _ID;
        public int ID
        {
            set { _ID = value; OnPropertyChanged("ID"); }
            get { return _ID; }
        }

        private Int16 _MedeniDurum;
        public Int16 MedeniDurum
        {
            set { _MedeniDurum = value; OnPropertyChanged("MedeniDurum"); }
            get { return _MedeniDurum; }
        }

        private int _PersonelID;
        public int PersonelID
        {
            set { _PersonelID = value; OnPropertyChanged("PersonelID"); }
            get { return _PersonelID; }
        }

        public override string GetTableName()
        {
            return "PersonelBilgi";
        }

        public override string GetIdColumn()
        {
            return "ID";
        }

        internal int Insert()
        {
            try
            {
                using (PersonelBilgiDL _personelbilgidlDL = new PersonelBilgiDL())
                {
                    return _personelbilgidlDL.Insert(this);
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
                using (PersonelBilgiDL _personelbilgidlDL = new PersonelBilgiDL())
                {
                    return _personelbilgidlDL.InsertAndGetId(this);
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
                using (PersonelBilgiDL _personelbilgidlDL = new PersonelBilgiDL())
                {
                    return _personelbilgidlDL.Update(this);
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
                using (PersonelBilgiDL _personelbilgidlDL = new PersonelBilgiDL())
                {
                    return _personelbilgidlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
