using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                Application.Exit();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void ResultsPage_Load(object sender, EventArgs e)
        {       
            outputBox.Text = sysInf.getSysInfo();
        }

        private void ResultsPage_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                MessageBox.Show("Closed by calling Close()");
            }
            else
            {
                MessageBox.Show("Closed by X or Alt+F4");
                Application.Exit();
            }
        }
    }
}
