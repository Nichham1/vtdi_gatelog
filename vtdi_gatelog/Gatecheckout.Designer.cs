namespace vtdi_gatelog
{
    partial class Gatecheckout
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
            this.components = new System.ComponentModel.Container();
            this.Btcancel = new System.Windows.Forms.Button();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.Dtpcheckout = new System.Windows.Forms.DateTimePicker();
            this.TBFirstname = new System.Windows.Forms.TextBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TbLicense = new System.Windows.Forms.TextBox();
            this.Rbcheckout = new System.Windows.Forms.RadioButton();
            this.LbFirstname = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbVehicleType = new System.Windows.Forms.Label();
            this.LbPlateNumber = new System.Windows.Forms.Label();
            this.LbPurpose = new System.Windows.Forms.Label();
            this.CBVehicleType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPurpose = new System.Windows.Forms.ComboBox();
            this.purposeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtodeclearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vtdi_gatelog_dbDataSet1 = new vtdi_gatelog.vtdi_gatelog_dbDataSet1();
            this.itemtodeclearTableAdapter = new vtdi_gatelog.vtdi_gatelog_dbDataSet1TableAdapters.ItemtodeclearTableAdapter();
            this.CbItemstodeclare = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtodeclearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btcancel
            // 
            this.Btcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btcancel.Location = new System.Drawing.Point(262, 282);
            this.Btcancel.Name = "Btcancel";
            this.Btcancel.Size = new System.Drawing.Size(75, 23);
            this.Btcancel.TabIndex = 0;
            this.Btcancel.Text = "Cancel";
            this.Btcancel.UseVisualStyleBackColor = true;
            // 
            // BtSubmit
            // 
            this.BtSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSubmit.Location = new System.Drawing.Point(126, 282);
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
            this.Dtpcheckout.Location = new System.Drawing.Point(198, 213);
            this.Dtpcheckout.Name = "Dtpcheckout";
            this.Dtpcheckout.Size = new System.Drawing.Size(200, 20);
            this.Dtpcheckout.TabIndex = 1;
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
            this.TbLicense.Location = new System.Drawing.Point(3, 139);
            this.TbLicense.Name = "TbLicense";
            this.TbLicense.Size = new System.Drawing.Size(202, 20);
            this.TbLicense.TabIndex = 2;
            // 
            // Rbcheckout
            // 
            this.Rbcheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbcheckout.AutoSize = true;
            this.Rbcheckout.Location = new System.Drawing.Point(98, 217);
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
            this.CBPurpose.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purposeBindingSource1, "Id", true));
            this.CBPurpose.DataSource = this.purposeBindingSource1;
            this.CBPurpose.DisplayMember = "Name";
            this.CBPurpose.FormattingEnabled = true;
            this.CBPurpose.Location = new System.Drawing.Point(240, 86);
            this.CBPurpose.Name = "CBPurpose";
            this.CBPurpose.Size = new System.Drawing.Size(215, 21);
            this.CBPurpose.TabIndex = 8;
            this.CBPurpose.ValueMember = "Id";
            // 
            // purposeBindingSource1
            // 
            this.purposeBindingSource1.DataMember = "purpose";
            // 
            // itemtodeclearBindingSource
            // 
            this.itemtodeclearBindingSource.DataMember = "Itemtodeclear";
            this.itemtodeclearBindingSource.DataSource = this.vtdi_gatelog_dbDataSet1;
            // 
            // vtdi_gatelog_dbDataSet1
            // 
            this.vtdi_gatelog_dbDataSet1.DataSetName = "vtdi_gatelog_dbDataSet1";
            this.vtdi_gatelog_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtodeclearTableAdapter
            // 
            this.itemtodeclearTableAdapter.ClearBeforeFill = true;
            // 
            // CbItemstodeclare
            // 
            this.CbItemstodeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbItemstodeclare.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemtodeclearBindingSource, "Id", true));
            this.CbItemstodeclare.DataSource = this.itemtodeclearBindingSource;
            this.CbItemstodeclare.DisplayMember = "Name";
            this.CbItemstodeclare.FormattingEnabled = true;
            this.CbItemstodeclare.Location = new System.Drawing.Point(240, 138);
            this.CbItemstodeclare.Name = "CbItemstodeclare";
            this.CbItemstodeclare.Size = new System.Drawing.Size(215, 21);
            this.CbItemstodeclare.TabIndex = 8;
            this.CbItemstodeclare.ValueMember = "Id";
            this.CbItemstodeclare.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Gatecheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.CbItemstodeclare);
            this.Controls.Add(this.CBPurpose);
            this.Controls.Add(this.CBVehicleType);
            this.Controls.Add(this.LbPlateNumber);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPurpose);
            this.Controls.Add(this.LbVehicleType);
            this.Controls.Add(this.LbFirstname);
            this.Controls.Add(this.Rbcheckout);
            this.Controls.Add(this.TbLicense);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.TBFirstname);
            this.Controls.Add(this.Dtpcheckout);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.Btcancel);
            this.Name = "Gatecheckout";
            this.Text = "Gatecheck";
            this.Load += new System.EventHandler(this.Gatecheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtodeclearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btcancel;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.DateTimePicker Dtpcheckout;
        private System.Windows.Forms.TextBox TBFirstname;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TbLicense;
        private System.Windows.Forms.RadioButton Rbcheckout;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbVehicleType;
        private System.Windows.Forms.Label LbPlateNumber;
        private System.Windows.Forms.Label LbPurpose;
        private System.Windows.Forms.Label LbFirstname;
        private System.Windows.Forms.ComboBox CBVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPurpose;
        private System.Windows.Forms.BindingSource purposeBindingSource;
      //  private vtdi_gatelog_dbDataSet vtdi_gatelog_dbDataSet;
        private System.Windows.Forms.BindingSource purposeBindingSource1;
      //  private vtdi_gatelog_dbDataSetTableAdapters.purposeTableAdapter purposeTableAdapter;
        private vtdi_gatelog_dbDataSet1 vtdi_gatelog_dbDataSet1;
        private System.Windows.Forms.BindingSource itemtodeclearBindingSource;
        private vtdi_gatelog_dbDataSet1TableAdapters.ItemtodeclearTableAdapter itemtodeclearTableAdapter;
        private System.Windows.Forms.ComboBox CbItemstodeclare;
    }
}