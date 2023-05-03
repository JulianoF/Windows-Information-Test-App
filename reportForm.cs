using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsStatusTestAPP
{
    public partial class ResultsPage : Form
    {
        public MainWindow main { get; set; }
        public systemInfo sysInf;
        public ResultsPage(MainWindow main, systemInfo sys)
        {
            InitializeComponent();
            this.main = main;
            this.sysInf = sys;
        }

        private void exitButtonClickEvent(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You Sure You Would like to Quit?","Exit", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes){
                this.Close();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // WIP FUNCTION -> Will Return to main Form
            // (this.main as MainWindow).Show();
            // this.Close();
            MessageBox.Show("WIP Functionality","WIP");
        }

        private void ResultsPage_Load(object sender, EventArgs e)
        {       
            outputBox.Text = sysInf.getSysInfo();
        }
    }
}
