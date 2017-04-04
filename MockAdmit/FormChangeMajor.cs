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
    public partial class FormChangeMajor : Form
    {
        public Major selectedMajor;
        private IEnumerable<Major> avaliableMajorList;
        private Applier applier;

        public FormChangeMajor(Applier applier, IEnumerable<Major> avaliableMajorList, List<String> similarApplierAdmittedMajors = null)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.avaliableMajorList = avaliableMajorList;
            this.applier = applier;
            labelName.Text = applier.Name;
            labelSubject.Text = applier.Subject;
            labelOriginalPrefer.Text = String.Join(",",applier.PreferedMajor.Where(m=>m!=""));
            lblMajorReference.Text = String.Join(",", similarApplierAdmittedMajors.Where(m => m != ""));
            avaliableMajorList = avaliableMajorList.Where(m => m.Subject == applier.Subject).OrderByDescending(m => m.RemainedCapacity).Union(avaliableMajorList.Where(m => m.Subject != applier.Subject).OrderBy(m => m.Subject).ThenByDescending(m => m.RemainedCapacity));

            comboBoxChangedMajor.DataSource = avaliableMajorList.Select(m=>new { value=m.Name, display=String.Format("[{0}]{1}(剩余计划:{2})",m.Subject,m.Name,m.RemainedCapacity)}).ToList();
            comboBoxChangedMajor.ValueMember = "value";
            comboBoxChangedMajor.DisplayMember = "display";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            selectedMajor = avaliableMajorList.First(m => m.Name == comboBoxChangedMajor.SelectedValue.ToString() && applier.Subject == m.Subject);
            if (selectedMajor == null)
            {
                selectedMajor = avaliableMajorList.First(m => m.Name == comboBoxChangedMajor.SelectedValue.ToString());
            }

            if (selectedMajor.RemainedCapacity <= 0)
            {
                if (MessageBox.Show("所选的调剂专业计划已不足，是否确实要为考生调剂到此专业？", "提示", MessageBoxButtons.YesNo) == DialogResult.No) {
                    return;
                }
            }

            if (selectedMajor.Subject != applier.Subject)
            {
                if (MessageBox.Show("所选的调剂专业科类与考生报考科类不一致，是否确实要为考生调剂到此专业？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("中断投档过程将丢失之前的投档结果，是否继续？", "确认中断投档", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
