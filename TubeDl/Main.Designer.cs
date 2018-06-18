﻿namespace TubeDl
{
    partial class Main
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
            this.btndownload = new System.Windows.Forms.Button();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPause = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblaudio = new System.Windows.Forms.Label();
            this.lblformat = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblquality = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloaded_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.download_speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Items = new System.Windows.Forms.ListView();
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btncle = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtlink = new TextBoxWatermark.ExTextBox();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndownload
            // 
            this.btndownload.AutoSize = true;
            this.btndownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndownload.Location = new System.Drawing.Point(482, 40);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(65, 23);
            this.btndownload.TabIndex = 0;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // cmbQuality
            // 
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Items.AddRange(new object[] {
            "1080p: 1920x1080 (no audio)",
            "720p: 1280x720",
            "480p: 854x480",
            "360p: 640x360",
            "240p: 426x240",
            "Mp3"});
            this.cmbQuality.Location = new System.Drawing.Point(430, 13);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(224, 21);
            this.cmbQuality.TabIndex = 4;
            this.cmbQuality.TabStop = false;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnPause
            // 
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(556, 40);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(98, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause/Resume";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(354, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save Path     :";
            // 
            // lblpath
            // 
            this.lblpath.AutoEllipsis = true;
            this.lblpath.Location = new System.Drawing.Point(90, 45);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(255, 13);
            this.lblpath.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Mp4 Video files (*.Mp4)|*.mp4";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save File";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(430, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Catch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblaudio);
            this.grpInfo.Controls.Add(this.lblformat);
            this.grpInfo.Controls.Add(this.lblsize);
            this.grpInfo.Controls.Add(this.lblquality);
            this.grpInfo.Controls.Add(this.lbltitle);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label11);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Location = new System.Drawing.Point(15, 72);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(639, 100);
            this.grpInfo.TabIndex = 14;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Video info";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // lblaudio
            // 
            this.lblaudio.AutoEllipsis = true;
            this.lblaudio.AutoSize = true;
            this.lblaudio.Location = new System.Drawing.Point(293, 78);
            this.lblaudio.Name = "lblaudio";
            this.lblaudio.Size = new System.Drawing.Size(0, 13);
            this.lblaudio.TabIndex = 19;
            // 
            // lblformat
            // 
            this.lblformat.AutoEllipsis = true;
            this.lblformat.AutoSize = true;
            this.lblformat.Location = new System.Drawing.Point(103, 78);
            this.lblformat.Name = "lblformat";
            this.lblformat.Size = new System.Drawing.Size(0, 13);
            this.lblformat.TabIndex = 18;
            // 
            // lblsize
            // 
            this.lblsize.AutoEllipsis = true;
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(103, 56);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(0, 13);
            this.lblsize.TabIndex = 17;
            // 
            // lblquality
            // 
            this.lblquality.AutoEllipsis = true;
            this.lblquality.AutoSize = true;
            this.lblquality.Location = new System.Drawing.Point(103, 34);
            this.lblquality.Name = "lblquality";
            this.lblquality.Size = new System.Drawing.Size(0, 13);
            this.lblquality.TabIndex = 16;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoEllipsis = true;
            this.lbltitle.Location = new System.Drawing.Point(101, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(525, 13);
            this.lbltitle.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Audio format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "File Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // total_length
            // 
            this.total_length.Text = "Total Length";
            this.total_length.Width = 80;
            // 
            // downloaded_length
            // 
            this.downloaded_length.Text = "Downloaded Length";
            this.downloaded_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.downloaded_length.Width = 120;
            // 
            // download_speed
            // 
            this.download_speed.Text = "Download Speed";
            this.download_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.download_speed.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 95;
            // 
            // list_Items
            // 
            this.list_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Items.BackColor = System.Drawing.SystemColors.Window;
            this.list_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fname,
            this.total_length,
            this.downloaded_length,
            this.download_speed,
            this.status});
            this.list_Items.FullRowSelect = true;
            this.list_Items.GridLines = true;
            this.list_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_Items.HideSelection = false;
            this.list_Items.Location = new System.Drawing.Point(15, 178);
            this.list_Items.Name = "list_Items";
            this.list_Items.Size = new System.Drawing.Size(639, 171);
            this.list_Items.TabIndex = 17;
            this.list_Items.UseCompatibleStateImageBehavior = false;
            this.list_Items.View = System.Windows.Forms.View.Details;
            this.list_Items.SelectedIndexChanged += new System.EventHandler(this.list_Items_SelectedIndexChanged);
            // 
            // fname
            // 
            this.fname.Text = "File Name";
            this.fname.Width = 230;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(378, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncle
            // 
            this.btncle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncle.AutoEllipsis = true;
            this.btncle.Enabled = false;
            this.btncle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncle.Location = new System.Drawing.Point(625, 181);
            this.btncle.Name = "btncle";
            this.btncle.Size = new System.Drawing.Size(25, 21);
            this.btncle.TabIndex = 19;
            this.btncle.Text = "x";
            this.btncle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncle.UseVisualStyleBackColor = true;
            this.btncle.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 352);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(639, 3);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 22);
            this.button3.TabIndex = 21;
            this.button3.Text = "📋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtlink
            // 
            this.txtlink.Hint = "Past Youtube Video address";
            this.txtlink.Location = new System.Drawing.Point(12, 13);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(390, 20);
            this.txtlink.TabIndex = 15;
            this.txtlink.TextChanged += new System.EventHandler(this.txtlink_TextChanged_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btncle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list_Items);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.cmbQuality);
            this.Controls.Add(this.btndownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "TubeDl";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblaudio;
        private System.Windows.Forms.Label lblformat;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblquality;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private TextBoxWatermark.ExTextBox txtlink;
        private System.Windows.Forms.ColumnHeader total_length;
        private System.Windows.Forms.ColumnHeader downloaded_length;
        private System.Windows.Forms.ColumnHeader download_speed;
        private System.Windows.Forms.ColumnHeader status;

        private System.Windows.Forms.ListView list_Items;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
    }
}

