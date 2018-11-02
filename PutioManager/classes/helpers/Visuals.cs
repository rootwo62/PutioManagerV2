using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutioManager.classes.helpers
{
    public class Visuals
    {
        public Color BackgroundColor = Color.DimGray;
        public Color AltBackGroundColor = Color.PaleGoldenrod;
        public Color ForeColor = Color.White;
        public Color PutioYellow = ColorTranslator.FromHtml("#FDC214");
        public DataGridViewCellStyle DataGridViewStyle;



        public readonly int LabelFontSize = 10;
        public readonly FontFamily LabelFontFamily = new EmbeddedFonts().Fonts.FirstOrDefault(font => font.Name == "Roboto");

        public Visuals()
        {
            DataGridViewStyle = new DataGridViewCellStyle { BackColor = Color.White, SelectionBackColor = PutioYellow, ForeColor = Color.Black, SelectionForeColor = Color.Black };
        }

        public void SetColors(Control control)
        {
            control.BackColor = AltBackGroundColor;
            control.ForeColor = ForeColor;
        }

        public void LoadClickedForm(Form inFormToLoad, Panel inParentPanel)
        {
            inParentPanel.Controls.Clear();
            inFormToLoad.TopLevel = false;
            inFormToLoad.FormBorderStyle = FormBorderStyle.None;
            inFormToLoad.Dock = DockStyle.Fill;
             
            inParentPanel.Controls.Add(inFormToLoad);
            inFormToLoad.Show();

        }

        public class MenuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                    base.OnRenderMenuItemBackground(e);
                else
                {
                    Color color = ColorTranslator.FromHtml("#FDC214");
                    SolidBrush brush = new SolidBrush(color);
                    Rectangle menuRectangle = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(brush, menuRectangle);
                    e.Graphics.DrawRectangle(Pens.Black, 0, 0, menuRectangle.Width - 1, menuRectangle.Height - 1);
                    e.ToolStrip.ShowItemToolTips = true;
                }
            }
        }

        public void SetControlFont(Control control)
        {
            control.Font = new Font(LabelFontFamily, LabelFontSize);
        }

        public void SetControlFont(Control control, int fontsize)
        {
            control.Font = new Font(LabelFontFamily, fontsize);
        }
    }


    
}
