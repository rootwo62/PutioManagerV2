using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Text;


namespace PutioManager.classes.helpers
{
    public class EmbeddedFonts
    {
    
        public readonly List<FontFamily> Fonts = new List<FontFamily>();

        public EmbeddedFonts()
        {
            // specify embedded resource name
            var assembly = Assembly.GetExecutingAssembly();
            
            foreach (var file in assembly.GetManifestResourceNames())
            {
                if (file.EndsWith(".ttf"))
                {
                    PrivateFontCollection private_fonts = new PrivateFontCollection();
                    Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(file);
                    System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                    byte[] fontdata = new byte[fontStream.Length];
                    fontStream.Read(fontdata, 0, (int)fontStream.Length);
                    Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                    private_fonts.AddMemoryFont(data, (int)fontStream.Length);
                    fontStream.Close();
                    Marshal.FreeCoTaskMem(data);

                    Fonts.AddRange(private_fonts.Families.ToArray());
                }
            }
           
        }

        public void SetTableHeaderFont(DataGridView inDataGridView, Font inFontForHeaders)
        {
            foreach(DataGridViewColumn column in inDataGridView.Columns)
            {
                column.HeaderCell.Style.Font = inFontForHeaders;
            }
        }

        public void SetControls(Control inControl)
        {
            Font controlFont;
            string familyName = "Roboto";
            foreach (Control control in inControl.Controls)
            {
                if (control is Label) { }
                controlFont = new Font(Fonts.First(x => x.Name == familyName), 12);
                if (control is TextBox)
                    controlFont = new Font(Fonts.First(x => x.Name == familyName), 10);
                if (control is Button)
                    controlFont = new Font(Fonts.First(x => x.Name == familyName), 9);
                else
                    controlFont = new Font(Fonts.First(x => x.Name == familyName), 10);
                control.Font = controlFont;
            }
        }

        internal class First
        {
            private Func<object, bool> p;

            public First(Func<object, bool> p)
            {
                this.p = p;
            }
        }
    }
}
