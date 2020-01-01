using Net.FreeORM.Log.Error;
using Net.FreeORM.ZzzTest_WFA2.Source.BO;
using Net.FreeORM.ZzzTest_WFA2.Source.DL;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Net.FreeORM.ZzzTest_WFA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            string str = string.Format("{0}", System.Configuration.ConfigurationSettings.AppSettings["free-conf-file"]);
            MessageBox.Show(str);
            Process.Start(str);
            */
            Stopwatch stp = new Stopwatch();
            //School school = new School();
            /*
            school.SchoolName = "New Universit2y";
            school.IsActive = 0;
            school.OBJID = 10;
            */
            stp.Start();

            using (GradesDL schlDL = new GradesDL("main3"))
            {
                grdTable.DataSource = schlDL.GetResultSetOfQuery("SELECT * FROM SYSADM.SYSCOLUMNS").Tables[0];

                //schlDL.GetResultSetOfQuery("SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, COLUMN_KEY, EXTRA FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='gurutest'").Tables[0];
                /*
                Grades grd = new Grades();

                grd.OBJID = 4;
                grd.IsActive = 1;
                //grd.GradeName = "Yeni bir Lisans";
                //MessageBox.Show(schlDL.GetObjectById<Grades>(2).GradeName);
                //   schlDL.Update(school);
                schlDL.Update(grd);
                grd = new Grades() { IsActive = 1 };
                grdTable.DataSource = schlDL.GetSpecialColumnsWithBO(new string[] { "GradeName", "IsActive" }, grd);
                 * */
            }
            stp.Stop();
            MessageBox.Show(string.Format("Süre(ms) : {0}", stp.ElapsedMilliseconds), "Result");
            //NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                using (SchoolDL schlDL = new SchoolDL())
                {
                    Kisi ks = new Kisi();
                    /*
                    ks.Id = 1;
                    ks.Isim = "Ahmet Nedim";
                    
                    int i = schlDL.ExecuteQuery(@"CREATE TABLE IF NOT EXISTS Kisi(Id INTEGER PRIMARY KEY, 
                                                Isim VARCHAR(25) NOT NULL,
                                                Soyisim VARCHAR(25) NOT NULL, 
                                                Tel INTEGER,
                                                Eposta VARCHAR(50),
                                                Adres TEXT);");
                    MessageBox.Show(string.Format("{0}", i), "Sonuç");
                                          * */
                    ks.Isim = "Kazım";
                    ks.Soyisim = "Uçar";
                    ks.Tel = 5645612;
                    ks.Eposta = "kucar@hotmail.com";
                    ks.Adres = "Aksaray";
                    schlDL.Insert(ks);

                    grdTable.DataSource = schlDL.GetTable(ks);
                    throw new Exception("this is new exception");
                }
            }
            catch (Exception ex)
            {
                FreeLogger.LogException(ex, System.Reflection.MethodBase.GetCurrentMethod(), 2);
                /*
                FreeLogger log = new FreeLogger()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    Title = "New Excep",                    
                    LogCode = "Err1002",
                    UserId = 2
                };
                log.Write();
                 * */
                //throw;
            }
        }
    }
}
