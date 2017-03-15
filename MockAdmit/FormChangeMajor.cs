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
    public partial class FormChangeMajor : Form
    {
        public String selectedValue;

        public FormChangeMajor(Applier applier, List<Major> avaliableMajorList)
        {
            InitializeComponent();
            this.ControlBox = false;
            labelName.Text = applier.Name;
            labelSubject.Text = applier.Subject;
            labelOriginalPrefer.Text = String.Join(",",applier.PreferedMajor.Where(m=>m!=""));
            comboBoxChangedMajor.DataSource = avaliableMajorList.Select(m=>new { value=m.Name, display=String.Format("{0}(剩余计划:{1})",m.Name,m.RemainedCapacity)}).ToList();
            comboBoxChangedMajor.ValueMember = "value";
            comboBoxChangedMajor.DisplayMember = "display";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            selectedValue = comboBoxChangedMajor.SelectedValue.ToString() ;
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
