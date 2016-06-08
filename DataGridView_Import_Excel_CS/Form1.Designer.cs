namespace DataGrPidView_Import_Excel
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
            DataGrPidView_Import_Excel.Properties.Settings settings1 = new DataGrPidView_Import_Excel.Properties.Settings();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.btnCheckActor = new System.Windows.Forms.Button();
            this.lblActorInfo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblChosenDubber = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnScanFolder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.comboListFiles = new System.Windows.Forms.ComboBox();
            this.lboxShowFiles = new System.Windows.Forms.ListBox();
            this.btnListFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.btnSelect.Size = new System.Drawing.Size(192, 29);
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
            this.txtActorName.Size = new System.Drawing.Size(191, 26);
            this.txtActorName.TabIndex = 7;
            this.txtActorName.TextChanged += new System.EventHandler(this.txtActorName_TextChanged);
            // 
            // btnCheckActor
            // 
            this.btnCheckActor.Enabled = false;
            this.btnCheckActor.Location = new System.Drawing.Point(221, 41);
            this.btnCheckActor.Name = "btnCheckActor";
            this.btnCheckActor.Size = new System.Drawing.Size(133, 26);
            this.btnCheckActor.TabIndex = 8;
            this.btnCheckActor.Text = "Sjekk døbber";
            this.btnCheckActor.UseVisualStyleBackColor = true;
            this.btnCheckActor.Click += new System.EventHandler(this.btnCheckActor_Click);
            // 
            // lblActorInfo
            // 
            this.lblActorInfo.AutoSize = true;
            this.lblActorInfo.Location = new System.Drawing.Point(20, 92);
            this.lblActorInfo.Name = "lblActorInfo";
            this.lblActorInfo.Size = new System.Drawing.Size(73, 13);
            this.lblActorInfo.TabIndex = 9;
            this.lblActorInfo.Text = "Valgt dubber: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 114);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 151);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1152, 550);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(116, 92);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 20;
            // 
            // lblChosenDubber
            // 
            this.lblChosenDubber.AutoSize = true;
            this.lblChosenDubber.Location = new System.Drawing.Point(100, 92);
            this.lblChosenDubber.Name = "lblChosenDubber";
            this.lblChosenDubber.Size = new System.Drawing.Size(98, 13);
            this.lblChosenDubber.TabIndex = 21;
            this.lblChosenDubber.Text = "Hvem vil du velge?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 730);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnScanFolder);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.lblChosenDubber);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.txtActorName);
            this.tabPage1.Controls.Add(this.lblActorInfo);
            this.tabPage1.Controls.Add(this.btnCheckActor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage1.Size = new System.Drawing.Size(1172, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoved";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnScanFolder
            // 
            this.btnScanFolder.Location = new System.Drawing.Point(361, 41);
            this.btnScanFolder.Name = "btnScanFolder";
            this.btnScanFolder.Size = new System.Drawing.Size(133, 26);
            this.btnScanFolder.TabIndex = 22;
            this.btnScanFolder.Text = "Scan folder";
            this.btnScanFolder.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1172, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manusforside";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.propertyGrid1);
            settings1.FileOpenPath = "@\"C:\\dubtool\"";
            settings1.MainWindowLocation = new System.Drawing.Point(4, 22);
            settings1.SettingsKey = "";
            this.tabPage3.DataBindings.Add(new System.Windows.Forms.Binding("Location", settings1, "MainWindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage3.Location = settings1.MainWindowLocation;
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1172, 704);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(253, 130);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnChooseFile);
            this.tabPage4.Controls.Add(this.comboListFiles);
            this.tabPage4.Controls.Add(this.lboxShowFiles);
            this.tabPage4.Controls.Add(this.btnListFolder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1172, 704);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sjekk mappe";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(669, 3);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Velg fil";
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
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check check v0.4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.Label lblActorInfo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblChosenDubber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnScanFolder;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lboxShowFiles;
        private System.Windows.Forms.Button btnListFolder;
        private System.Windows.Forms.ComboBox comboListFiles;
        private System.Windows.Forms.Button btnChooseFile;
        public System.Windows.Forms.Button btnCheckActor;
    }
}

