namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.txtAdded = new System.Windows.Forms.TextBox();
            this.nudXPos = new System.Windows.Forms.NumericUpDown();
            this.nudYPos = new System.Windows.Forms.NumericUpDown();
            this.cboFonts = new System.Windows.Forms.ComboBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(12, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(460, 370);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(478, 12);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(216, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(701, 11);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // cboColor
            // 
            this.cboColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(478, 38);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(216, 21);
            this.cboColor.TabIndex = 3;
            this.cboColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboColor_DrawItem);
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // txtAdded
            // 
            this.txtAdded.Location = new System.Drawing.Point(478, 65);
            this.txtAdded.Name = "txtAdded";
            this.txtAdded.Size = new System.Drawing.Size(100, 20);
            this.txtAdded.TabIndex = 4;
            this.txtAdded.TextChanged += new System.EventHandler(this.txtAdded_TextChanged);
            // 
            // nudXPos
            // 
            this.nudXPos.Location = new System.Drawing.Point(478, 91);
            this.nudXPos.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.nudXPos.Name = "nudXPos";
            this.nudXPos.Size = new System.Drawing.Size(120, 20);
            this.nudXPos.TabIndex = 7;
            this.nudXPos.ValueChanged += new System.EventHandler(this.nudXPos_ValueChanged);
            // 
            // nudYPos
            // 
            this.nudYPos.Location = new System.Drawing.Point(478, 118);
            this.nudYPos.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudYPos.Name = "nudYPos";
            this.nudYPos.Size = new System.Drawing.Size(120, 20);
            this.nudYPos.TabIndex = 8;
            this.nudYPos.ValueChanged += new System.EventHandler(this.nudYPos_ValueChanged);
            // 
            // cboFonts
            // 
            this.cboFonts.FormattingEnabled = true;
            this.cboFonts.Location = new System.Drawing.Point(479, 145);
            this.cboFonts.Name = "cboFonts";
            this.cboFonts.Size = new System.Drawing.Size(121, 21);
            this.cboFonts.TabIndex = 9;
            this.cboFonts.SelectedIndexChanged += new System.EventHandler(this.cboFonts_SelectedIndexChanged);
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(478, 173);
            this.nudFontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(120, 20);
            this.nudFontSize.TabIndex = 10;
            this.nudFontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.cboFonts);
            this.Controls.Add(this.nudYPos);
            this.Controls.Add(this.nudXPos);
            this.Controls.Add(this.txtAdded);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.pbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox txtAdded;
        private System.Windows.Forms.NumericUpDown nudXPos;
        private System.Windows.Forms.NumericUpDown nudYPos;
        private System.Windows.Forms.ComboBox cboFonts;
        private System.Windows.Forms.NumericUpDown nudFontSize;
    }
}

