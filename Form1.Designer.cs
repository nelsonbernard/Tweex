namespace Tweex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonGatherInfo = new System.Windows.Forms.Button();
            this.checkBoxWebcam = new System.Windows.Forms.CheckBox();
            this.checkBoxTouchscreen = new System.Windows.Forms.CheckBox();
            this.textBoxHDD = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBackdrop = new System.Windows.Forms.PictureBox();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.textBoxOSVersion = new System.Windows.Forms.TextBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cboxTheme = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(89, 152);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(240, 22);
            this.textBoxVideo.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Graphics";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Location = new System.Drawing.Point(29, 349);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(300, 39);
            this.buttonExecute.TabIndex = 41;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Enabled = false;
            this.buttonPreview.Location = new System.Drawing.Point(177, 305);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(150, 38);
            this.buttonPreview.TabIndex = 40;
            this.buttonPreview.Text = "Generate Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonGatherInfo
            // 
            this.buttonGatherInfo.Location = new System.Drawing.Point(27, 305);
            this.buttonGatherInfo.Name = "buttonGatherInfo";
            this.buttonGatherInfo.Size = new System.Drawing.Size(139, 38);
            this.buttonGatherInfo.TabIndex = 39;
            this.buttonGatherInfo.Text = "Gather Info";
            this.buttonGatherInfo.UseVisualStyleBackColor = true;
            this.buttonGatherInfo.Click += new System.EventHandler(this.buttonGatherInfo_Click_1);
            // 
            // checkBoxWebcam
            // 
            this.checkBoxWebcam.AutoSize = true;
            this.checkBoxWebcam.Checked = true;
            this.checkBoxWebcam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWebcam.Location = new System.Drawing.Point(302, 265);
            this.checkBoxWebcam.Name = "checkBoxWebcam";
            this.checkBoxWebcam.Size = new System.Drawing.Size(18, 17);
            this.checkBoxWebcam.TabIndex = 37;
            this.checkBoxWebcam.UseVisualStyleBackColor = true;
            // 
            // checkBoxTouchscreen
            // 
            this.checkBoxTouchscreen.AutoSize = true;
            this.checkBoxTouchscreen.Location = new System.Drawing.Point(184, 266);
            this.checkBoxTouchscreen.Name = "checkBoxTouchscreen";
            this.checkBoxTouchscreen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTouchscreen.TabIndex = 36;
            this.checkBoxTouchscreen.UseVisualStyleBackColor = true;
            // 
            // textBoxHDD
            // 
            this.textBoxHDD.Location = new System.Drawing.Point(89, 124);
            this.textBoxHDD.Name = "textBoxHDD";
            this.textBoxHDD.Size = new System.Drawing.Size(240, 22);
            this.textBoxHDD.TabIndex = 35;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(90, 96);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(239, 22);
            this.textBoxMemory.TabIndex = 34;
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(89, 68);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPU.TabIndex = 33;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(90, 40);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(239, 22);
            this.textBoxModel.TabIndex = 32;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(90, 12);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(239, 22);
            this.textBoxMake.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Webcam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Touchscreen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "HDD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Memory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Model #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Make";
            // 
            // pictureBoxBackdrop
            // 
            this.pictureBoxBackdrop.BackgroundImage = global::Tweex.Properties.Resources.testbackground;
            this.pictureBoxBackdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackdrop.InitialImage = null;
            this.pictureBoxBackdrop.Location = new System.Drawing.Point(335, 12);
            this.pictureBoxBackdrop.Name = "pictureBoxBackdrop";
            this.pictureBoxBackdrop.Size = new System.Drawing.Size(548, 376);
            this.pictureBoxBackdrop.TabIndex = 44;
            this.pictureBoxBackdrop.TabStop = false;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.Location = new System.Drawing.Point(5, 185);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(80, 17);
            this.lblOSVersion.TabIndex = 45;
            this.lblOSVersion.Text = "OS Version";
            // 
            // textBoxOSVersion
            // 
            this.textBoxOSVersion.Location = new System.Drawing.Point(89, 180);
            this.textBoxOSVersion.Name = "textBoxOSVersion";
            this.textBoxOSVersion.Size = new System.Drawing.Size(240, 22);
            this.textBoxOSVersion.TabIndex = 46;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(30, 215);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(52, 17);
            this.lblTheme.TabIndex = 47;
            this.lblTheme.Text = "Theme";
            // 
            // cboxTheme
            // 
            this.cboxTheme.FormattingEnabled = true;
            this.cboxTheme.Items.AddRange(new object[] {
            "Browse..."});
            this.cboxTheme.Location = new System.Drawing.Point(88, 208);
            this.cboxTheme.Name = "cboxTheme";
            this.cboxTheme.Size = new System.Drawing.Size(242, 24);
            this.cboxTheme.TabIndex = 48;
            this.cboxTheme.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 401);
            this.Controls.Add(this.cboxTheme);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.textBoxOSVersion);
            this.Controls.Add(this.lblOSVersion);
            this.Controls.Add(this.pictureBoxBackdrop);
            this.Controls.Add(this.textBoxVideo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonGatherInfo);
            this.Controls.Add(this.checkBoxWebcam);
            this.Controls.Add(this.checkBoxTouchscreen);
            this.Controls.Add(this.textBoxHDD);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxCPU);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OS Tweex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonGatherInfo;
        private System.Windows.Forms.CheckBox checkBoxWebcam;
        private System.Windows.Forms.CheckBox checkBoxTouchscreen;
        private System.Windows.Forms.TextBox textBoxHDD;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBackdrop;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.TextBox textBoxOSVersion;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cboxTheme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

