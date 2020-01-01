using Net.FreeORM.Framework.Extensions;
using Net.FreeORM.Test_PostgreSQL.Source.BO;
using Net.FreeORM.Test_PostgreSQL.Source.DL;
using System;
using System.Windows.Forms;

namespace Net.FreeORM.Test_PostgreSQL
{
    public partial class frm_person : Form
    {
        person p;
        bool boLock = false;

        public frm_person()
        {
            try
            {
                InitializeComponent();
                p = new person();
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void RefreshGrd()
        {
            try
            {
                using (personDL frLgDL = new personDL())
                {
                    grdPerson.DataSource = frLgDL.GetTable(new person());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                p.Insert();
                MessageBox.Show("Insert Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (p.ChangeSetCount > 1)
                    p.Update();

                MessageBox.Show("Update Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                p.Delete();
                MessageBox.Show("Delete Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void grdPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            p.id = txt_id.Text.ToInt();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.firstname = txt_firstname.Text;
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.lastname = txt_lastname.Text;
        }

        private void grdPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                boLock = true;
                p = new person();
                if (grdPerson.SelectedRows.Count > 0)
                {
                    txt_id.Text = grdPerson.SelectedRows[0].Cells["id"].Value.ToStr();
                    txt_firstname.Text = grdPerson.SelectedRows[0].Cells["firstname"].Value.ToStr();
                    txt_lastname.Text = grdPerson.SelectedRows[0].Cells["lastname"].Value.ToStr();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
            finally
            {
                boLock = false;
            }
        }
    }
}