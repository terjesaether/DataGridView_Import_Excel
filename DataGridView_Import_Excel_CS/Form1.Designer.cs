namespace DataGridView_Import_Excel
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
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.chckPlakat = new System.Windows.Forms.CheckBox();
            this.chckIntro = new System.Windows.Forms.CheckBox();
            this.lblScanMessage = new System.Windows.Forms.Label();
            this.lblTotalNumLines = new System.Windows.Forms.Label();
            this.btnCheckAllEps = new System.Windows.Forms.Button();
            this.lblChosenEpisodeFrontpage = new System.Windows.Forms.Label();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.lblFileChosen = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.comboListFiles = new System.Windows.Forms.ComboBox();
            this.lboxShowFiles = new System.Windows.Forms.ListBox();
            this.btnListFolder = new System.Windows.Forms.Button();
            this.btnRescanFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageScript.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageScript);
            this.tabControl1.Controls.Add(this.tabPageSelect);
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 28);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 800);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.chckPlakat);
            this.tabPageMain.Controls.Add(this.chckIntro);
            this.tabPageMain.Controls.Add(this.lblScanMessage);
            this.tabPageMain.Controls.Add(this.lblTotalNumLines);
            this.tabPageMain.Controls.Add(this.btnCheckAllEps);
            this.tabPageMain.Controls.Add(this.lblChosenEpisodeFrontpage);
            this.tabPageMain.Controls.Add(this.flowLayoutPanel1);
            this.tabPageMain.Controls.Add(this.lblChosenDubber);
            this.tabPageMain.Controls.Add(this.linkLabel1);
            this.tabPageMain.Controls.Add(this.btnSelect);
            this.tabPageMain.Controls.Add(this.txtActorName);
            this.tabPageMain.Controls.Add(this.lblActorInfo);
            this.tabPageMain.Controls.Add(this.btnCheckActor);
            this.tabPageMain.Location = new System.Drawing.Point(4, 32);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1172, 764);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Hoved";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // chckPlakat
            // 
            this.chckPlakat.AutoSize = true;
            this.chckPlakat.Checked = true;
            this.chckPlakat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckPlakat.Location = new System.Drawing.Point(717, 30);
            this.chckPlakat.Name = "chckPlakat";
            this.chckPlakat.Size = new System.Drawing.Size(107, 17);
            this.chckPlakat.TabIndex = 29;
            this.chckPlakat.Text = "Ikke vis PLAKAT";
            this.chckPlakat.UseVisualStyleBackColor = true;
            // 
            // chckIntro
            // 
            this.chckIntro.AutoSize = true;
            this.chckIntro.Checked = true;
            this.chckIntro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckIntro.Location = new System.Drawing.Point(717, 6);
            this.chckIntro.Name = "chckIntro";
            this.chckIntro.Size = new System.Drawing.Size(121, 17);
            this.chckIntro.TabIndex = 28;
            this.chckIntro.Text = "Ikke vis intro / outro";
            this.chckIntro.UseVisualStyleBackColor = true;
            // 
            // lblScanMessage
            // 
            this.lblScanMessage.AutoSize = true;
            this.lblScanMessage.Location = new System.Drawing.Point(641, 7);
            this.lblScanMessage.Name = "lblScanMessage";
            this.lblScanMessage.Size = new System.Drawing.Size(0, 13);
            this.lblScanMessage.TabIndex = 27;
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
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.dataGridView1);
            this.tabPageScript.Location = new System.Drawing.Point(4, 32);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScript.Size = new System.Drawing.Size(1172, 764);
            this.tabPageScript.TabIndex = 1;
            this.tabPageScript.Text = "Manusforside";
            this.tabPageScript.UseVisualStyleBackColor = true;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.btnRescanFolder);
            this.tabPageSelect.Controls.Add(this.lblFileChosen);
            this.tabPageSelect.Controls.Add(this.btnChooseFile);
            this.tabPageSelect.Controls.Add(this.comboListFiles);
            this.tabPageSelect.Controls.Add(this.lboxShowFiles);
            this.tabPageSelect.Controls.Add(this.btnListFolder);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 32);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(1172, 764);
            this.tabPageSelect.TabIndex = 3;
            this.tabPageSelect.Text = "Velg episoder";
            this.tabPageSelect.UseVisualStyleBackColor = true;
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
            this.btnChooseFile.Location = new System.Drawing.Point(5, 36);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(100, 25);
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
            this.comboListFiles.Location = new System.Drawing.Point(360, 4);
            this.comboListFiles.Name = "comboListFiles";
            this.comboListFiles.Size = new System.Drawing.Size(291, 21);
            this.comboListFiles.TabIndex = 2;
            // 
            // lboxShowFiles
            // 
            this.lboxShowFiles.FormattingEnabled = true;
            this.lboxShowFiles.Location = new System.Drawing.Point(110, 4);
            this.lboxShowFiles.Name = "lboxShowFiles";
            this.lboxShowFiles.Size = new System.Drawing.Size(244, 524);
            this.lboxShowFiles.TabIndex = 1;
            // 
            // btnListFolder
            // 
            this.btnListFolder.Location = new System.Drawing.Point(5, 4);
            this.btnListFolder.Name = "btnListFolder";
            this.btnListFolder.Size = new System.Drawing.Size(100, 25);
            this.btnListFolder.TabIndex = 0;
            this.btnListFolder.Text = "List mappe";
            this.btnListFolder.UseVisualStyleBackColor = true;
            this.btnListFolder.Click += new System.EventHandler(this.btnListFolder_Click);
            // 
            // btnRescanFolder
            // 
            this.btnRescanFolder.Location = new System.Drawing.Point(958, 4);
            this.btnRescanFolder.Name = "btnRescanFolder";
            this.btnRescanFolder.Size = new System.Drawing.Size(200, 26);
            this.btnRescanFolder.TabIndex = 27;
            this.btnRescanFolder.Text = "Scan mappe  på nytt";
            this.btnRescanFolder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check check v0.6.5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageScript.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageScript;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.ListBox lboxShowFiles;
        private System.Windows.Forms.Button btnListFolder;
        private System.Windows.Forms.ComboBox comboListFiles;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnCheckActor;
        private System.Windows.Forms.Label lblFileChosen;
        private System.Windows.Forms.Label lblChosenEpisodeFrontpage;
        private System.Windows.Forms.Button btnCheckAllEps;
        private System.Windows.Forms.Label lblTotalNumLines;
        private System.Windows.Forms.Label lblScanMessage;
        private System.Windows.Forms.CheckBox chckPlakat;
        private System.Windows.Forms.CheckBox chckIntro;
        private System.Windows.Forms.Button btnRescanFolder;
    }
}

