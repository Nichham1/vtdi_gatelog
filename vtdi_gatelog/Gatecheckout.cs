﻿using System;
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
    public partial class Gatecheckout : Form
    {
        public Gatecheckout()
        {
            InitializeComponent();
        }
       

        private void BtSubmit_Click(object sender, EventArgs e)
        {

            var Firstname = TBFirstname.Text;
            var Lastname = TBlastname.Text;
            var License = TbLicense.Text;
            var Carmodel = CBVehicleType.SelectedValue;
            var purposeOfvisit = CBPurpose.SelectedValue;
            var itemde = CbItemstodeclare.SelectedValue;
            
            Boolean Checkout = Rbcheckout.Checked;
            
            DateTime CheckOudate = Dtpcheckout.Value;

            if (String.IsNullOrEmpty(Lastname) || String.IsNullOrEmpty(License))
            {
                MessageBox.Show("Please do not leave the Lastname or License empty");
            }
            else { MessageBox.Show("Wasnt that easy"); }

}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gatecheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet1.Itemtodeclear' table. You can move, or remove it, as needed.
            this.itemtodeclearTableAdapter.Fill(this.vtdi_gatelog_dbDataSet1.Itemtodeclear);
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet.purpose' table. You can move, or remove it, as needed.
       //     this.purposeTableAdapter.Fill(this.vtdi_gatelog_dbDataSet.purpose);

        }
    }
}
