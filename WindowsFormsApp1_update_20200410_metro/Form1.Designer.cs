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
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SerialPortComboBox = new MetroFramework.Controls.MetroComboBox();
            this.labelFileSize = new MetroFramework.Controls.MetroLabel();
            this.pathTextBox = new MetroFramework.Controls.MetroLabel();
            this.customTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.downloadButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(399, 193);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButton1.TabIndex = 6;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "FOH-100";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(292, 98);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(87, 32);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Open File";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(399, 214);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(58, 15);
            this.metroRadioButton2.TabIndex = 8;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "FOH-8";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(399, 235);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(53, 15);
            this.metroRadioButton3.TabIndex = 9;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "DWM";
            this.metroRadioButton3.UseVisualStyleBackColor = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(399, 268);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(72, 15);
            this.metroRadioButton4.TabIndex = 10;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "CUSTOM";
            this.metroRadioButton4.UseVisualStyleBackColor = true;
            this.metroRadioButton4.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChange);
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
            this.circularProgressBar1.Location = new System.Drawing.Point(57, 166);
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
            this.circularProgressBar1.TabIndex = 11;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.ItemHeight = 23;
            this.SerialPortComboBox.Location = new System.Drawing.Point(87, 98);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(121, 29);
            this.SerialPortComboBox.TabIndex = 12;
            this.SerialPortComboBox.Click += new System.EventHandler(this.SerialPortComboBox_Click);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(23, 420);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(83, 19);
            this.labelFileSize.TabIndex = 13;
            this.labelFileSize.Text = "metroLabel1";
            // 
            // pathTextBox
            // 
            this.pathTextBox.AutoSize = true;
            this.pathTextBox.Location = new System.Drawing.Point(159, 420);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(83, 19);
            this.pathTextBox.TabIndex = 14;
            this.pathTextBox.Text = "metroLabel2";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Location = new System.Drawing.Point(495, 260);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(122, 23);
            this.customTextBox1.TabIndex = 15;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(468, 98);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(87, 32);
            this.downloadButton.TabIndex = 16;
            this.downloadButton.Text = "Update";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 443);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.metroRadioButton4);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.SerialPortComboBox);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Text = "UPDATE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private MetroFramework.Controls.MetroComboBox SerialPortComboBox;
        private MetroFramework.Controls.MetroLabel labelFileSize;
        private MetroFramework.Controls.MetroLabel pathTextBox;
        private MetroFramework.Controls.MetroTextBox customTextBox1;
        private MetroFramework.Controls.MetroTile downloadButton;
    }
}

