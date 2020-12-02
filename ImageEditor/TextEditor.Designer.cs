namespace ImageEditor
{
    partial class TextEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.cboFonts = new System.Windows.Forms.ComboBox();
            this.nudYPos = new System.Windows.Forms.NumericUpDown();
            this.nudXPos = new System.Windows.Forms.NumericUpDown();
            this.txtAdded = new System.Windows.Forms.TextBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(29, 133);
            this.nudFontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(120, 20);
            this.nudFontSize.TabIndex = 16;
            this.nudFontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cboFonts
            // 
            this.cboFonts.FormattingEnabled = true;
            this.cboFonts.Location = new System.Drawing.Point(30, 105);
            this.cboFonts.Name = "cboFonts";
            this.cboFonts.Size = new System.Drawing.Size(121, 21);
            this.cboFonts.TabIndex = 15;
            // 
            // nudYPos
            // 
            this.nudYPos.Location = new System.Drawing.Point(29, 78);
            this.nudYPos.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudYPos.Name = "nudYPos";
            this.nudYPos.Size = new System.Drawing.Size(120, 20);
            this.nudYPos.TabIndex = 14;
            // 
            // nudXPos
            // 
            this.nudXPos.Location = new System.Drawing.Point(29, 51);
            this.nudXPos.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.nudXPos.Name = "nudXPos";
            this.nudXPos.Size = new System.Drawing.Size(120, 20);
            this.nudXPos.TabIndex = 13;
            // 
            // txtAdded
            // 
            this.txtAdded.Location = new System.Drawing.Point(29, 25);
            this.txtAdded.Name = "txtAdded";
            this.txtAdded.Size = new System.Drawing.Size(100, 20);
            this.txtAdded.TabIndex = 12;
            // 
            // cboColor
            // 
            this.cboColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(29, -2);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(216, 21);
            this.cboColor.TabIndex = 11;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.cboFonts);
            this.Controls.Add(this.nudYPos);
            this.Controls.Add(this.nudXPos);
            this.Controls.Add(this.txtAdded);
            this.Controls.Add(this.cboColor);
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(410, 298);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.ComboBox cboFonts;
        private System.Windows.Forms.NumericUpDown nudYPos;
        private System.Windows.Forms.NumericUpDown nudXPos;
        private System.Windows.Forms.TextBox txtAdded;
        private System.Windows.Forms.ComboBox cboColor;
    }
}
