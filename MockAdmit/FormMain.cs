using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MockAdmit
{
    public partial class FormMain : Form
    {
        private BindingList<Applier> applierList = new BindingList<Applier>();
        private BindingList<Major> majorList = new BindingList<Major>();
        private int[] plannedLimit = new int[3] { 0, 0, 0 };
        private int[] currentAdmitted = new int[3] { 0, 0, 0 };
        private int[] scoreGap = new int[5] { 0, 0, 0, 0, 0 };
        private Dictionary<String, int> subjectDict = new Dictionary<string, int>();

        public FormMain()
        {
            InitializeComponent();
            subjectDict.Add("文科", 0);
            subjectDict.Add("理科", 1);
            subjectDict.Add("医学", 2);
        }

        private void btnSelcectApplierFile_Click(object sender, EventArgs e)
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
                }
                catch (Exception ex)
                {
                    UpdateWorkingStatus(String.Format("导入考生列表失败，{0}", ex.Message), 2);
                }
            }
        }

        private void btnSelcectMajorPlan_Click(object sender, EventArgs e)
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
                    plannedLimit[0] = majorList.Where(m => m.Subject == "文科").Sum(m => m.PlannedCapacity);
                    plannedLimit[1] = majorList.Where(m => m.Subject == "理科").Sum(m => m.PlannedCapacity);
                    plannedLimit[2] = majorList.Where(m => m.Subject == "医学").Sum(m => m.PlannedCapacity);
                    textBoxPlan1.Text = plannedLimit[0].ToString();
                    textBoxPlan2.Text = plannedLimit[1].ToString();
                    textBoxPlan3.Text = plannedLimit[2].ToString();
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
            double lastScore = 0;
            List<String> admittedMajorInSameScore=new List<String>();
            foreach (String subject in subjectDict.Keys)
            {
                lastScore = 0;
                admittedMajorInSameScore.Clear();
                UpdateWorkingStatus(String.Format("正在进行{0}投档", subject));
                List<Applier> waitingPool = new List<Applier>(applierList.Where(a => a.Subject == subject).OrderByDescending(a => a.ScoreForAdmitting));
                while (waitingPool.Count > 0)
                {
                    waitingPool.Sort();
                    Applier applier = waitingPool.First();
                    if (currentAdmitted[subjectDict[applier.Subject]] >= plannedLimit[subjectDict[applier.Subject]])
                    {
                        waitingPool.RemoveAll(a => a.ScoreForAdmitting < lastScore);
                        continue;
                    }
                    if (applier.Score != lastScore)
                    {
                        lastScore = applier.Score;
                        admittedMajorInSameScore.Clear();
                    }
                    if (applier.CurrentMajorForAdmitting >5|| !String.IsNullOrWhiteSpace(applier.PreferedMajor[applier.CurrentMajorForAdmitting]))
                    {
                        Major major = majorList.FirstOrDefault(m => m.Name == applier.PreferedMajor[applier.CurrentMajorForAdmitting] && m.Subject == applier.Subject);
                        if (major != null)
                        {
                            if (major.RemainedCapacity > 0 || admittedMajorInSameScore.Contains(major.Name))
                            {
                                applier.BeAdmittedByMajorOrder(applier.CurrentMajorForAdmitting);
                                majorList[majorList.IndexOf(major)].RemainedCapacity -= 1;
                                majorGrid.DataSource = majorList;
                                currentAdmitted[subjectDict[applier.Subject]] += 1;
                                updateCurrentAdmittedCount();
                                admittedMajorInSameScore.Add(major.Name);
                                waitingPool.Remove(applier);
                                continue;
                            }
                            else
                            {
                                applier.BeRejectedByMajorOrder(applier.CurrentMajorForAdmitting, scoreGap[applier.CurrentMajorForAdmitting]);
                            }
                        }
                        else
                        {
                            UpdateWorkingStatus(String.Format("{0}考生{1}(报名号：{2})的第{3}志愿{4}在专业列表中没有找到，投档中断", subject, applier.Name, applier.RegisterNumber, applier.CurrentMajorForAdmitting + 1, applier.PreferedMajor[applier.CurrentMajorForAdmitting]), 2);
                            admissionCleanUp();
                            return;
                        }
                    }
                    else {
                        if (applier.AcceptChange)
                        {
                            UpdateWorkingStatus(String.Format("请为{0}选择调剂专业", applier.Name), 3);
                            FormChangeMajor frmChangeMajor = new FormChangeMajor(applier, majorList.Where(m => m.RemainedCapacity > 0 && m.Subject == applier.Subject).ToList());
                            DialogResult changeMajor = frmChangeMajor.ShowDialog();
                            if (changeMajor == DialogResult.OK)
                            {
                                Major major = majorList.FirstOrDefault(m => m.Name == frmChangeMajor.selectedValue && m.Subject == applier.Subject);
                                if (major != null)
                                {
                                    applier.Admitted = true;
                                    applier.AdmittedMajor = major.Name;
                                    applier.AdmittedMajorSource = "调剂";
                                    major.RemainedCapacity -= 1;
                                    majorGrid.DataSource = majorList;
                                    currentAdmitted[subjectDict[applier.Subject]] += 1;
                                    updateCurrentAdmittedCount();
                                }
                            }
                            else
                            {
                                admissionCleanUp();
                                resetAdmission();
                                UpdateWorkingStatus("用户中断操作。", 2);
                                return;
                            }
                        }
                        waitingPool.Remove(applier);
                    }
                }
            }
            UpdateWorkingStatus("全部投档完成", 1);
            admissionCleanUp();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAdmission();
        }

        private void startAdmissionInitiallize()
        {
            scoreGap[0] = Convert.ToInt32(tbScoreGap1.Value);
            scoreGap[1] = Convert.ToInt32(tbScoreGap2.Value);
            scoreGap[2] = Convert.ToInt32(tbScoreGap3.Value);
            scoreGap[3] = Convert.ToInt32(tbScoreGap4.Value);
            scoreGap[4] = Convert.ToInt32(tbScoreGap5.Value);
            plannedLimit = new int[3] { Convert.ToInt32(textBoxPlan1.Text), Convert.ToInt32(textBoxPlan2.Text), Convert.ToInt32(textBoxPlan3.Text) };
            foreach (Major major in majorList)
            {
                major.RemainedCapacity = major.PlannedCapacity;
            }
            majorGrid.DataSource = majorList;
            btnReset.Enabled = false;
            btnStartAdmission.Enabled = false;
            btnSelcectApplierFile.Enabled = false;
            btnSelcectMajorPlan.Enabled = false;
            textBoxPlan1.Enabled = false;
            textBoxPlan2.Enabled = false;
            textBoxPlan3.Enabled = false;
        }

        private void admissionCleanUp()
        {
            btnSelcectApplierFile.Enabled = true;
            btnSelcectMajorPlan.Enabled = true;
            btnReset.Enabled = true;
            btnSelcectApplierFile.Enabled = true;
            btnSelcectMajorPlan.Enabled = true;
            textBoxPlan1.Enabled = true;
            textBoxPlan2.Enabled = true;
            textBoxPlan3.Enabled = true;
        }

        private void resetAdmission() {
            foreach (Applier applier in applierList)
            {
                applier.Admitted = false;
                applier.AdmittedMajor = "";
                applier.AdmittedMajorSource = "";
            }
            foreach (Major major in majorList)
            {
                major.RemainedCapacity = major.PlannedCapacity;
            }
            btnStartAdmission.Enabled = true;
            currentAdmitted = new int[3] { 0, 0, 0 };
            updateCurrentAdmittedCount();
        }

        private void updateCurrentAdmittedCount()
        {
            textBoxCurrent1.Text = currentAdmitted[0].ToString();
            textBoxCurrent2.Text = currentAdmitted[1].ToString();
            textBoxCurrent3.Text = currentAdmitted[2].ToString();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            applierGrid.Height = this.Height - 151;
            majorGrid.Height = this.Height - 151;
            applierGrid.Width = this.Width - 322;
            majorGrid.Location=new Point(applierGrid.Width + 24,majorGrid.Location.Y);
        }

    }
}
