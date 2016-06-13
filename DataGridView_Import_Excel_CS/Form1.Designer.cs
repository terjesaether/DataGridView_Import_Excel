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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.btnCheckActor = new System.Windows.Forms.Button();
            this.lblActorInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChosenDubber = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.lboxShowFiles = new System.Windows.Forms.ListBox();
            this.comboListFiles = new System.Windows.Forms.ComboBox();
            this.chckIntro = new System.Windows.Forms.CheckBox();
            this.lblScanMessage = new System.Windows.Forms.Label();
            this.lblTotalNumLines = new System.Windows.Forms.Label();
            this.btnCheckAllEps = new System.Windows.Forms.Button();
            this.lblChosenEpisodeFrontpage = new System.Windows.Forms.Label();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.btnRescanFolder = new System.Windows.Forms.Button();
            this.lblFileChosen = new System.Windows.Forms.Label();
            this.btnListFolder = new System.Windows.Forms.Button();
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
            this.btnSelect.Size = new System.Drawing.Size(191, 29);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Velg manus (åpne fil..)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtActorName
            // 
            this.txtActorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorName.Location = new System.Drawing.Point(7, 41);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(190, 26);
            this.txtActorName.TabIndex = 5;
            this.txtActorName.TextChanged += new System.EventHandler(this.txtActorName_TextChanged);
            // 
            // btnCheckActor
            // 
            this.btnCheckActor.Location = new System.Drawing.Point(203, 41);
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
            this.lblActorInfo.Location = new System.Drawing.Point(8, 75);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 121);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(963, 628);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblChosenDubber
            // 
            this.lblChosenDubber.AutoSize = true;
            this.lblChosenDubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenDubber.ForeColor = System.Drawing.Color.Red;
            this.lblChosenDubber.Location = new System.Drawing.Point(4, 91);
            this.lblChosenDubber.Name = "lblChosenDubber";
            this.lblChosenDubber.Size = new System.Drawing.Size(0, 24);
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
            this.tabPageMain.Controls.Add(this.lboxShowFiles);
            this.tabPageMain.Controls.Add(this.comboListFiles);
            this.tabPageMain.Controls.Add(this.chckIntro);
            this.tabPageMain.Controls.Add(this.lblScanMessage);
            this.tabPageMain.Controls.Add(this.lblTotalNumLines);
            this.tabPageMain.Controls.Add(this.btnCheckAllEps);
            this.tabPageMain.Controls.Add(this.lblChosenEpisodeFrontpage);
            this.tabPageMain.Controls.Add(this.flowLayoutPanel1);
            this.tabPageMain.Controls.Add(this.lblChosenDubber);
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
            // lboxShowFiles
            // 
            this.lboxShowFiles.FormattingEnabled = true;
            this.lboxShowFiles.Location = new System.Drawing.Point(7, 121);
            this.lboxShowFiles.Name = "lboxShowFiles";
            this.lboxShowFiles.Size = new System.Drawing.Size(190, 628);
            this.lboxShowFiles.TabIndex = 31;
            this.lboxShowFiles.SelectedIndexChanged += new System.EventHandler(this.lboxShowFiles_SelectedIndexChanged);
            // 
            // comboListFiles
            // 
            this.comboListFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListFiles.FormattingEnabled = true;
            this.comboListFiles.Location = new System.Drawing.Point(691, 7);
            this.comboListFiles.Name = "comboListFiles";
            this.comboListFiles.Size = new System.Drawing.Size(213, 21);
            this.comboListFiles.TabIndex = 0;
            this.comboListFiles.SelectedIndexChanged += new System.EventHandler(this.comboListFiles_SelectedIndexChanged);
            // 
            // chckIntro
            // 
            this.chckIntro.AutoSize = true;
            this.chckIntro.Checked = true;
            this.chckIntro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckIntro.Location = new System.Drawing.Point(965, 7);
            this.chckIntro.Name = "chckIntro";
            this.chckIntro.Size = new System.Drawing.Size(160, 17);
            this.chckIntro.TabIndex = 0;
            this.chckIntro.Text = "ikke vis intro / outro / plakat";
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
            this.lblTotalNumLines.Location = new System.Drawing.Point(200, 82);
            this.lblTotalNumLines.Name = "lblTotalNumLines";
            this.lblTotalNumLines.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNumLines.TabIndex = 25;
            // 
            // btnCheckAllEps
            // 
            this.btnCheckAllEps.Location = new System.Drawing.Point(409, 41);
            this.btnCheckAllEps.Name = "btnCheckAllEps";
            this.btnCheckAllEps.Size = new System.Drawing.Size(200, 26);
            this.btnCheckAllEps.TabIndex = 10;
            this.btnCheckAllEps.Text = "Sjekk døbber på alle seriene";
            this.btnCheckAllEps.UseVisualStyleBackColor = true;
            this.btnCheckAllEps.Click += new System.EventHandler(this.btnCheckAllEps_Click);
            // 
            // lblChosenEpisodeFrontpage
            // 
            this.lblChosenEpisodeFrontpage.AutoSize = true;
            this.lblChosenEpisodeFrontpage.Location = new System.Drawing.Point(200, 7);
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
            this.tabPageSelect.Controls.Add(this.btnListFolder);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 32);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(1172, 764);
            this.tabPageSelect.TabIndex = 3;
            this.tabPageSelect.Text = "Velg episoder";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // btnRescanFolder
            // 
            this.btnRescanFolder.Location = new System.Drawing.Point(958, 4);
            this.btnRescanFolder.Name = "btnRescanFolder";
            this.btnRescanFolder.Size = new System.Drawing.Size(200, 26);
            this.btnRescanFolder.TabIndex = 27;
            this.btnRescanFolder.Text = "Scan mappe  på nytt";
            this.btnRescanFolder.UseVisualStyleBackColor = true;
            this.btnRescanFolder.Click += new System.EventHandler(this.btnRescanFolder_Click_1);
            // 
            // lblFileChosen
            // 
            this.lblFileChosen.AutoSize = true;
            this.lblFileChosen.Location = new System.Drawing.Point(8, 74);
            this.lblFileChosen.Name = "lblFileChosen";
            this.lblFileChosen.Size = new System.Drawing.Size(0, 13);
            this.lblFileChosen.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check check v0.7.5";
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
        private System.Windows.Forms.Label lblChosenDubber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageScript;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.Button btnListFolder;
        private System.Windows.Forms.Button btnCheckActor;
        private System.Windows.Forms.Label lblChosenEpisodeFrontpage;
        private System.Windows.Forms.Button btnCheckAllEps;
        private System.Windows.Forms.Label lblTotalNumLines;
        private System.Windows.Forms.Label lblScanMessage;
        private System.Windows.Forms.CheckBox chckIntro;
        private System.Windows.Forms.Button btnRescanFolder;
        private System.Windows.Forms.Label lblFileChosen;
        private System.Windows.Forms.ComboBox comboListFiles;
        private System.Windows.Forms.ListBox lboxShowFiles;
    }
}

