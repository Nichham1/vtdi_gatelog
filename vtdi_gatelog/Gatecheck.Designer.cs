namespace vtdi_gatelog
{
    partial class Gatecheck
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
            this.Btcancel = new System.Windows.Forms.Button();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.Dtpcheckout = new System.Windows.Forms.DateTimePicker();
            this.Dtpcheckin = new System.Windows.Forms.DateTimePicker();
            this.TBFirstname = new System.Windows.Forms.TextBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TbLicense = new System.Windows.Forms.TextBox();
            this.Rbcheckin = new System.Windows.Forms.RadioButton();
            this.Rbcheckout = new System.Windows.Forms.RadioButton();
            this.LbFirstname = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbVehicleType = new System.Windows.Forms.Label();
            this.LbPlateNumber = new System.Windows.Forms.Label();
            this.LbPurpose = new System.Windows.Forms.Label();
            this.CBVehicleType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPurpose = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btcancel
            // 
            this.Btcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btcancel.Location = new System.Drawing.Point(240, 310);
            this.Btcancel.Name = "Btcancel";
            this.Btcancel.Size = new System.Drawing.Size(75, 23);
            this.Btcancel.TabIndex = 0;
            this.Btcancel.Text = "Cancel";
            this.Btcancel.UseVisualStyleBackColor = true;
            // 
            // BtSubmit
            // 
            this.BtSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSubmit.Location = new System.Drawing.Point(104, 310);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtSubmit.TabIndex = 0;
            this.BtSubmit.Text = "Submit";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // Dtpcheckout
            // 
            this.Dtpcheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtpcheckout.Location = new System.Drawing.Point(161, 238);
            this.Dtpcheckout.Name = "Dtpcheckout";
            this.Dtpcheckout.Size = new System.Drawing.Size(200, 20);
            this.Dtpcheckout.TabIndex = 1;
            // 
            // Dtpcheckin
            // 
            this.Dtpcheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtpcheckin.Location = new System.Drawing.Point(161, 190);
            this.Dtpcheckin.Name = "Dtpcheckin";
            this.Dtpcheckin.Size = new System.Drawing.Size(200, 20);
            this.Dtpcheckin.TabIndex = 1;
            // 
            // TBFirstname
            // 
            this.TBFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBFirstname.Location = new System.Drawing.Point(4, 36);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.Size = new System.Drawing.Size(214, 20);
            this.TBFirstname.TabIndex = 2;
            // 
            // TBlastname
            // 
            this.TBlastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBlastname.Location = new System.Drawing.Point(3, 89);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(202, 20);
            this.TBlastname.TabIndex = 2;
            // 
            // TbLicense
            // 
            this.TbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLicense.Location = new System.Drawing.Point(6, 138);
            this.TbLicense.Name = "TbLicense";
            this.TbLicense.Size = new System.Drawing.Size(202, 20);
            this.TbLicense.TabIndex = 2;
            // 
            // Rbcheckin
            // 
            this.Rbcheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbcheckin.AutoSize = true;
            this.Rbcheckin.Location = new System.Drawing.Point(61, 193);
            this.Rbcheckin.Name = "Rbcheckin";
            this.Rbcheckin.Size = new System.Drawing.Size(80, 17);
            this.Rbcheckin.TabIndex = 5;
            this.Rbcheckin.TabStop = true;
            this.Rbcheckin.Text = "Checked In";
            this.Rbcheckin.UseVisualStyleBackColor = true;
            // 
            // Rbcheckout
            // 
            this.Rbcheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbcheckout.AutoSize = true;
            this.Rbcheckout.Location = new System.Drawing.Point(61, 242);
            this.Rbcheckout.Name = "Rbcheckout";
            this.Rbcheckout.Size = new System.Drawing.Size(88, 17);
            this.Rbcheckout.TabIndex = 5;
            this.Rbcheckout.TabStop = true;
            this.Rbcheckout.Text = "Checked Out";
            this.Rbcheckout.UseVisualStyleBackColor = true;
            // 
            // LbFirstname
            // 
            this.LbFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFirstname.AutoSize = true;
            this.LbFirstname.Location = new System.Drawing.Point(86, 17);
            this.LbFirstname.Name = "LbFirstname";
            this.LbFirstname.Size = new System.Drawing.Size(52, 13);
            this.LbFirstname.TabIndex = 6;
            this.LbFirstname.Text = "Firstname";
            // 
            // LbLastName
            // 
            this.LbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLastName.AutoSize = true;
            this.LbLastName.Location = new System.Drawing.Point(86, 70);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(55, 13);
            this.LbLastName.TabIndex = 6;
            this.LbLastName.Text = "LastName";
            // 
            // LbVehicleType
            // 
            this.LbVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbVehicleType.AutoSize = true;
            this.LbVehicleType.Location = new System.Drawing.Point(326, 17);
            this.LbVehicleType.Name = "LbVehicleType";
            this.LbVehicleType.Size = new System.Drawing.Size(66, 13);
            this.LbVehicleType.TabIndex = 6;
            this.LbVehicleType.Text = "VehicleType";
            // 
            // LbPlateNumber
            // 
            this.LbPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPlateNumber.AutoSize = true;
            this.LbPlateNumber.Location = new System.Drawing.Point(86, 122);
            this.LbPlateNumber.Name = "LbPlateNumber";
            this.LbPlateNumber.Size = new System.Drawing.Size(68, 13);
            this.LbPlateNumber.TabIndex = 6;
            this.LbPlateNumber.Text = "PlateNumber";
            // 
            // LbPurpose
            // 
            this.LbPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPurpose.AutoSize = true;
            this.LbPurpose.Location = new System.Drawing.Point(313, 70);
            this.LbPurpose.Name = "LbPurpose";
            this.LbPurpose.Size = new System.Drawing.Size(79, 13);
            this.LbPurpose.TabIndex = 6;
            this.LbPurpose.Text = "Purpose of visit";
            // 
            // CBVehicleType
            // 
            this.CBVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBVehicleType.FormattingEnabled = true;
            this.CBVehicleType.Items.AddRange(new object[] {
            "Hunda",
            "Toyota",
            "Hyundai",
            "Volkswagen",
            "Volvo",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Renault",
            "Porsche",
            "Peugeot ",
            "Nissan ",
            "Mitsubishi",
            "Mercedes-Benz",
            "Mazda",
            "Jeep",
            "Jaguar",
            "Ford",
            "BMW",
            "Audi"});
            this.CBVehicleType.Location = new System.Drawing.Point(241, 33);
            this.CBVehicleType.Name = "CBVehicleType";
            this.CBVehicleType.Size = new System.Drawing.Size(214, 21);
            this.CBVehicleType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Items to declare ";
            // 
            // CBPurpose
            // 
            this.CBPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBPurpose.FormattingEnabled = true;
            this.CBPurpose.Items.AddRange(new object[] {
            "Work",
            "School",
            "Meeting ",
            "Dropoff",
            "Other "});
            this.CBPurpose.Location = new System.Drawing.Point(240, 86);
            this.CBPurpose.Name = "CBPurpose";
            this.CBPurpose.Size = new System.Drawing.Size(215, 21);
            this.CBPurpose.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Computer ",
            "Machine ",
            "Gun",
            "Love me "});
            this.comboBox3.Location = new System.Drawing.Point(240, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Gatecheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.CBPurpose);
            this.Controls.Add(this.CBVehicleType);
            this.Controls.Add(this.LbPlateNumber);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPurpose);
            this.Controls.Add(this.LbVehicleType);
            this.Controls.Add(this.LbFirstname);
            this.Controls.Add(this.Rbcheckout);
            this.Controls.Add(this.Rbcheckin);
            this.Controls.Add(this.TbLicense);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.TBFirstname);
            this.Controls.Add(this.Dtpcheckin);
            this.Controls.Add(this.Dtpcheckout);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.Btcancel);
            this.Name = "Gatecheck";
            this.Text = "Gatecheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btcancel;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.DateTimePicker Dtpcheckout;
        private System.Windows.Forms.DateTimePicker Dtpcheckin;
        private System.Windows.Forms.TextBox TBFirstname;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TbLicense;
        private System.Windows.Forms.RadioButton Rbcheckin;
        private System.Windows.Forms.RadioButton Rbcheckout;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbVehicleType;
        private System.Windows.Forms.Label LbPlateNumber;
        private System.Windows.Forms.Label LbPurpose;
        private System.Windows.Forms.Label LbFirstname;
        private System.Windows.Forms.ComboBox CBVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPurpose;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}