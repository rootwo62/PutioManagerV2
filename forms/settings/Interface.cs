using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutioManager.forms.settings
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            checkBoxAutoStartApplication.Checked = Properties.Settings.Default.AutoStartApplication;
        }

        private void checkBoxAutoStartApplication_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoStartApplication = checkBoxAutoStartApplication.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
