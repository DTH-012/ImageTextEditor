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
        public string Value { get; set; }
        public Brush FontColor { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Font FontConfig { get; set; }

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler TextEdited;

        public TextEditor()
        {
            InitializeComponent();
            Value = string.Empty;
            FontColor = new SolidBrush(Color.Black);
            X = 0f;
            Y = 0f;
            FontConfig = new Font("Arial", 10);
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
            Value = txtAdded.Text;

            if (TextEdited != null) TextEdited(this, e);
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
            Color color = Color.FromName(colorName);
            FontColor = new SolidBrush(color);

            if (TextEdited != null) TextEdited(this, e);
        }

        private void nudXPos_ValueChanged(object sender, EventArgs e)
        {
            X = (float)nudXPos.Value;

            if (TextEdited != null) TextEdited(this, e);
        }

        private void nudYPos_ValueChanged(object sender, EventArgs e)
        {
            Y = (float)nudYPos.Value;

            if (TextEdited != null) TextEdited(this, e);
        }

        private void cboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontConfig = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);

            if (TextEdited != null) TextEdited(this, e);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            FontConfig = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);

            if (TextEdited != null) TextEdited(this, e);
        }
    }
}
