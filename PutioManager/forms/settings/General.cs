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

namespace PutioManager.forms.settings
{
    public partial class General : Form
    {

        EmbeddedFonts embeddedFonts = new EmbeddedFonts();

        public General()
        {
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OAuthToken != "")
                textBox1.ReadOnly = true;
            textBox1.Text = Properties.Settings.Default.OAuthToken;
        }

        private void buttonChangeGetToken_Click(object sender, EventArgs e)
        {
            string url = "https://api.put.io/v2/oauth2/authenticate?client_id=3510&response_type=oob&redirect_uri=";
            System.Diagnostics.Process.Start(url);
            textBox1.ReadOnly = false;
        }
    }
}
