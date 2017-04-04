using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FudanAdmission.MockAdmit
{
    public partial class FormMain : Form
    {
        private BindingList<Applier> applierList = new BindingList<Applier>();
        private BindingList<Major> majorList = new BindingList<Major>();
        private BindingList<SubjectCategory> subjectCategoryList = new BindingList<SubjectCategory>();
        private int[] scoreGap = new int[6] { 0,0,0,0,0,0};

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSelectApplierFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.xlsx;*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textApplierFilePath.Text = ofd.FileName;
                try
                {
                    applierList = new BindingList<Applier>(ExcelParser.ParseApplierFile(ofd.FileName));
                    applierGrid.DataSource = applierList;
                    IEnumerable<SubjectCategory> applierCount = applierList.GroupBy(applier => applier.Subject).Select(a => new SubjectCategory { Name = a.Key, ApplierCount = a.Count() });
                    foreach (SubjectCategory sc in applierCount) {
                        if (subjectCategoryList.Any(a => a.Name == sc.Name))
                        {
                            subjectCategoryList.First(a => a.Name == sc.Name).ApplierCount = sc.ApplierCount;
                        }
                        else {
                            subjectCategoryList.Add(sc);
                        }
                    }
                    List<String> subjectWithNoApplier = subjectCategoryList.Where(s => !applierList.Select(m => m.Subject).Contains(s.Name)).Select(s => s.Name).ToList();
                    foreach (String subject in subjectWithNoApplier)
                    {
                        if (!majorList.Any(m => m.Subject == subject))
                        {
                            subjectCategoryList.Remove(subjectCategoryList.First(s => s.Name == subject));
                        }
                    }
                    subjectGrid.DataSource = subjectCategoryList;
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    UpdateWorkingStatus(String.Format("导入考生列表失败，{0}", ex.Message), 2);
                }
            }
        }

        private void btnSelectMajorPlan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.xlsx;*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textMajorFilePath.Text = ofd.FileName;
                try
                {
                    majorList = new BindingList<Major>(ExcelParser.ParseMajorFile(ofd.FileName));
                    majorGrid.DataSource = majorList;
                    IEnumerable<SubjectCategory> majorCount = majorList.GroupBy(major => major.Subject).Select(a => new SubjectCategory { Name = a.Key, MajorPlanCount = a.Sum(m=>m.PlannedCapacity), PlannedAdmissionCount=a.Sum(m => m.PlannedCapacity) });
                    foreach (SubjectCategory sc in majorCount)
                    {
                        if (subjectCategoryList.Any(a => a.Name == sc.Name))
                        {
                            subjectCategoryList.First(a => a.Name == sc.Name).MajorPlanCount = sc.MajorPlanCount;
                            subjectCategoryList.First(a => a.Name == sc.Name).PlannedAdmissionCount = sc.PlannedAdmissionCount;
                        }
                        else
                        {
                            subjectCategoryList.Add(sc);
                        }
                    }
                    List<String> subjectWithNoMajor = subjectCategoryList.Where(s => !majorList.Select(m => m.Subject).Contains(s.Name)).Select(s=>s.Name).ToList();
                    foreach (String subject in subjectWithNoMajor)
                    {
                        if (!applierList.Any(a => a.Subject == subject)){
                            subjectCategoryList.Remove(subjectCategoryList.First(s=>s.Name==subject));
                        }
                    }
                    subjectGrid.DataSource = subjectCategoryList;
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    UpdateWorkingStatus(String.Format("导入专业列表失败，{0}", ex.Message), 2);
                }
            }
        }

        private void UpdateWorkingStatus(String text, int statusMode = 0)
        {
            textBoxStatus.Text = text;
            switch (statusMode)
            {
                case 0: textBoxStatus.BackColor = Color.White; break;
                case 1: textBoxStatus.BackColor = Color.LightGreen; break;
                case 2: textBoxStatus.BackColor = Color.LightCoral; break;
                case 3: textBoxStatus.BackColor = Color.Yellow; break;
            }
            this.Update();
        }

        private void btnStartAdmission_Click(object sender, EventArgs e)
        {
            startAdmissionInitiallize();
            IEnumerable<String> subjectList = subjectCategoryList.Select(s => s.Name);
            foreach (SubjectCategory sc in subjectCategoryList) {
                if (sc.PlannedAdmissionCount > sc.MajorPlanCount) {
                    if (MessageBox.Show("部分科类的拟录取数大于计划总数，是否继续？", "操作确认", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        admissionCleanUp();
                        resetAdmission();
                        return;
                    }
                    else { break; }
                }
            }
            try
            {
                foreach (String subject in subjectList)
                {
                    StartAdmission(subject);
                }
                UpdateWorkingStatus("全部投档完成", 1);
                admissionCleanUp();
            }
            catch (Exception ex) {
                UpdateWorkingStatus(ex.Message, 2);
                admissionCleanUp();
                resetAdmission();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAdmission();
        }

        private void startAdmissionInitiallize()
        {
            foreach (Major major in majorList)
            {
                major.RemainedCapacity = major.PlannedCapacity;
            }
            scoreGap[0] = Convert.ToInt32(tbScoreGap1.Value);
            scoreGap[1] = Convert.ToInt32(tbScoreGap2.Value);
            scoreGap[2] = Convert.ToInt32(tbScoreGap3.Value);
            scoreGap[3] = Convert.ToInt32(tbScoreGap4.Value);
            scoreGap[4] = Convert.ToInt32(tbScoreGap5.Value);
            majorGrid.DataSource = majorList;
            btnReset.Enabled = false;
            btnStartAdmission.Enabled = false;
            btnSelectApplierFile.Enabled = false;
            btnSelectMajorPlan.Enabled = false;
            subjectGrid.ReadOnly = true;
            applierGrid.ReadOnly = true;
            GridRefreshTimer.Enabled = true;
        }

        private void admissionCleanUp()
        {
            btnSelectApplierFile.Enabled = true;
            btnSelectMajorPlan.Enabled = true;
            btnReset.Enabled = true;
            btnSelectApplierFile.Enabled = true;
            btnSelectMajorPlan.Enabled = true;
            subjectGrid.ReadOnly = false;
            applierGrid.ReadOnly = false;
            GridRefreshTimer.Enabled = false;
            RefreshGrid();
        }

        private void resetAdmission() {
            foreach (Applier applier in applierList)
            {
                applier.Admitted = false;
                applier.AdmittedMajor = "";
                applier.AdmittedMajorSource = "";
                applier.CurrentMajorForAdmitting = 0;
                applier.ScoreForAdmitting = applier.Score;
            }
            foreach (Major major in majorList)
            {
                major.RemainedCapacity = major.PlannedCapacity;
            }
            foreach (SubjectCategory sc in subjectCategoryList) {
                sc.ActualAdmissionCount = 0;
            }
            btnStartAdmission.Enabled = true;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            applierGrid.Refresh();
            majorGrid.Refresh();
            subjectGrid.Refresh();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            applierGrid.Height = this.Height - 181;
            majorGrid.Height = this.Height - 181;
            applierGrid.Width = this.Width - 322;
            majorGrid.Location=new Point(applierGrid.Width + 24,majorGrid.Location.Y);
        }

        private void StartAdmission(String subject)
        {
            double lastScore = 99999;
            List<String> admittedMajorInSameScore = new List<String>();
            bool closed = false;

            SubjectCategory subjectInfo = subjectCategoryList.First(s => s.Name == subject);
            UpdateWorkingStatus(String.Format("正在进行{0}投档", subject));
            List<Applier> waitingPool = new List<Applier>(applierList.Where(a => a.Subject == subject).OrderByDescending(a => a.ScoreForAdmitting));
            List<Applier> changeMajorWaitingPool = new List<Applier>();
            while (waitingPool.Count > 0)
            {   
                //Check whether admission (include pool waiting for change major) count reaches limitation. If yes, remove all appliers who are not be able to admit.
                if (subjectInfo.ActualAdmissionCount >= subjectInfo.PlannedAdmissionCount&&!closed) {
                    waitingPool.RemoveAll(a => a.Score < lastScore || !a.AcceptChange);
                    closed = true;
                }
                if (!waitingPool.Any()) { break; }

                //Sort and get first one in waiting pool, update last score and admittedMajorInSameScore accordingly
                waitingPool.Sort();
                Applier applier = waitingPool.First();
                if (applier.ScoreForAdmitting != lastScore)
                {
                    lastScore = applier.Score;
                    admittedMajorInSameScore.Clear();
                }

                //If this applier accept major change, he/she will sure be admitted, count his/her quota here.
                if (applier.CurrentMajorForAdmitting == 0 && applier.AcceptChange) {
                    subjectInfo.ActualAdmissionCount += 1;
                }

                Major major = majorList.FirstOrDefault(m => m.Name == applier.PreferedMajor[applier.CurrentMajorForAdmitting] && m.Subject == applier.Subject);
                if (major != null)
                {
                    if (major.RemainedCapacity > 0 || admittedMajorInSameScore.Contains(major.Name))
                    {
                        applier.BeAdmittedByMajorOrder(applier.CurrentMajorForAdmitting);
                        majorList[majorList.IndexOf(major)].RemainedCapacity -= 1;
                        admittedMajorInSameScore.Add(major.Name);
                        //Count applier's quota here if he/she does not accept change
                        if (!applier.AcceptChange) { subjectInfo.ActualAdmissionCount += 1; }
                        waitingPool.Remove(applier);
                        continue;
                    }
                    else
                    {
                        applier.BeRejectedByMajorOrder(applier.CurrentMajorForAdmitting, scoreGap[applier.CurrentMajorForAdmitting]);
                        if (applier.CurrentMajorForAdmitting > applier.PreferedMajor.Length-1) {
                            if (applier.AcceptChange) { changeMajorWaitingPool.Add(applier); }
                            waitingPool.Remove(applier);
                        }
                    }
                }
                else {
                    throw new Exception(string.Format("{0}考生{1}(报名号：{2})的第{3}志愿{4}在专业列表中没有找到，{0}投档中断", subject, applier.Name, applier.RegisterNumber, applier.CurrentMajorForAdmitting + 1, applier.PreferedMajor[applier.CurrentMajorForAdmitting]));
                }
            }

            changeMajorWaitingPool=changeMajorWaitingPool.OrderByDescending(a => a.Score).ToList();
            foreach (Applier applier in changeMajorWaitingPool) {
                UpdateWorkingStatus(String.Format("请为{0}选择调剂专业", applier.Name), 3);
                FormChangeMajor frmChangeMajor = new FormChangeMajor(applier, majorList, applierList.Where(a=>Math.Abs(a.Score-applier.Score)<=1).Select(a=>a.AdmittedMajor).Distinct().ToList());
                DialogResult changeMajor = frmChangeMajor.ShowDialog();
                if (changeMajor == DialogResult.OK)
                {
                        applier.Admitted = true;
                        applier.AdmittedMajor = frmChangeMajor.selectedMajor.Name;
                        applier.AdmittedMajorSource = "调剂";
                        frmChangeMajor.selectedMajor.RemainedCapacity -= 1;
                        RefreshGrid();
                }
                else
                {
                    throw new Exception("用户中断操作。");
                }
            }
        }

        private void majorGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            IEnumerable<SubjectCategory> majorCount = majorList.GroupBy(major => major.Subject).Select(a => new SubjectCategory { Name = a.Key, MajorPlanCount = a.Sum(m => m.PlannedCapacity), PlannedAdmissionCount = a.Sum(m => m.PlannedCapacity) });
            foreach (SubjectCategory sc in majorCount)
            {
                if (subjectCategoryList.Any(a => a.Name == sc.Name))
                {
                    subjectCategoryList.First(a => a.Name == sc.Name).MajorPlanCount = sc.MajorPlanCount;
                    subjectCategoryList.First(a => a.Name == sc.Name).PlannedAdmissionCount = sc.PlannedAdmissionCount;
                }
                else
                {
                    subjectCategoryList.Add(sc);
                }
            }
            foreach (Major m in majorList) {
                m.RemainedCapacity = m.PlannedCapacity;
            }
            RefreshGrid();
        }

        private void GridRefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
