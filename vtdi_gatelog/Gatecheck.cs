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
    public partial class Gatecheck : Form
    {
        public Gatecheck()
        {
            InitializeComponent();
        }
       

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            var Firstname = TBFirstname.Text;
            var Lastname = TBlastname.Text;
            var License = TbLicense.Text;
            var Carmodel = CBVehicleType.Text;
            var purposeOfvisit = CBPurpose.Text;
            Boolean Checkin = Rbcheckin.Checked;
            Boolean Checkout = Rbcheckout.Checked;
            DateTime Checkindate = Dtpcheckin.Value;
            DateTime CheckOudate = Dtpcheckout.Value;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
