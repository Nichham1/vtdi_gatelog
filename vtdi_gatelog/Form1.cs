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


        public bool isloggedin = false;

        public Form1()
        {
            InitializeComponent();
        }
      
        private void GateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isloggedin)
            {
                MessageBox.Show("User clicked on Gate Reports");
            }
            else
            {
                ShowLogin();
            }
           
        }

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isloggedin)
            {
                ShowLogin();

            }
            else
            {
                MessageBox.Show("You are already logged in");
            }
           

        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin)
            {
                MessageBox.Show("User clicked on User Management");
            }
            else
            {

                ShowLogin();
            }
        }

        private void SchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin)
            {
                MessageBox.Show("User clicked on Scheduling");
            }
            else
            {

                ShowLogin();
            }
        }

        private void GuestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (isloggedin)
            {
                MessageBox.Show("User clicked on Guest List");
            }
            else
            {

                ShowLogin();
            }
        }

        private void GateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isloggedin)
            {
                Gatecheckin Gatei = new Gatecheckin();
                Gatei.MdiParent = this;
                Gatei.Show();
            }
            else
            {

                ShowLogin();
            }

           
        }

        private void UserLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked on User Logs");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowLogin()
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin)
            {
                isloggedin = false;

            }
            else
            {
                MessageBox.Show("You are not logged in");
            }

        }

        private void gateOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin)
            {
                Gatecheckout Gateo = new Gatecheckout();
                Gateo.MdiParent = this;
                Gateo.Show();
            }
            else
            {

                ShowLogin();
            }
        }
    }
}
