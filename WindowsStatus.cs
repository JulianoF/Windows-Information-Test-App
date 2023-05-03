using System;
using System.Windows.Forms;

namespace WindowsStatusTestAPP
{
    public partial class MainWindow : Form
    {
        systemInfo sysInf;
        public MainWindow()
        {
            InitializeComponent();
            this.sysInf = new systemInfo();
        }

        private void runButtonClick(object sender, EventArgs e)
        {
            ResultsPage frm = new ResultsPage(this,this.sysInf);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pcName_CheckedChanged(object sender, EventArgs e)
        {
            if (pcNameCheckBox.Checked)
            {
                sysInf.setName(true);
            }
            else
            {
                sysInf.setName(false);
            }
        }

        private void cpuSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (cpuSpeedCheckBox.Checked)
            {
                sysInf.setSpeed(true);
            }
            else
            {
                sysInf.setSpeed(false);
            }
        }

        private void osCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (osCheckBox.Checked)
            {
                sysInf.setVersion(true);
            }
            else
            {
                sysInf.setVersion(false);
            }
        }

        private void cpuTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ramCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cDriveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
