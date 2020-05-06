namespace WindowsFormsApp1_update_20200410
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadButton = new Lwinform.Controls.MetroTile();
            this.metroRadioButton1 = new Lwinform.Controls.MetroRadioButton();
            this.metroRadioButton2 = new Lwinform.Controls.MetroRadioButton();
            this.customTextBox1 = new Lwinform.Controls.MetroTextBox();
            this.metroRadioButton3 = new Lwinform.Controls.MetroRadioButton();
            this.pathTextBox = new Lwinform.Controls.MetroLabel();
            this.metroRadioButton4 = new Lwinform.Controls.MetroRadioButton();
            this.labelFileSize = new Lwinform.Controls.MetroLabel();
            this.SerialPortComboBox = new Lwinform.Controls.MetroComboBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.metroTile1 = new Lwinform.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.downloadButton);
            this.panel1.Controls.Add(this.metroRadioButton1);
            this.panel1.Controls.Add(this.metroRadioButton2);
            this.panel1.Controls.Add(this.customTextBox1);
            this.panel1.Controls.Add(this.metroRadioButton3);
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.metroRadioButton4);
            this.panel1.Controls.Add(this.labelFileSize);
            this.panel1.Controls.Add(this.SerialPortComboBox);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 417);
            this.panel1.TabIndex = 17;
            // 
            // downloadButton
            // 
            this.downloadButton.ActiveControl = null;
            this.downloadButton.Location = new System.Drawing.Point(474, 46);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(87, 41);
            this.downloadButton.TabIndex = 27;
            this.downloadButton.Text = "Update";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadButton.UseSelectable = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(404, 150);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButton1.TabIndex = 17;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "FOH-100";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(404, 171);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(58, 15);
            this.metroRadioButton2.TabIndex = 19;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "FOH-8";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // customTextBox1
            // 
            // 
            // 
            // 
            this.customTextBox1.CustomButton.Image = null;
            this.customTextBox1.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.customTextBox1.CustomButton.Name = "";
            this.customTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customTextBox1.CustomButton.Style = Lwinform.MetroColorStyle.Blue;
            this.customTextBox1.CustomButton.TabIndex = 1;
            this.customTextBox1.CustomButton.Theme = Lwinform.MetroThemeStyle.Light;
            this.customTextBox1.CustomButton.UseSelectable = true;
            this.customTextBox1.CustomButton.Visible = false;
            this.customTextBox1.Lines = new string[0];
            this.customTextBox1.Location = new System.Drawing.Point(500, 217);
            this.customTextBox1.MaxLength = 32767;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.PasswordChar = '\0';
            this.customTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customTextBox1.SelectedText = "";
            this.customTextBox1.SelectionLength = 0;
            this.customTextBox1.SelectionStart = 0;
            this.customTextBox1.ShortcutsEnabled = true;
            this.customTextBox1.Size = new System.Drawing.Size(122, 23);
            this.customTextBox1.TabIndex = 26;
            this.customTextBox1.UseSelectable = true;
            this.customTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(404, 192);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(53, 15);
            this.metroRadioButton3.TabIndex = 20;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "DWM";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // pathTextBox
            // 
            this.pathTextBox.AutoSize = true;
            this.pathTextBox.Location = new System.Drawing.Point(168, 366);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(83, 19);
            this.pathTextBox.TabIndex = 25;
            this.pathTextBox.Text = "metroLabel2";
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(404, 225);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(72, 15);
            this.metroRadioButton4.TabIndex = 21;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "CUSTOM";
            this.metroRadioButton4.UseSelectable = true;
            this.metroRadioButton4.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(31, 366);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(83, 19);
            this.labelFileSize.TabIndex = 24;
            this.labelFileSize.Text = "metroLabel1";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.ItemHeight = 23;
            this.SerialPortComboBox.Location = new System.Drawing.Point(92, 55);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(121, 29);
            this.SerialPortComboBox.TabIndex = 23;
            this.SerialPortComboBox.UseSelectable = true;
            this.SerialPortComboBox.Click += new System.EventHandler(this.SerialPortComboBox_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(219)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(62, 123);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = 0;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circularProgressBar1.ProgressWidth = 17;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 22;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(294, 46);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(87, 41);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Open File";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Text = "UPDATE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Lwinform.Controls.MetroTile downloadButton;
        private Lwinform.Controls.MetroRadioButton metroRadioButton1;
        private Lwinform.Controls.MetroRadioButton metroRadioButton2;
        private Lwinform.Controls.MetroTextBox customTextBox1;
        private Lwinform.Controls.MetroRadioButton metroRadioButton3;
        private Lwinform.Controls.MetroLabel pathTextBox;
        private Lwinform.Controls.MetroRadioButton metroRadioButton4;
        private Lwinform.Controls.MetroLabel labelFileSize;
        private Lwinform.Controls.MetroComboBox SerialPortComboBox;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Lwinform.Controls.MetroTile metroTile1;
    }
}

