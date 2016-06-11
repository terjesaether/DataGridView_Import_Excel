﻿namespace DataGridView_Import_Excel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.btnCheckActor = new System.Windows.Forms.Button();
            this.lblActorInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblChosenDubber = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblScanMessage = new System.Windows.Forms.Label();
            this.btnRescanFolder = new System.Windows.Forms.Button();
            this.lblTotalNumLines = new System.Windows.Forms.Label();
            this.btnCheckAllEps = new System.Windows.Forms.Button();
            this.lblChosenEpisodeFrontpage = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblFileChosen = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.comboListFiles = new System.Windows.Forms.ComboBox();
            this.lboxShowFiles = new System.Windows.Forms.ListBox();
            this.btnListFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(200, 29);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Velg manus";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtActorName
            // 
            this.txtActorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorName.Location = new System.Drawing.Point(7, 41);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(200, 26);
            this.txtActorName.TabIndex = 7;
            this.txtActorName.TextChanged += new System.EventHandler(this.txtActorName_TextChanged);
            // 
            // btnCheckActor
            // 
            this.btnCheckActor.Location = new System.Drawing.Point(221, 41);
            this.btnCheckActor.Name = "btnCheckActor";
            this.btnCheckActor.Size = new System.Drawing.Size(200, 26);
            this.btnCheckActor.TabIndex = 8;
            this.btnCheckActor.Text = "Sjekk døbber (velg episoder)";
            this.btnCheckActor.UseVisualStyleBackColor = true;
            this.btnCheckActor.Click += new System.EventHandler(this.btnCheckActor_Click);
            // 
            // lblActorInfo
            // 
            this.lblActorInfo.AutoSize = true;
            this.lblActorInfo.Location = new System.Drawing.Point(15, 87);
            this.lblActorInfo.Name = "lblActorInfo";
            this.lblActorInfo.Size = new System.Drawing.Size(73, 13);
            this.lblActorInfo.TabIndex = 9;
            this.lblActorInfo.Text = "Valgt dubber: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 121);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1152, 636);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(111, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 20;
            // 
            // lblChosenDubber
            // 
            this.lblChosenDubber.AutoSize = true;
            this.lblChosenDubber.Location = new System.Drawing.Point(95, 82);
            this.lblChosenDubber.Name = "lblChosenDubber";
            this.lblChosenDubber.Size = new System.Drawing.Size(0, 13);
            this.lblChosenDubber.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 28);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 800);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblScanMessage);
            this.tabPage1.Controls.Add(this.btnRescanFolder);
            this.tabPage1.Controls.Add(this.lblTotalNumLines);
            this.tabPage1.Controls.Add(this.btnCheckAllEps);
            this.tabPage1.Controls.Add(this.lblChosenEpisodeFrontpage);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.lblChosenDubber);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.txtActorName);
            this.tabPage1.Controls.Add(this.lblActorInfo);
            this.tabPage1.Controls.Add(this.btnCheckActor);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1172, 764);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoved";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblScanMessage
            // 
            this.lblScanMessage.AutoSize = true;
            this.lblScanMessage.Location = new System.Drawing.Point(641, 7);
            this.lblScanMessage.Name = "lblScanMessage";
            this.lblScanMessage.Size = new System.Drawing.Size(0, 13);
            this.lblScanMessage.TabIndex = 27;
            // 
            // btnRescanFolder
            // 
            this.btnRescanFolder.Location = new System.Drawing.Point(958, 50);
            this.btnRescanFolder.Name = "btnRescanFolder";
            this.btnRescanFolder.Size = new System.Drawing.Size(200, 26);
            this.btnRescanFolder.TabIndex = 26;
            this.btnRescanFolder.Text = "Scan produksjonen på nytt";
            this.btnRescanFolder.UseVisualStyleBackColor = true;
            this.btnRescanFolder.Click += new System.EventHandler(this.btnRescanFolder_Click);
            // 
            // lblTotalNumLines
            // 
            this.lblTotalNumLines.AutoSize = true;
            this.lblTotalNumLines.Location = new System.Drawing.Point(428, 87);
            this.lblTotalNumLines.Name = "lblTotalNumLines";
            this.lblTotalNumLines.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNumLines.TabIndex = 25;
            // 
            // btnCheckAllEps
            // 
            this.btnCheckAllEps.Location = new System.Drawing.Point(428, 41);
            this.btnCheckAllEps.Name = "btnCheckAllEps";
            this.btnCheckAllEps.Size = new System.Drawing.Size(200, 26);
            this.btnCheckAllEps.TabIndex = 24;
            this.btnCheckAllEps.Text = "Sjekk døbber på alle seriene";
            this.btnCheckAllEps.UseVisualStyleBackColor = true;
            this.btnCheckAllEps.Click += new System.EventHandler(this.btnCheckAllEps_Click);
            // 
            // lblChosenEpisodeFrontpage
            // 
            this.lblChosenEpisodeFrontpage.AutoSize = true;
            this.lblChosenEpisodeFrontpage.Location = new System.Drawing.Point(224, 7);
            this.lblChosenEpisodeFrontpage.Name = "lblChosenEpisodeFrontpage";
            this.lblChosenEpisodeFrontpage.Size = new System.Drawing.Size(103, 13);
            this.lblChosenEpisodeFrontpage.TabIndex = 23;
            this.lblChosenEpisodeFrontpage.Text = "Ingen valgt episode.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1172, 764);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manusforside";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblFileChosen);
            this.tabPage4.Controls.Add(this.btnChooseFile);
            this.tabPage4.Controls.Add(this.comboListFiles);
            this.tabPage4.Controls.Add(this.lboxShowFiles);
            this.tabPage4.Controls.Add(this.btnListFolder);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1172, 764);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Velg episoder";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblFileChosen
            // 
            this.lblFileChosen.AutoSize = true;
            this.lblFileChosen.Location = new System.Drawing.Point(672, 36);
            this.lblFileChosen.Name = "lblFileChosen";
            this.lblFileChosen.Size = new System.Drawing.Size(0, 13);
            this.lblFileChosen.TabIndex = 4;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(669, 3);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Velg eps";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // comboListFiles
            // 
            this.comboListFiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboListFiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboListFiles.FormattingEnabled = true;
            this.comboListFiles.Location = new System.Drawing.Point(322, 4);
            this.comboListFiles.Name = "comboListFiles";
            this.comboListFiles.Size = new System.Drawing.Size(329, 21);
            this.comboListFiles.TabIndex = 2;
            // 
            // lboxShowFiles
            // 
            this.lboxShowFiles.FormattingEnabled = true;
            this.lboxShowFiles.Location = new System.Drawing.Point(86, 4);
            this.lboxShowFiles.Name = "lboxShowFiles";
            this.lboxShowFiles.Size = new System.Drawing.Size(209, 303);
            this.lboxShowFiles.TabIndex = 1;
            // 
            // btnListFolder
            // 
            this.btnListFolder.Location = new System.Drawing.Point(4, 4);
            this.btnListFolder.Name = "btnListFolder";
            this.btnListFolder.Size = new System.Drawing.Size(75, 23);
            this.btnListFolder.TabIndex = 0;
            this.btnListFolder.Text = "List mappe";
            this.btnListFolder.UseVisualStyleBackColor = true;
            this.btnListFolder.Click += new System.EventHandler(this.btnListFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check check v0.6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.Label lblActorInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblChosenDubber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lboxShowFiles;
        private System.Windows.Forms.Button btnListFolder;
        private System.Windows.Forms.ComboBox comboListFiles;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnCheckActor;
        private System.Windows.Forms.Label lblFileChosen;
        private System.Windows.Forms.Label lblChosenEpisodeFrontpage;
        private System.Windows.Forms.Button btnCheckAllEps;
        private System.Windows.Forms.Label lblTotalNumLines;
        private System.Windows.Forms.Button btnRescanFolder;
        private System.Windows.Forms.Label lblScanMessage;
    }
}

