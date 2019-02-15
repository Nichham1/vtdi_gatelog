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
    public partial class GateInOut : Form
    {

       


        public GateInOut()
        {
            InitializeComponent();
        }

        private void GateInOut_Load(object sender, EventArgs e)
        {

        }

        private void BTGateSubmit_Click(object sender, EventArgs e)
        {
            var Firstname = TbFirstname.Text;
            var Lastname = TBlastname.Text;
            var License = Tbl.Text;
            var Carmodel = Tbcarmodle.Text;
            var Phonenumber = Tbphonenumber.Text;
            var purposeOfvisit = rtPurpose.Text;
            Boolean Checkin = CBcheckin.Checked;
            Boolean Checkout = CBcheckout.Checked;
            DateTime Checkindate = DtpCheckin.Value;

        }
    }
}
