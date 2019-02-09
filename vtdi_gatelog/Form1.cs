using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void GateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on Gate Reports");
        }

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();

        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on User Management");
        }

        private void SchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on Scheduling");
        }

        private void GuestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on Guest List");
        }

        private void GateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on Gate In Out");
        }

        private void UserLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on User Logs");
        }
    }
}
