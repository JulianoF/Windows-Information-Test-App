using System;
using System.Windows.Forms;

namespace WindowsStatusTestAPP
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void runButtonClick(object sender, EventArgs e)
        {
            ResultsPage frm = new ResultsPage(this);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pcName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cpuSpeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void osCheckBox_CheckedChanged(object sender, EventArgs e)
        {

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
