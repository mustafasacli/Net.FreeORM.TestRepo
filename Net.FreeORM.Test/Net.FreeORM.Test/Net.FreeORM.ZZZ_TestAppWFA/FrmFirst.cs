using Net.FreeORM.Extensions;
using Net.FreeORM.ZZZ_TestAppWFA.Source.BO;
using Net.FreeORM.ZZZ_TestAppWFA.Source.DL;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Windows.Forms;

namespace Net.FreeORM.ZZZ_TestAppWFA
{
    public partial class FrmFirst : FrmBase
    {
        public FrmFirst()
        {
            InitializeComponent();
            /*
            Company cmp = new Company()
            {
                CompanyName = "Thai2",
                OBJID = 6
            };
            int cmpId = new CompanyDL().Update(cmp);
            MessageBox.Show("Son güncelleme durumu : " + cmpId.ToString(), "Sonuç");
            */
            //string ali = "Aldghşld;İFhl,dihkigklşfihkjmklşfgi";
            this.Text = long.MaxValue.ToString().MultiplyStrings(long.MaxValue.ToString());//ali.Reverse();
            /*
            Company cmp = new Company()
            {
                CompanyName = "CLI Guru",
                IsActive = 1,
                OBJID = 9
            };
            MessageBox.Show(cmp.Equals(new Company() { OBJID = 9 }) ? "True" : "False", "Result");
            CompanyDL cmpDL = new CompanyDL();
            QueryBuilder qB = cmpDL.CreateQueryBuilder(QueryTypes.Select, new Company());
            DataTable dt = cmpDL.GetResultSetOfQuery(qB.QueryString).Tables[0];
            grdFree.DataSource = dt;
             * */
            Stopwatch stp = new Stopwatch();
            Grades grd = new Grades();
            grd.GradeName = "MygradeN";
            grd.IsActive = 1;
            grd.OBJID = 6;
            stp.Start();
            DataTable dt = new DataTable();
            using (GradesDL grdsDL = new GradesDL())
            {
                //grdsDL.Delete(grd);
                dt = grdsDL.GetTable(grd);
                grdFree.DataSource = dt;//GetTableAsList<Source.BO.Position>();//.AsQueryable().Where(p => p.OBJID < 3).ToList<Position>();    
            }
            stp.Stop();
            MessageBox.Show(string.Format("Saniyeler : {0}", stp.ElapsedMilliseconds), "Result");
            dt.ExportAsExcelWithExcludeColumns("D:/Al2.xls", "OBJID");
            //Control();
        }

        public void Control()
        {
            string _conStr = "Server=KRK\\SQLEXPRESS; Initial Catalog=InCareTest; Persist Security Info=True; User Id=sa; Password=123123;";
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DbConnection dbCon = dbFactory.CreateConnection();
            dbCon.ConnectionString = _conStr;
            dbCon.Open();
            MessageBox.Show("Connection Opened.");
            dbCon.Close();
            MessageBox.Show("Connection Closed.");
            dbCon.Dispose();
            dbFactory = null;
        }
    }
}
