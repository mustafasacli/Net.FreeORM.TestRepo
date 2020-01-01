using Net.FreeORM.Framework.Base;

namespace Net.FreeORM.ZzzTest_WFA2.Source.BO
{
    class Kisi : BaseBO
    {

        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged("Id"); }
        }

        private string _Isim;
        public string Isim
        {
            get { return _Isim; }
            set { _Isim = value; OnPropertyChanged("Isim"); }
        }

        private string _Soyisim;
        public string Soyisim
        {
            get { return _Soyisim; }
            set { _Soyisim = value; OnPropertyChanged("Soyisim"); }
        }

        private int _Tel;
        public int Tel
        {
            get { return _Tel; }
            set { _Tel = value; OnPropertyChanged("Tel"); }
        }

        private string _Eposta;
        public string Eposta
        {
            get { return _Eposta; }
            set { _Eposta = value; OnPropertyChanged("Eposta"); }
        }

        private string _Adres;
        public string Adres
        {
            get { return _Adres; }
            set { _Adres = value; OnPropertyChanged("Adres"); }
        }

        public override string GetIdColumn()
        {
            return "Id";
        }

        public override string GetTableName()
        {
            return "Kisi";
        }

    }
}
