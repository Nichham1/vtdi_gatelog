using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace vtdi_gatelog { 
    
    public partial class LogInForm : Form  {


        public LogInForm()
        {
            InitializeComponent();

           
        }

        private void Btlogin_Click(object sender, EventArgs e)
        {
           // var datactx = new vtdi_gatelog_dbEntities;

            var username = Tbusername.Text;
            var password = Tbpassword.Text;

            if (username== "")
            {
                //String theusername = String.Empty;

                MessageBox.Show("User Name is required");
            }
            else if (password == "")
            {
                //String thepassword = String.Empty;
                MessageBox.Show("Pass Code is required");
            }
            else
            {
                //var userCount = datactx.Users.Count(q => q.UserName == username && q.Password == password);

               // if (userCount != 1)
               // {
              //      MessageBox.Show("Invalid Credentials");
              //  }
             //   else
             //   {
            //        var parent = (Form1)this.MdiParent;
            //        parent.isloggedin = true;
            //        this.Close();
            //        //btLogin.Show();
            //        MessageBox.Show($"Welcome {username}");
            //    }

            }
           
        }

        private void Btreset_Click(object sender, EventArgs e)
        {
           Tbpassword.Clear();
            Tbusername.Clear();

        }
    }
}
