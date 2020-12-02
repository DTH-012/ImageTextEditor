using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace ImageEditor
{
    public partial class TextEditor : UserControl
    {
        public TextEditor()
        {
            InitializeComponent();
            LoadColorCBO();
            LoadFontsData();
        }

        private void LoadFontsData()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cboFonts.Items.Add(font.Name);
            }
            cboFonts.SelectedIndex = 2;
        }

        private void LoadColorCBO()
        {
            ArrayList colorList = new ArrayList();
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cboColor.Items.Add(c.Name);
            }
            cboColor.SelectedIndex = 8;
        }

        private void cboColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
            }
        }

        private void txtAdded_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudXPos_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudYPos_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
