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
    public partial class LogInForm : Form  {

        int num1;
        int num2;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void Btlogin_Click(object sender, EventArgs e)
        {
            
            num2 = int.Parse(TBcaptcha.Text);


            if (num1 != num2){

                Lbmessage.Text = ("You are a robot");
            }else{
                Lbmessage.Text = ("You are Not a robot");

            }
        }

        private void Btreset_Click(object sender, EventArgs e)
        {

            Random rnd1 = new Random();
            num1 = rnd1.Next(5786, 98874);
            Tbcaptchadis.Text = num1.ToString();

        }
    }
}
