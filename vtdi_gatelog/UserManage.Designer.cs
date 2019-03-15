namespace vtdi_gatelog
{
    partial class UserManage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBemailaddress = new System.Windows.Forms.TextBox();
            this.TbLastname = new System.Windows.Forms.TextBox();
            this.TbFirstname = new System.Windows.Forms.TextBox();
            this.CBgender = new System.Windows.Forms.ComboBox();
            this.LbFirstname = new System.Windows.Forms.Label();
            this.LbLastname = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbGender = new System.Windows.Forms.Label();
            this.BTsaveuser = new System.Windows.Forms.Button();
            this.BtSearchuser = new System.Windows.Forms.Button();
            this.TBsearchuser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTUpdateuser = new System.Windows.Forms.Button();
            this.BTdeleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.BTsaveuser);
            this.splitContainer1.Panel1.Controls.Add(this.LbGender);
            this.splitContainer1.Panel1.Controls.Add(this.LbUsername);
            this.splitContainer1.Panel1.Controls.Add(this.LbEmail);
            this.splitContainer1.Panel1.Controls.Add(this.LbLastname);
            this.splitContainer1.Panel1.Controls.Add(this.LbFirstname);
            this.splitContainer1.Panel1.Controls.Add(this.TBusername);
            this.splitContainer1.Panel1.Controls.Add(this.TBemailaddress);
            this.splitContainer1.Panel1.Controls.Add(this.TbLastname);
            this.splitContainer1.Panel1.Controls.Add(this.TbFirstname);
            this.splitContainer1.Panel1.Controls.Add(this.CBgender);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.TBsearchuser);
            this.splitContainer1.Panel2.Controls.Add(this.BTdeleteUser);
            this.splitContainer1.Panel2.Controls.Add(this.BTUpdateuser);
            this.splitContainer1.Panel2.Controls.Add(this.BtSearchuser);
            this.splitContainer1.Size = new System.Drawing.Size(764, 426);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 2;
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(88, 196);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(183, 20);
            this.TBusername.TabIndex = 3;
            // 
            // TBemailaddress
            // 
            this.TBemailaddress.Location = new System.Drawing.Point(88, 157);
            this.TBemailaddress.Name = "TBemailaddress";
            this.TBemailaddress.Size = new System.Drawing.Size(183, 20);
            this.TBemailaddress.TabIndex = 4;
            // 
            // TbLastname
            // 
            this.TbLastname.Location = new System.Drawing.Point(88, 109);
            this.TbLastname.Name = "TbLastname";
            this.TbLastname.Size = new System.Drawing.Size(183, 20);
            this.TbLastname.TabIndex = 5;
            // 
            // TbFirstname
            // 
            this.TbFirstname.Location = new System.Drawing.Point(88, 71);
            this.TbFirstname.Name = "TbFirstname";
            this.TbFirstname.Size = new System.Drawing.Size(183, 20);
            this.TbFirstname.TabIndex = 6;
            // 
            // CBgender
            // 
            this.CBgender.FormattingEnabled = true;
            this.CBgender.Location = new System.Drawing.Point(88, 242);
            this.CBgender.Name = "CBgender";
            this.CBgender.Size = new System.Drawing.Size(183, 21);
            this.CBgender.TabIndex = 2;
            // 
            // LbFirstname
            // 
            this.LbFirstname.AutoSize = true;
            this.LbFirstname.Location = new System.Drawing.Point(3, 71);
            this.LbFirstname.Name = "LbFirstname";
            this.LbFirstname.Size = new System.Drawing.Size(60, 13);
            this.LbFirstname.TabIndex = 7;
            this.LbFirstname.Text = "First Name ";
            this.LbFirstname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LbLastname
            // 
            this.LbLastname.AutoSize = true;
            this.LbLastname.Location = new System.Drawing.Point(3, 112);
            this.LbLastname.Name = "LbLastname";
            this.LbLastname.Size = new System.Drawing.Size(58, 13);
            this.LbLastname.TabIndex = 7;
            this.LbLastname.Text = "Last Name";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Location = new System.Drawing.Point(3, 164);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(73, 13);
            this.LbEmail.TabIndex = 7;
            this.LbEmail.Text = "Email Address";
            this.LbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(3, 203);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(58, 13);
            this.LbUsername.TabIndex = 7;
            this.LbUsername.Text = "Username ";
            // 
            // LbGender
            // 
            this.LbGender.AutoSize = true;
            this.LbGender.Location = new System.Drawing.Point(3, 250);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(42, 13);
            this.LbGender.TabIndex = 7;
            this.LbGender.Text = "Gender";
            // 
            // BTsaveuser
            // 
            this.BTsaveuser.Location = new System.Drawing.Point(117, 319);
            this.BTsaveuser.Name = "BTsaveuser";
            this.BTsaveuser.Size = new System.Drawing.Size(75, 23);
            this.BTsaveuser.TabIndex = 8;
            this.BTsaveuser.Text = "Save User ";
            this.BTsaveuser.UseVisualStyleBackColor = true;
            // 
            // BtSearchuser
            // 
            this.BtSearchuser.Location = new System.Drawing.Point(389, 22);
            this.BtSearchuser.Name = "BtSearchuser";
            this.BtSearchuser.Size = new System.Drawing.Size(75, 23);
            this.BtSearchuser.TabIndex = 0;
            this.BtSearchuser.Text = "Search User";
            this.BtSearchuser.UseVisualStyleBackColor = true;
            // 
            // TBsearchuser
            // 
            this.TBsearchuser.Location = new System.Drawing.Point(38, 24);
            this.TBsearchuser.Name = "TBsearchuser";
            this.TBsearchuser.Size = new System.Drawing.Size(310, 20);
            this.TBsearchuser.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 239);
            this.dataGridView1.TabIndex = 8;
            // 
            // BTUpdateuser
            // 
            this.BTUpdateuser.Location = new System.Drawing.Point(38, 358);
            this.BTUpdateuser.Name = "BTUpdateuser";
            this.BTUpdateuser.Size = new System.Drawing.Size(75, 23);
            this.BTUpdateuser.TabIndex = 0;
            this.BTUpdateuser.Text = "Update User";
            this.BTUpdateuser.UseVisualStyleBackColor = true;
            // 
            // BTdeleteUser
            // 
            this.BTdeleteUser.Location = new System.Drawing.Point(347, 358);
            this.BTdeleteUser.Name = "BTdeleteUser";
            this.BTdeleteUser.Size = new System.Drawing.Size(75, 23);
            this.BTdeleteUser.TabIndex = 0;
            this.BTdeleteUser.Text = "Delete User";
            this.BTdeleteUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Management";
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserManage";
            this.Text = "UserManage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbLastname;
        private System.Windows.Forms.Label LbFirstname;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBemailaddress;
        private System.Windows.Forms.TextBox TbLastname;
        private System.Windows.Forms.TextBox TbFirstname;
        private System.Windows.Forms.ComboBox CBgender;
        private System.Windows.Forms.Button BTsaveuser;
        private System.Windows.Forms.TextBox TBsearchuser;
        private System.Windows.Forms.Button BtSearchuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTdeleteUser;
        private System.Windows.Forms.Button BTUpdateuser;
    }
}