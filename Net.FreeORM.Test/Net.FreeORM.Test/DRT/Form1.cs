using DRT.Source.BO;
using DRT.Source.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (UsersDL frLgDL = new UsersDL())
            {
                grdLog.DataSource = frLgDL.GetTable(new FreeLogEntry());
            }
        }
    }
}
