namespace MockAdmit
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textApplierFilePath = new System.Windows.Forms.TextBox();
            this.textMajorFilePath = new System.Windows.Forms.TextBox();
            this.btnSelcectApplierFile = new System.Windows.Forms.Button();
            this.btnSelcectMajorPlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.applierGrid = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferedMajor6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptChange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Admitted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AdmittedMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmittedMajorSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.majorGrid = new System.Windows.Forms.DataGridView();
            this.MajorSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainedCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnStartAdmission = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlan1 = new System.Windows.Forms.TextBox();
            this.textBoxPlan2 = new System.Windows.Forms.TextBox();
            this.textBoxPlan3 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCurrent3 = new System.Windows.Forms.TextBox();
            this.textBoxCurrent2 = new System.Windows.Forms.TextBox();
            this.textBoxCurrent1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbScoreGap1 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap2 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap3 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap4 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap5 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.applierGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap5)).BeginInit();
            this.SuspendLayout();
            // 
            // textApplierFilePath
            // 
            this.textApplierFilePath.BackColor = System.Drawing.Color.White;
            this.textApplierFilePath.Enabled = false;
            this.textApplierFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApplierFilePath.Location = new System.Drawing.Point(78, 18);
            this.textApplierFilePath.Name = "textApplierFilePath";
            this.textApplierFilePath.ReadOnly = true;
            this.textApplierFilePath.Size = new System.Drawing.Size(454, 21);
            this.textApplierFilePath.TabIndex = 0;
            // 
            // textMajorFilePath
            // 
            this.textMajorFilePath.BackColor = System.Drawing.Color.White;
            this.textMajorFilePath.Enabled = false;
            this.textMajorFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMajorFilePath.Location = new System.Drawing.Point(78, 42);
            this.textMajorFilePath.Name = "textMajorFilePath";
            this.textMajorFilePath.ReadOnly = true;
            this.textMajorFilePath.Size = new System.Drawing.Size(454, 21);
            this.textMajorFilePath.TabIndex = 1;
            // 
            // btnSelcectApplierFile
            // 
            this.btnSelcectApplierFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelcectApplierFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelcectApplierFile.Location = new System.Drawing.Point(538, 18);
            this.btnSelcectApplierFile.Name = "btnSelcectApplierFile";
            this.btnSelcectApplierFile.Size = new System.Drawing.Size(48, 21);
            this.btnSelcectApplierFile.TabIndex = 2;
            this.btnSelcectApplierFile.Text = "选择";
            this.btnSelcectApplierFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelcectApplierFile.UseVisualStyleBackColor = true;
            this.btnSelcectApplierFile.Click += new System.EventHandler(this.btnSelcectApplierFile_Click);
            // 
            // btnSelcectMajorPlan
            // 
            this.btnSelcectMajorPlan.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelcectMajorPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelcectMajorPlan.Location = new System.Drawing.Point(538, 43);
            this.btnSelcectMajorPlan.Name = "btnSelcectMajorPlan";
            this.btnSelcectMajorPlan.Size = new System.Drawing.Size(48, 21);
            this.btnSelcectMajorPlan.TabIndex = 3;
            this.btnSelcectMajorPlan.Text = "选择";
            this.btnSelcectMajorPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelcectMajorPlan.UseVisualStyleBackColor = true;
            this.btnSelcectMajorPlan.Click += new System.EventHandler(this.btnSelcectMajorPlan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "考生列表";
            // 
            // applierGrid
            // 
            this.applierGrid.AllowUserToAddRows = false;
            this.applierGrid.AllowUserToDeleteRows = false;
            this.applierGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.applierGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.applierGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.applierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applierGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.RegisterNumber,
            this.ApplierName,
            this.Score,
            this.PreferedMajor1,
            this.PreferedMajor2,
            this.PreferedMajor3,
            this.PreferedMajor4,
            this.PreferedMajor5,
            this.PreferedMajor6,
            this.AcceptChange,
            this.Admitted,
            this.AdmittedMajor,
            this.AdmittedMajorSource});
            this.applierGrid.Location = new System.Drawing.Point(12, 137);
            this.applierGrid.Name = "applierGrid";
            this.applierGrid.ReadOnly = true;
            this.applierGrid.RowHeadersWidth = 5;
            this.applierGrid.Size = new System.Drawing.Size(702, 520);
            this.applierGrid.TabIndex = 6;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.Frozen = true;
            this.Subject.HeaderText = "科类";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 54;
            // 
            // RegisterNumber
            // 
            this.RegisterNumber.DataPropertyName = "RegisterNumber";
            this.RegisterNumber.Frozen = true;
            this.RegisterNumber.HeaderText = "报名号";
            this.RegisterNumber.Name = "RegisterNumber";
            this.RegisterNumber.ReadOnly = true;
            this.RegisterNumber.Width = 66;
            // 
            // ApplierName
            // 
            this.ApplierName.DataPropertyName = "Name";
            this.ApplierName.Frozen = true;
            this.ApplierName.HeaderText = "姓名";
            this.ApplierName.Name = "ApplierName";
            this.ApplierName.ReadOnly = true;
            this.ApplierName.Width = 54;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.Frozen = true;
            this.Score.HeaderText = "总分";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 54;
            // 
            // PreferedMajor1
            // 
            this.PreferedMajor1.DataPropertyName = "PreferedMajor1";
            this.PreferedMajor1.HeaderText = "志愿1";
            this.PreferedMajor1.Name = "PreferedMajor1";
            this.PreferedMajor1.ReadOnly = true;
            this.PreferedMajor1.Width = 60;
            // 
            // PreferedMajor2
            // 
            this.PreferedMajor2.DataPropertyName = "PreferedMajor2";
            this.PreferedMajor2.HeaderText = "志愿2";
            this.PreferedMajor2.Name = "PreferedMajor2";
            this.PreferedMajor2.ReadOnly = true;
            this.PreferedMajor2.Width = 60;
            // 
            // PreferedMajor3
            // 
            this.PreferedMajor3.DataPropertyName = "PreferedMajor3";
            this.PreferedMajor3.HeaderText = "志愿3";
            this.PreferedMajor3.Name = "PreferedMajor3";
            this.PreferedMajor3.ReadOnly = true;
            this.PreferedMajor3.Width = 60;
            // 
            // PreferedMajor4
            // 
            this.PreferedMajor4.DataPropertyName = "PreferedMajor4";
            this.PreferedMajor4.HeaderText = "志愿4";
            this.PreferedMajor4.Name = "PreferedMajor4";
            this.PreferedMajor4.ReadOnly = true;
            this.PreferedMajor4.Width = 60;
            // 
            // PreferedMajor5
            // 
            this.PreferedMajor5.DataPropertyName = "PreferedMajor5";
            this.PreferedMajor5.HeaderText = "志愿5";
            this.PreferedMajor5.Name = "PreferedMajor5";
            this.PreferedMajor5.ReadOnly = true;
            this.PreferedMajor5.Width = 60;
            // 
            // PreferedMajor6
            // 
            this.PreferedMajor6.DataPropertyName = "PreferedMajor6";
            this.PreferedMajor6.HeaderText = "志愿6";
            this.PreferedMajor6.Name = "PreferedMajor6";
            this.PreferedMajor6.ReadOnly = true;
            this.PreferedMajor6.Width = 60;
            // 
            // AcceptChange
            // 
            this.AcceptChange.DataPropertyName = "AcceptChange";
            this.AcceptChange.FalseValue = "";
            this.AcceptChange.HeaderText = "接受调剂";
            this.AcceptChange.Name = "AcceptChange";
            this.AcceptChange.ReadOnly = true;
            this.AcceptChange.TrueValue = "";
            this.AcceptChange.Width = 59;
            // 
            // Admitted
            // 
            this.Admitted.DataPropertyName = "Admitted";
            this.Admitted.HeaderText = "录取?";
            this.Admitted.Name = "Admitted";
            this.Admitted.ReadOnly = true;
            this.Admitted.TrueValue = "是";
            this.Admitted.Width = 41;
            // 
            // AdmittedMajor
            // 
            this.AdmittedMajor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdmittedMajor.DataPropertyName = "AdmittedMajor";
            this.AdmittedMajor.HeaderText = "录取专业";
            this.AdmittedMajor.Name = "AdmittedMajor";
            this.AdmittedMajor.ReadOnly = true;
            this.AdmittedMajor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AdmittedMajor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AdmittedMajor.Width = 59;
            // 
            // AdmittedMajorSource
            // 
            this.AdmittedMajorSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdmittedMajorSource.DataPropertyName = "AdmittedMajorSource";
            this.AdmittedMajorSource.HeaderText = "志愿来源";
            this.AdmittedMajorSource.Name = "AdmittedMajorSource";
            this.AdmittedMajorSource.ReadOnly = true;
            this.AdmittedMajorSource.Width = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "专业计划";
            // 
            // majorGrid
            // 
            this.majorGrid.AllowUserToAddRows = false;
            this.majorGrid.AllowUserToDeleteRows = false;
            this.majorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.majorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.majorGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.majorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.majorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MajorSubject,
            this.MajorName,
            this.RemainedCapacity,
            this.PlannedCount});
            this.majorGrid.Location = new System.Drawing.Point(730, 137);
            this.majorGrid.Name = "majorGrid";
            this.majorGrid.RowHeadersWidth = 5;
            this.majorGrid.Size = new System.Drawing.Size(266, 520);
            this.majorGrid.TabIndex = 8;
            // 
            // MajorSubject
            // 
            this.MajorSubject.DataPropertyName = "Subject";
            this.MajorSubject.Frozen = true;
            this.MajorSubject.HeaderText = "科类";
            this.MajorSubject.Name = "MajorSubject";
            this.MajorSubject.ReadOnly = true;
            this.MajorSubject.Width = 54;
            // 
            // MajorName
            // 
            this.MajorName.DataPropertyName = "Name";
            this.MajorName.Frozen = true;
            this.MajorName.HeaderText = "名称";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            this.MajorName.Width = 54;
            // 
            // RemainedCapacity
            // 
            this.RemainedCapacity.DataPropertyName = "RemainedCapacity";
            this.RemainedCapacity.HeaderText = "剩余";
            this.RemainedCapacity.Name = "RemainedCapacity";
            this.RemainedCapacity.ReadOnly = true;
            this.RemainedCapacity.Width = 54;
            // 
            // PlannedCount
            // 
            this.PlannedCount.DataPropertyName = "PlannedCapacity";
            this.PlannedCount.HeaderText = "计划";
            this.PlannedCount.Name = "PlannedCount";
            this.PlannedCount.Width = 54;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(78, 102);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(918, 21);
            this.textBoxStatus.TabIndex = 10;
            // 
            // btnStartAdmission
            // 
            this.btnStartAdmission.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAdmission.Location = new System.Drawing.Point(822, 19);
            this.btnStartAdmission.Name = "btnStartAdmission";
            this.btnStartAdmission.Size = new System.Drawing.Size(81, 72);
            this.btnStartAdmission.TabIndex = 11;
            this.btnStartAdmission.Text = "开始投档";
            this.btnStartAdmission.UseVisualStyleBackColor = true;
            this.btnStartAdmission.Click += new System.EventHandler(this.btnStartAdmission_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "文科计划";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "理科计划";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "医科计划";
            // 
            // textBoxPlan1
            // 
            this.textBoxPlan1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPlan1.Location = new System.Drawing.Point(656, 17);
            this.textBoxPlan1.MaxLength = 4;
            this.textBoxPlan1.Name = "textBoxPlan1";
            this.textBoxPlan1.Size = new System.Drawing.Size(44, 23);
            this.textBoxPlan1.TabIndex = 15;
            this.textBoxPlan1.Text = "0";
            // 
            // textBoxPlan2
            // 
            this.textBoxPlan2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPlan2.Location = new System.Drawing.Point(656, 43);
            this.textBoxPlan2.MaxLength = 4;
            this.textBoxPlan2.Name = "textBoxPlan2";
            this.textBoxPlan2.Size = new System.Drawing.Size(44, 23);
            this.textBoxPlan2.TabIndex = 16;
            this.textBoxPlan2.Text = "0";
            // 
            // textBoxPlan3
            // 
            this.textBoxPlan3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPlan3.Location = new System.Drawing.Point(656, 70);
            this.textBoxPlan3.MaxLength = 4;
            this.textBoxPlan3.Name = "textBoxPlan3";
            this.textBoxPlan3.Size = new System.Drawing.Size(44, 23);
            this.textBoxPlan3.TabIndex = 17;
            this.textBoxPlan3.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(915, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 72);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "重置结果";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(709, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "录取";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(709, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "录取";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "录取";
            // 
            // textBoxCurrent3
            // 
            this.textBoxCurrent3.BackColor = System.Drawing.Color.White;
            this.textBoxCurrent3.Enabled = false;
            this.textBoxCurrent3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCurrent3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxCurrent3.Location = new System.Drawing.Point(743, 71);
            this.textBoxCurrent3.MaxLength = 4;
            this.textBoxCurrent3.Name = "textBoxCurrent3";
            this.textBoxCurrent3.Size = new System.Drawing.Size(44, 23);
            this.textBoxCurrent3.TabIndex = 24;
            this.textBoxCurrent3.Text = "0";
            this.textBoxCurrent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrent2
            // 
            this.textBoxCurrent2.BackColor = System.Drawing.Color.White;
            this.textBoxCurrent2.Enabled = false;
            this.textBoxCurrent2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCurrent2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxCurrent2.Location = new System.Drawing.Point(743, 44);
            this.textBoxCurrent2.MaxLength = 4;
            this.textBoxCurrent2.Name = "textBoxCurrent2";
            this.textBoxCurrent2.Size = new System.Drawing.Size(44, 23);
            this.textBoxCurrent2.TabIndex = 23;
            this.textBoxCurrent2.Text = "0";
            this.textBoxCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrent1
            // 
            this.textBoxCurrent1.BackColor = System.Drawing.Color.White;
            this.textBoxCurrent1.Enabled = false;
            this.textBoxCurrent1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCurrent1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxCurrent1.Location = new System.Drawing.Point(743, 18);
            this.textBoxCurrent1.MaxLength = 4;
            this.textBoxCurrent1.Name = "textBoxCurrent1";
            this.textBoxCurrent1.Size = new System.Drawing.Size(44, 23);
            this.textBoxCurrent1.TabIndex = 22;
            this.textBoxCurrent1.Text = "0";
            this.textBoxCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "当前状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "专业极差";
            // 
            // tbScoreGap1
            // 
            this.tbScoreGap1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap1.Location = new System.Drawing.Point(78, 69);
            this.tbScoreGap1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap1.Name = "tbScoreGap1";
            this.tbScoreGap1.Size = new System.Drawing.Size(50, 26);
            this.tbScoreGap1.TabIndex = 27;
            this.tbScoreGap1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScoreGap1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbScoreGap2
            // 
            this.tbScoreGap2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap2.Location = new System.Drawing.Point(134, 69);
            this.tbScoreGap2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap2.Name = "tbScoreGap2";
            this.tbScoreGap2.Size = new System.Drawing.Size(50, 26);
            this.tbScoreGap2.TabIndex = 28;
            this.tbScoreGap2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScoreGap2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbScoreGap3
            // 
            this.tbScoreGap3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap3.Location = new System.Drawing.Point(190, 69);
            this.tbScoreGap3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap3.Name = "tbScoreGap3";
            this.tbScoreGap3.Size = new System.Drawing.Size(50, 26);
            this.tbScoreGap3.TabIndex = 29;
            this.tbScoreGap3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScoreGap3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbScoreGap4
            // 
            this.tbScoreGap4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap4.Location = new System.Drawing.Point(246, 70);
            this.tbScoreGap4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap4.Name = "tbScoreGap4";
            this.tbScoreGap4.Size = new System.Drawing.Size(50, 26);
            this.tbScoreGap4.TabIndex = 30;
            this.tbScoreGap4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScoreGap5
            // 
            this.tbScoreGap5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap5.Location = new System.Drawing.Point(302, 70);
            this.tbScoreGap5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap5.Name = "tbScoreGap5";
            this.tbScoreGap5.Size = new System.Drawing.Size(50, 26);
            this.tbScoreGap5.TabIndex = 31;
            this.tbScoreGap5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 669);
            this.Controls.Add(this.tbScoreGap5);
            this.Controls.Add(this.tbScoreGap4);
            this.Controls.Add(this.tbScoreGap3);
            this.Controls.Add(this.tbScoreGap2);
            this.Controls.Add(this.tbScoreGap1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCurrent3);
            this.Controls.Add(this.textBoxCurrent2);
            this.Controls.Add(this.textBoxCurrent1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textBoxPlan3);
            this.Controls.Add(this.textBoxPlan2);
            this.Controls.Add(this.textBoxPlan1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartAdmission);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.majorGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applierGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelcectMajorPlan);
            this.Controls.Add(this.btnSelcectApplierFile);
            this.Controls.Add(this.textMajorFilePath);
            this.Controls.Add(this.textApplierFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "复旦大学招生选拔投档工具";
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.applierGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textApplierFilePath;
        private System.Windows.Forms.TextBox textMajorFilePath;
        private System.Windows.Forms.Button btnSelcectApplierFile;
        private System.Windows.Forms.Button btnSelcectMajorPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView applierGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView majorGrid;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btnStartAdmission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlan1;
        private System.Windows.Forms.TextBox textBoxPlan2;
        private System.Windows.Forms.TextBox textBoxPlan3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainedCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCurrent3;
        private System.Windows.Forms.TextBox textBoxCurrent2;
        private System.Windows.Forms.TextBox textBoxCurrent1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferedMajor6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AcceptChange;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmittedMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmittedMajorSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown tbScoreGap1;
        private System.Windows.Forms.NumericUpDown tbScoreGap2;
        private System.Windows.Forms.NumericUpDown tbScoreGap3;
        private System.Windows.Forms.NumericUpDown tbScoreGap4;
        private System.Windows.Forms.NumericUpDown tbScoreGap5;
    }
}

