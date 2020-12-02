using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        Graphics graphicsObject;
        Bitmap mainImage;
        public Form1()
        {
            InitializeComponent();
            openImageDialog.Filter = "image files (*.jpg; *.jpeg; *.jpe; *.gif; *.png)| *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            LoadColorCBO();
            LoadFontsData(); 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false; // Vertical rather than horizontal scrolling
        }

        private void LoadFontsData()
        {
            //foreach (FontFamily font in System.Drawing.FontFamily.Families)
            //{
            //    cboFonts.Items.Add(font.Name);
            //}
            //cboFonts.SelectedIndex = 2;
        }

        private void LoadColorCBO()
        {
            //ArrayList colorList = new ArrayList();
            //Type colorType = typeof(Color);
            //PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
            //                              BindingFlags.DeclaredOnly | BindingFlags.Public);
            //foreach (PropertyInfo c in propInfoList)
            //{
            //    this.cboColor.Items.Add(c.Name);
            //}
            //cboColor.SelectedIndex = 8;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtImagePath.Text = openImageDialog.FileName;
                    mainImage = CreateMainImage();

                    //using (Font arialFont = new Font("Arial", 10))
                    //{
                    //    PointF firstLocation = new PointF(10f, 10f);
                    //    string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
                    //    Color color = Color.FromName(colorName);
                    //    Brush brush = new SolidBrush(color);
                    //    graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
                    //}

                    pbMain.Image = mainImage;

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private Bitmap CreateMainImage()
        {
            var image = new Bitmap(openImageDialog.FileName);
            double widthRate = (double)image.Width / pbMain.Width;
            double heightRate = (double)image.Height / pbMain.Height;
            var newWidth = image.Width;
            var newHeight = image.Height;

            if (widthRate > heightRate)
            {
                newWidth = (int)(image.Width / widthRate);
                newHeight = (int)(image.Height / widthRate);
            }
            else
            {
                newWidth = (int)(image.Width / heightRate);
                newHeight = (int)(image.Height / heightRate);
            }

            var newImage = new Bitmap(newWidth, newHeight);
            graphicsObject = Graphics.FromImage(newImage);

            graphicsObject.DrawImage(image, new Rectangle(0, 0, newImage.Width, newImage.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            return newImage;
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

        private void cboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudYPos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdded_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudXPos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            TextEditor MyButton = new TextEditor();
            MyButton.Text = "Submit";
            flowLayoutPanel1.Controls.Add(MyButton);
            flowLayoutPanel1.Controls.Add(MyButton);
        }

        //private void txtAdded_TextChanged(object sender, EventArgs e)
        //{
        //    if(graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF(10f, 10f);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}

        //private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF(10f, 10f);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}

        //private void nudXPos_ValueChanged(object sender, EventArgs e)
        //{
        //    if (graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF((float)nudXPos.Value, (float)nudYPos.Value);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}

        //private void nudYPos_ValueChanged(object sender, EventArgs e)
        //{
        //    if (graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF((float)nudXPos.Value, (float)nudYPos.Value);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}

        //private void cboFonts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF((float)nudXPos.Value, (float)nudYPos.Value);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}

        //private void nudFontSize_ValueChanged(object sender, EventArgs e)
        //{
        //    if (graphicsObject != null)
        //    {
        //        mainImage = CreateMainImage();
        //        Font arialFont = new Font(cboFonts.SelectedItem.ToString(), (float)nudFontSize.Value);
        //        PointF firstLocation = new PointF((float)nudXPos.Value, (float)nudYPos.Value);
        //        string colorName = cboColor.Items[cboColor.SelectedIndex].ToString();
        //        Color color = Color.FromName(colorName);
        //        Brush brush = new SolidBrush(color);
        //        graphicsObject.DrawString(txtAdded.Text, arialFont, brush, firstLocation);
        //        pbMain.Image = mainImage;
        //    }
        //}
    }
}
