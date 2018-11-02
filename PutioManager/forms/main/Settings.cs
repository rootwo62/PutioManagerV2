using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PutioManager.classes.helpers;
using PutioManager.forms.settings;

namespace PutioManager.forms.main
{
    public partial class Settings : Form
    {

        General frmGeneral = new General();
        settings.Downloads frmDownloads = new settings.Downloads();
        Interface frmInterface = new Interface();
        PutioManager putioManager;
        Visuals visuals = new Visuals();

        public Settings(PutioManager inPutioManager)
        {
            InitializeComponent();
            menuStripSettings.Renderer = new Visuals.MenuRenderer();
            putioManager = inPutioManager;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            visuals.LoadClickedForm(frmGeneral, panelMain);
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            var menuitem = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem item in menuStripSettings.Items)
            {
                if (item != menuitem)
                    item.BackColor = Color.Transparent;
                else
                    item.BackColor = ColorTranslator.FromHtml("#FDC214");
            }

            if (menuitem.Name == "generalToolStripMenuItem")
                visuals.LoadClickedForm(frmGeneral, panelMain);
            if (menuitem.Name == "downloadsToolStripMenuItem")
                visuals.LoadClickedForm(frmDownloads, panelMain);
            if (menuitem.Name == "interfaceToolStripMenuItem")
                visuals.LoadClickedForm(frmInterface, panelMain);

        }

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in putioManager.menuStripMain.Items)
                if (item.Alignment == ToolStripItemAlignment.Left)
                    item.Visible = false;

        }
    }
}
