namespace vtdi_gatelog
{
    partial class GateInOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbDept = new System.Windows.Forms.TextBox();
            this.BtGateReset = new System.Windows.Forms.Button();
            this.CBcheckin = new System.Windows.Forms.CheckBox();
            this.CBcheckout = new System.Windows.Forms.CheckBox();
            this.clbDeclear = new System.Windows.Forms.CheckedListBox();
            this.rtPurpose = new System.Windows.Forms.RichTextBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TbFirstname = new System.Windows.Forms.TextBox();
            this.BTGateSubmit = new System.Windows.Forms.Button();
            this.Tbcarmodle = new System.Windows.Forms.TextBox();
            this.Tbphonenumber = new System.Windows.Forms.TextBox();
            this.Tbl = new System.Windows.Forms.TextBox();
            this.DtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.DTPcheckout = new System.Windows.Forms.DateTimePicker();
            this.Lbft = new System.Windows.Forms.Label();
            this.LBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbCmodle = new System.Windows.Forms.Label();
            this.Lbph = new System.Windows.Forms.Label();
            this.LbDept = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbDept
            // 
            this.TbDept.AcceptsTab = true;
            this.TbDept.Location = new System.Drawing.Point(329, 168);
            this.TbDept.Margin = new System.Windows.Forms.Padding(4);
            this.TbDept.Name = "TbDept";
            this.TbDept.Size = new System.Drawing.Size(186, 22);
            this.TbDept.TabIndex = 0;
            // 
            // BtGateReset
            // 
            this.BtGateReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtGateReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtGateReset.Location = new System.Drawing.Point(309, 515);
            this.BtGateReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtGateReset.Name = "BtGateReset";
            this.BtGateReset.Size = new System.Drawing.Size(88, 26);
            this.BtGateReset.TabIndex = 1;
            this.BtGateReset.Text = "Reset";
            this.BtGateReset.UseVisualStyleBackColor = true;
            // 
            // CBcheckin
            // 
            this.CBcheckin.AutoSize = true;
            this.CBcheckin.Location = new System.Drawing.Point(309, 356);
            this.CBcheckin.Margin = new System.Windows.Forms.Padding(4);
            this.CBcheckin.Name = "CBcheckin";
            this.CBcheckin.Size = new System.Drawing.Size(73, 19);
            this.CBcheckin.TabIndex = 2;
            this.CBcheckin.Text = "Check In";
            this.CBcheckin.UseVisualStyleBackColor = true;
            // 
            // CBcheckout
            // 
            this.CBcheckout.AutoSize = true;
            this.CBcheckout.Location = new System.Drawing.Point(309, 420);
            this.CBcheckout.Margin = new System.Windows.Forms.Padding(4);
            this.CBcheckout.Name = "CBcheckout";
            this.CBcheckout.Size = new System.Drawing.Size(82, 19);
            this.CBcheckout.TabIndex = 2;
            this.CBcheckout.Text = "Check Out";
            this.CBcheckout.UseVisualStyleBackColor = true;
            // 
            // clbDeclear
            // 
            this.clbDeclear.CheckOnClick = true;
            this.clbDeclear.FormattingEnabled = true;
            this.clbDeclear.Items.AddRange(new object[] {
            "Computer",
            "Gun",
            "Human Body",
            "Electronics",
            "Valuables",
            "Money in excess of $50000"});
            this.clbDeclear.Location = new System.Drawing.Point(14, 374);
            this.clbDeclear.Margin = new System.Windows.Forms.Padding(4);
            this.clbDeclear.Name = "clbDeclear";
            this.clbDeclear.Size = new System.Drawing.Size(185, 106);
            this.clbDeclear.TabIndex = 3;
            // 
            // rtPurpose
            // 
            this.rtPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtPurpose.AutoWordSelection = true;
            this.rtPurpose.Location = new System.Drawing.Point(14, 232);
            this.rtPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.rtPurpose.Name = "rtPurpose";
            this.rtPurpose.Size = new System.Drawing.Size(503, 110);
            this.rtPurpose.TabIndex = 4;
            this.rtPurpose.Text = "";
            // 
            // TBlastname
            // 
            this.TBlastname.AcceptsTab = true;
            this.TBlastname.Location = new System.Drawing.Point(329, 39);
            this.TBlastname.Margin = new System.Windows.Forms.Padding(4);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(186, 22);
            this.TBlastname.TabIndex = 0;
            this.TBlastname.WordWrap = false;
            // 
            // TbFirstname
            // 
            this.TbFirstname.AcceptsTab = true;
            this.TbFirstname.Location = new System.Drawing.Point(43, 39);
            this.TbFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.TbFirstname.Name = "TbFirstname";
            this.TbFirstname.Size = new System.Drawing.Size(215, 22);
            this.TbFirstname.TabIndex = 0;
            this.TbFirstname.WordWrap = false;
            // 
            // BTGateSubmit
            // 
            this.BTGateSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTGateSubmit.Location = new System.Drawing.Point(101, 515);
            this.BTGateSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BTGateSubmit.Name = "BTGateSubmit";
            this.BTGateSubmit.Size = new System.Drawing.Size(88, 26);
            this.BTGateSubmit.TabIndex = 1;
            this.BTGateSubmit.Text = "Submit";
            this.BTGateSubmit.UseVisualStyleBackColor = true;
            this.BTGateSubmit.Click += new System.EventHandler(this.BTGateSubmit_Click);
            // 
            // Tbcarmodle
            // 
            this.Tbcarmodle.AcceptsTab = true;
            this.Tbcarmodle.Location = new System.Drawing.Point(329, 108);
            this.Tbcarmodle.Margin = new System.Windows.Forms.Padding(4);
            this.Tbcarmodle.Name = "Tbcarmodle";
            this.Tbcarmodle.Size = new System.Drawing.Size(186, 22);
            this.Tbcarmodle.TabIndex = 0;
            this.Tbcarmodle.WordWrap = false;
            // 
            // Tbphonenumber
            // 
            this.Tbphonenumber.AcceptsTab = true;
            this.Tbphonenumber.Location = new System.Drawing.Point(43, 168);
            this.Tbphonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.Tbphonenumber.Name = "Tbphonenumber";
            this.Tbphonenumber.Size = new System.Drawing.Size(215, 22);
            this.Tbphonenumber.TabIndex = 0;
            this.Tbphonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbphonenumber.WordWrap = false;
            // 
            // Tbl
            // 
            this.Tbl.AcceptsTab = true;
            this.Tbl.Location = new System.Drawing.Point(43, 108);
            this.Tbl.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl.Name = "Tbl";
            this.Tbl.Size = new System.Drawing.Size(215, 22);
            this.Tbl.TabIndex = 0;
            this.Tbl.WordWrap = false;
            // 
            // DtpCheckin
            // 
            this.DtpCheckin.Location = new System.Drawing.Point(270, 386);
            this.DtpCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.DtpCheckin.Name = "DtpCheckin";
            this.DtpCheckin.Size = new System.Drawing.Size(232, 22);
            this.DtpCheckin.TabIndex = 5;
            // 
            // DTPcheckout
            // 
            this.DTPcheckout.Location = new System.Drawing.Point(270, 446);
            this.DTPcheckout.Margin = new System.Windows.Forms.Padding(4);
            this.DTPcheckout.MinDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.DTPcheckout.Name = "DTPcheckout";
            this.DTPcheckout.Size = new System.Drawing.Size(232, 22);
            this.DTPcheckout.TabIndex = 6;
            // 
            // Lbft
            // 
            this.Lbft.AutoSize = true;
            this.Lbft.Location = new System.Drawing.Point(113, 21);
            this.Lbft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbft.Name = "Lbft";
            this.Lbft.Size = new System.Drawing.Size(64, 15);
            this.Lbft.TabIndex = 7;
            this.Lbft.Text = "First Name";
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(98, 89);
            this.LBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(96, 15);
            this.LBL.TabIndex = 8;
            this.LBL.Text = "License Number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name ";
            // 
            // LbCmodle
            // 
            this.LbCmodle.AutoSize = true;
            this.LbCmodle.Location = new System.Drawing.Point(382, 89);
            this.LbCmodle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCmodle.Name = "LbCmodle";
            this.LbCmodle.Size = new System.Drawing.Size(60, 15);
            this.LbCmodle.TabIndex = 7;
            this.LbCmodle.Text = "Car model";
            // 
            // Lbph
            // 
            this.Lbph.AutoSize = true;
            this.Lbph.Location = new System.Drawing.Point(98, 149);
            this.Lbph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbph.Name = "Lbph";
            this.Lbph.Size = new System.Drawing.Size(89, 15);
            this.Lbph.TabIndex = 8;
            this.Lbph.Text = "Phone Number ";
            // 
            // LbDept
            // 
            this.LbDept.AutoSize = true;
            this.LbDept.Location = new System.Drawing.Point(382, 149);
            this.LbDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDept.Name = "LbDept";
            this.LbDept.Size = new System.Drawing.Size(72, 15);
            this.LbDept.TabIndex = 8;
            this.LbDept.Text = "Department ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Purpose for the visit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Things to Declear ";
            // 
            // GateInOut
            // 
            this.AcceptButton = this.BTGateSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtGateReset;
            this.ClientSize = new System.Drawing.Size(533, 555);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbDept);
            this.Controls.Add(this.Lbph);
            this.Controls.Add(this.LbCmodle);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbft);
            this.Controls.Add(this.DTPcheckout);
            this.Controls.Add(this.DtpCheckin);
            this.Controls.Add(this.rtPurpose);
            this.Controls.Add(this.clbDeclear);
            this.Controls.Add(this.CBcheckout);
            this.Controls.Add(this.CBcheckin);
            this.Controls.Add(this.BTGateSubmit);
            this.Controls.Add(this.BtGateReset);
            this.Controls.Add(this.Tbcarmodle);
            this.Controls.Add(this.TbFirstname);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.Tbl);
            this.Controls.Add(this.Tbphonenumber);
            this.Controls.Add(this.TbDept);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(533, 555);
            this.Name = "GateInOut";
            this.Text = "Gate_in_out";
            this.Load += new System.EventHandler(this.GateInOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDept;
        private System.Windows.Forms.Button BtGateReset;
        private System.Windows.Forms.CheckBox CBcheckin;
        private System.Windows.Forms.CheckBox CBcheckout;
        private System.Windows.Forms.CheckedListBox clbDeclear;
        private System.Windows.Forms.RichTextBox rtPurpose;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TbFirstname;
        private System.Windows.Forms.Button BTGateSubmit;
        private System.Windows.Forms.TextBox Tbcarmodle;
        private System.Windows.Forms.TextBox Tbphonenumber;
        private System.Windows.Forms.TextBox Tbl;
        private System.Windows.Forms.DateTimePicker DtpCheckin;
        private System.Windows.Forms.DateTimePicker DTPcheckout;
        private System.Windows.Forms.Label Lbft;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbCmodle;
        private System.Windows.Forms.Label Lbph;
        private System.Windows.Forms.Label LbDept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}