using Net.FreeORM.ResourceBuilding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Net.FreeORM.Zzz_TestResourcesAppWFA
{
    public partial class Form1 : RadForm
    {
        //.Resources.ControlResources.WinFormStrings
        //.Resources.MessageResources.AppMessages
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            ResourceBuilder formRes = ResourceBuilder.CreateInstance("Net.FreeORM.Zzz_TestResourcesAppWFA.Resources.ControlResources.WinFormStrings", typeof(Form1));
            ResourceBuilder mesRes = ResourceBuilder.CreateInstance("Net.FreeORM.Zzz_TestResourcesAppWFA.Resources.MessageResources.AppMessages", typeof(Form1));
            MessageBox.Show(mesRes.Get("StrHello"), "Mesaj");
            this.Text = formRes["StrHeader"];
        }
    }
}
