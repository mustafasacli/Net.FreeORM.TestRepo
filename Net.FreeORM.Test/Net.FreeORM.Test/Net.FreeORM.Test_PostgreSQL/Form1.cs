using System;
using System.Windows.Forms;

namespace Net.FreeORM.Test_PostgreSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frm_person fp = new frm_person();
            fp.ShowDialog();
        }
    }
}
