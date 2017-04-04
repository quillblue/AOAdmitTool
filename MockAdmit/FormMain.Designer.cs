namespace FudanAdmission.MockAdmit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textApplierFilePath = new System.Windows.Forms.TextBox();
            this.textMajorFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectApplierFile = new System.Windows.Forms.Button();
            this.btnSelectMajorPlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.applierGrid = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinorScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ScoreForAdmitting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMajorForAdmitting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.majorGrid = new System.Windows.Forms.DataGridView();
            this.MajorSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainedCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnStartAdmission = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbScoreGap1 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap2 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap3 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap4 = new System.Windows.Forms.NumericUpDown();
            this.tbScoreGap5 = new System.Windows.Forms.NumericUpDown();
            this.subjectGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplierCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRefreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.applierGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreGap5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textApplierFilePath
            // 
            this.textApplierFilePath.BackColor = System.Drawing.Color.White;
            this.textApplierFilePath.Enabled = false;
            this.textApplierFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApplierFilePath.Location = new System.Drawing.Point(104, 24);
            this.textApplierFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textApplierFilePath.Name = "textApplierFilePath";
            this.textApplierFilePath.ReadOnly = true;
            this.textApplierFilePath.Size = new System.Drawing.Size(590, 25);
            this.textApplierFilePath.TabIndex = 0;
            // 
            // textMajorFilePath
            // 
            this.textMajorFilePath.BackColor = System.Drawing.Color.White;
            this.textMajorFilePath.Enabled = false;
            this.textMajorFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMajorFilePath.Location = new System.Drawing.Point(104, 56);
            this.textMajorFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textMajorFilePath.Name = "textMajorFilePath";
            this.textMajorFilePath.ReadOnly = true;
            this.textMajorFilePath.Size = new System.Drawing.Size(590, 25);
            this.textMajorFilePath.TabIndex = 1;
            // 
            // btnSelectApplierFile
            // 
            this.btnSelectApplierFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectApplierFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectApplierFile.Location = new System.Drawing.Point(702, 23);
            this.btnSelectApplierFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectApplierFile.Name = "btnSelectApplierFile";
            this.btnSelectApplierFile.Size = new System.Drawing.Size(64, 28);
            this.btnSelectApplierFile.TabIndex = 2;
            this.btnSelectApplierFile.Text = "选择";
            this.btnSelectApplierFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectApplierFile.UseVisualStyleBackColor = true;
            this.btnSelectApplierFile.Click += new System.EventHandler(this.btnSelectApplierFile_Click);
            // 
            // btnSelectMajorPlan
            // 
            this.btnSelectMajorPlan.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectMajorPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectMajorPlan.Location = new System.Drawing.Point(702, 57);
            this.btnSelectMajorPlan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectMajorPlan.Name = "btnSelectMajorPlan";
            this.btnSelectMajorPlan.Size = new System.Drawing.Size(64, 28);
            this.btnSelectMajorPlan.TabIndex = 3;
            this.btnSelectMajorPlan.Text = "选择";
            this.btnSelectMajorPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectMajorPlan.UseVisualStyleBackColor = true;
            this.btnSelectMajorPlan.Click += new System.EventHandler(this.btnSelectMajorPlan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
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
            this.MinorScore,
            this.PreferedMajor1,
            this.PreferedMajor2,
            this.PreferedMajor3,
            this.PreferedMajor4,
            this.PreferedMajor5,
            this.PreferedMajor6,
            this.AcceptChange,
            this.Admitted,
            this.AdmittedMajor,
            this.AdmittedMajorSource,
            this.ScoreForAdmitting,
            this.CurrentMajorForAdmitting});
            this.applierGrid.Location = new System.Drawing.Point(16, 183);
            this.applierGrid.Margin = new System.Windows.Forms.Padding(4);
            this.applierGrid.Name = "applierGrid";
            this.applierGrid.RowHeadersWidth = 5;
            this.applierGrid.Size = new System.Drawing.Size(936, 673);
            this.applierGrid.TabIndex = 6;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.Frozen = true;
            this.Subject.HeaderText = "科类";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 65;
            // 
            // RegisterNumber
            // 
            this.RegisterNumber.DataPropertyName = "RegisterNumber";
            this.RegisterNumber.Frozen = true;
            this.RegisterNumber.HeaderText = "报名号";
            this.RegisterNumber.Name = "RegisterNumber";
            this.RegisterNumber.ReadOnly = true;
            this.RegisterNumber.Width = 79;
            // 
            // ApplierName
            // 
            this.ApplierName.DataPropertyName = "Name";
            this.ApplierName.Frozen = true;
            this.ApplierName.HeaderText = "姓名";
            this.ApplierName.Name = "ApplierName";
            this.ApplierName.ReadOnly = true;
            this.ApplierName.Width = 65;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.Frozen = true;
            this.Score.HeaderText = "总分";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 65;
            // 
            // MinorScore
            // 
            this.MinorScore.DataPropertyName = "MinorScore";
            this.MinorScore.HeaderText = "小分";
            this.MinorScore.Name = "MinorScore";
            this.MinorScore.Width = 65;
            // 
            // PreferedMajor1
            // 
            this.PreferedMajor1.DataPropertyName = "PreferedMajor1";
            this.PreferedMajor1.HeaderText = "志愿1";
            this.PreferedMajor1.Name = "PreferedMajor1";
            this.PreferedMajor1.ReadOnly = true;
            this.PreferedMajor1.Width = 73;
            // 
            // PreferedMajor2
            // 
            this.PreferedMajor2.DataPropertyName = "PreferedMajor2";
            this.PreferedMajor2.HeaderText = "志愿2";
            this.PreferedMajor2.Name = "PreferedMajor2";
            this.PreferedMajor2.ReadOnly = true;
            this.PreferedMajor2.Width = 73;
            // 
            // PreferedMajor3
            // 
            this.PreferedMajor3.DataPropertyName = "PreferedMajor3";
            this.PreferedMajor3.HeaderText = "志愿3";
            this.PreferedMajor3.Name = "PreferedMajor3";
            this.PreferedMajor3.ReadOnly = true;
            this.PreferedMajor3.Width = 73;
            // 
            // PreferedMajor4
            // 
            this.PreferedMajor4.DataPropertyName = "PreferedMajor4";
            this.PreferedMajor4.HeaderText = "志愿4";
            this.PreferedMajor4.Name = "PreferedMajor4";
            this.PreferedMajor4.ReadOnly = true;
            this.PreferedMajor4.Width = 73;
            // 
            // PreferedMajor5
            // 
            this.PreferedMajor5.DataPropertyName = "PreferedMajor5";
            this.PreferedMajor5.HeaderText = "志愿5";
            this.PreferedMajor5.Name = "PreferedMajor5";
            this.PreferedMajor5.ReadOnly = true;
            this.PreferedMajor5.Width = 73;
            // 
            // PreferedMajor6
            // 
            this.PreferedMajor6.DataPropertyName = "PreferedMajor6";
            this.PreferedMajor6.HeaderText = "志愿6";
            this.PreferedMajor6.Name = "PreferedMajor6";
            this.PreferedMajor6.ReadOnly = true;
            this.PreferedMajor6.Width = 73;
            // 
            // AcceptChange
            // 
            this.AcceptChange.DataPropertyName = "AcceptChange";
            this.AcceptChange.FalseValue = "";
            this.AcceptChange.HeaderText = "接受调剂";
            this.AcceptChange.Name = "AcceptChange";
            this.AcceptChange.ReadOnly = true;
            this.AcceptChange.TrueValue = "";
            this.AcceptChange.Width = 70;
            // 
            // Admitted
            // 
            this.Admitted.DataPropertyName = "Admitted";
            this.Admitted.HeaderText = "录取?";
            this.Admitted.Name = "Admitted";
            this.Admitted.ReadOnly = true;
            this.Admitted.TrueValue = "是";
            this.Admitted.Width = 50;
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
            this.AdmittedMajor.Width = 70;
            // 
            // AdmittedMajorSource
            // 
            this.AdmittedMajorSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdmittedMajorSource.DataPropertyName = "AdmittedMajorSource";
            this.AdmittedMajorSource.HeaderText = "志愿来源";
            this.AdmittedMajorSource.Name = "AdmittedMajorSource";
            this.AdmittedMajorSource.ReadOnly = true;
            this.AdmittedMajorSource.Width = 93;
            // 
            // ScoreForAdmitting
            // 
            this.ScoreForAdmitting.DataPropertyName = "ScoreForAdmitting";
            this.ScoreForAdmitting.HeaderText = "投档分";
            this.ScoreForAdmitting.Name = "ScoreForAdmitting";
            this.ScoreForAdmitting.ReadOnly = true;
            this.ScoreForAdmitting.Width = 79;
            // 
            // CurrentMajorForAdmitting
            // 
            this.CurrentMajorForAdmitting.DataPropertyName = "CurrentMajorForAdmitting";
            this.CurrentMajorForAdmitting.HeaderText = "CurrentMajorForAdmitting";
            this.CurrentMajorForAdmitting.Name = "CurrentMajorForAdmitting";
            this.CurrentMajorForAdmitting.ReadOnly = true;
            this.CurrentMajorForAdmitting.Visible = false;
            this.CurrentMajorForAdmitting.Width = 198;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
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
            this.majorGrid.Location = new System.Drawing.Point(973, 183);
            this.majorGrid.Margin = new System.Windows.Forms.Padding(4);
            this.majorGrid.Name = "majorGrid";
            this.majorGrid.RowHeadersWidth = 5;
            this.majorGrid.Size = new System.Drawing.Size(355, 670);
            this.majorGrid.TabIndex = 8;
            this.majorGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.majorGrid_CellEndEdit);
            // 
            // MajorSubject
            // 
            this.MajorSubject.DataPropertyName = "Subject";
            this.MajorSubject.Frozen = true;
            this.MajorSubject.HeaderText = "科类";
            this.MajorSubject.Name = "MajorSubject";
            this.MajorSubject.ReadOnly = true;
            this.MajorSubject.Width = 65;
            // 
            // MajorName
            // 
            this.MajorName.DataPropertyName = "Name";
            this.MajorName.Frozen = true;
            this.MajorName.HeaderText = "名称";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            this.MajorName.Width = 65;
            // 
            // RemainedCapacity
            // 
            this.RemainedCapacity.DataPropertyName = "RemainedCapacity";
            this.RemainedCapacity.HeaderText = "剩余";
            this.RemainedCapacity.Name = "RemainedCapacity";
            this.RemainedCapacity.ReadOnly = true;
            this.RemainedCapacity.Width = 65;
            // 
            // PlannedCount
            // 
            this.PlannedCount.DataPropertyName = "PlannedCapacity";
            this.PlannedCount.HeaderText = "计划";
            this.PlannedCount.Name = "PlannedCount";
            this.PlannedCount.Width = 65;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(104, 136);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(662, 25);
            this.textBoxStatus.TabIndex = 10;
            // 
            // btnStartAdmission
            // 
            this.btnStartAdmission.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAdmission.Location = new System.Drawing.Point(1184, 25);
            this.btnStartAdmission.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAdmission.Name = "btnStartAdmission";
            this.btnStartAdmission.Size = new System.Drawing.Size(144, 84);
            this.btnStartAdmission.TabIndex = 11;
            this.btnStartAdmission.Text = "开始投档";
            this.btnStartAdmission.UseVisualStyleBackColor = true;
            this.btnStartAdmission.Click += new System.EventHandler(this.btnStartAdmission_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1184, 116);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 45);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "重置结果";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "当前状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "专业极差";
            // 
            // tbScoreGap1
            // 
            this.tbScoreGap1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap1.Location = new System.Drawing.Point(104, 92);
            this.tbScoreGap1.Margin = new System.Windows.Forms.Padding(4);
            this.tbScoreGap1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap1.Name = "tbScoreGap1";
            this.tbScoreGap1.Size = new System.Drawing.Size(67, 31);
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
            this.tbScoreGap2.Location = new System.Drawing.Point(179, 92);
            this.tbScoreGap2.Margin = new System.Windows.Forms.Padding(4);
            this.tbScoreGap2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap2.Name = "tbScoreGap2";
            this.tbScoreGap2.Size = new System.Drawing.Size(67, 31);
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
            this.tbScoreGap3.Location = new System.Drawing.Point(253, 92);
            this.tbScoreGap3.Margin = new System.Windows.Forms.Padding(4);
            this.tbScoreGap3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap3.Name = "tbScoreGap3";
            this.tbScoreGap3.Size = new System.Drawing.Size(67, 31);
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
            this.tbScoreGap4.Location = new System.Drawing.Point(328, 93);
            this.tbScoreGap4.Margin = new System.Windows.Forms.Padding(4);
            this.tbScoreGap4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap4.Name = "tbScoreGap4";
            this.tbScoreGap4.Size = new System.Drawing.Size(67, 31);
            this.tbScoreGap4.TabIndex = 30;
            this.tbScoreGap4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScoreGap5
            // 
            this.tbScoreGap5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreGap5.Location = new System.Drawing.Point(403, 93);
            this.tbScoreGap5.Margin = new System.Windows.Forms.Padding(4);
            this.tbScoreGap5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbScoreGap5.Name = "tbScoreGap5";
            this.tbScoreGap5.Size = new System.Drawing.Size(67, 31);
            this.tbScoreGap5.TabIndex = 31;
            this.tbScoreGap5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subjectGrid
            // 
            this.subjectGrid.AllowUserToAddRows = false;
            this.subjectGrid.AllowUserToDeleteRows = false;
            this.subjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.subjectGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.subjectGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.subjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ApplierCount,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.subjectGrid.Location = new System.Drawing.Point(786, 25);
            this.subjectGrid.Margin = new System.Windows.Forms.Padding(4);
            this.subjectGrid.Name = "subjectGrid";
            this.subjectGrid.RowHeadersWidth = 5;
            this.subjectGrid.Size = new System.Drawing.Size(390, 133);
            this.subjectGrid.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "科类";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // ApplierCount
            // 
            this.ApplierCount.DataPropertyName = "ApplierCount";
            this.ApplierCount.HeaderText = "考生数";
            this.ApplierCount.Name = "ApplierCount";
            this.ApplierCount.ReadOnly = true;
            this.ApplierCount.Width = 79;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MajorPlanCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "总计划";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlannedAdmissionCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "拟录取";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 79;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActualAdmissionCount";
            this.dataGridViewTextBoxColumn4.HeaderText = "实录取";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // GridRefreshTimer
            // 
            this.GridRefreshTimer.Interval = 2000;
            this.GridRefreshTimer.Tick += new System.EventHandler(this.GridRefreshTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 892);
            this.Controls.Add(this.subjectGrid);
            this.Controls.Add(this.tbScoreGap5);
            this.Controls.Add(this.tbScoreGap4);
            this.Controls.Add(this.tbScoreGap3);
            this.Controls.Add(this.tbScoreGap2);
            this.Controls.Add(this.tbScoreGap1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartAdmission);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.majorGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applierGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectMajorPlan);
            this.Controls.Add(this.btnSelectApplierFile);
            this.Controls.Add(this.textMajorFilePath);
            this.Controls.Add(this.textApplierFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textApplierFilePath;
        private System.Windows.Forms.TextBox textMajorFilePath;
        private System.Windows.Forms.Button btnSelectApplierFile;
        private System.Windows.Forms.Button btnSelectMajorPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView applierGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView majorGrid;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btnStartAdmission;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainedCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown tbScoreGap1;
        private System.Windows.Forms.NumericUpDown tbScoreGap2;
        private System.Windows.Forms.NumericUpDown tbScoreGap3;
        private System.Windows.Forms.NumericUpDown tbScoreGap4;
        private System.Windows.Forms.NumericUpDown tbScoreGap5;
        private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplierCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinorScore;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreForAdmitting;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMajorForAdmitting;
        private System.Windows.Forms.Timer GridRefreshTimer;
    }
}

