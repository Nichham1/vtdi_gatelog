namespace vtdi_gatelog
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.Tbpassword = new System.Windows.Forms.TextBox();
            this.Tbusername = new System.Windows.Forms.TextBox();
            this.Btreset = new System.Windows.Forms.Button();
            this.Btlogin = new System.Windows.Forms.Button();
            this.Lbusername = new System.Windows.Forms.Label();
            this.Lbpassword = new System.Windows.Forms.Label();
            this.Lbcaptcha = new System.Windows.Forms.Label();
            this.Tbcaptchadis = new System.Windows.Forms.TextBox();
            this.Pbicon = new System.Windows.Forms.PictureBox();
            this.TBcaptcha = new System.Windows.Forms.TextBox();
            this.Lbmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbpassword
            // 
            this.Tbpassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.Tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbpassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.Tbpassword.Location = new System.Drawing.Point(153, 207);
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '*';
            this.Tbpassword.Size = new System.Drawing.Size(250, 24);
            this.Tbpassword.TabIndex = 1;
            // 
            // Tbusername
            // 
            this.Tbusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tbusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Tbusername.BackColor = System.Drawing.SystemColors.MenuText;
            this.Tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbusername.ForeColor = System.Drawing.Color.AliceBlue;
            this.Tbusername.Location = new System.Drawing.Point(153, 148);
            this.Tbusername.Name = "Tbusername";
            this.Tbusername.Size = new System.Drawing.Size(250, 24);
            this.Tbusername.TabIndex = 1;
            // 
            // Btreset
            // 
            this.Btreset.BackColor = System.Drawing.SystemColors.ControlText;
            this.Btreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btreset.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Btreset.FlatAppearance.BorderSize = 2;
            this.Btreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.Btreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.Btreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btreset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btreset.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btreset.Location = new System.Drawing.Point(324, 342);
            this.Btreset.Name = "Btreset";
            this.Btreset.Size = new System.Drawing.Size(79, 34);
            this.Btreset.TabIndex = 2;
            this.Btreset.Text = "Reset";
            this.Btreset.UseVisualStyleBackColor = false;
            this.Btreset.Click += new System.EventHandler(this.Btreset_Click);
            // 
            // Btlogin
            // 
            this.Btlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btlogin.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Btlogin.FlatAppearance.BorderSize = 2;
            this.Btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.Btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.Btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btlogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btlogin.Location = new System.Drawing.Point(153, 342);
            this.Btlogin.Name = "Btlogin";
            this.Btlogin.Size = new System.Drawing.Size(79, 34);
            this.Btlogin.TabIndex = 2;
            this.Btlogin.Text = "Login";
            this.Btlogin.UseVisualStyleBackColor = false;
            this.Btlogin.Click += new System.EventHandler(this.Btlogin_Click);
            // 
            // Lbusername
            // 
            this.Lbusername.AutoSize = true;
            this.Lbusername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbusername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbusername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbusername.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lbusername.Location = new System.Drawing.Point(56, 145);
            this.Lbusername.Name = "Lbusername";
            this.Lbusername.Size = new System.Drawing.Size(91, 23);
            this.Lbusername.TabIndex = 3;
            this.Lbusername.Text = "User name";
            // 
            // Lbpassword
            // 
            this.Lbpassword.AutoSize = true;
            this.Lbpassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbpassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Lbpassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbpassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lbpassword.Location = new System.Drawing.Point(55, 203);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(86, 23);
            this.Lbpassword.TabIndex = 3;
            this.Lbpassword.Text = "Password";
            // 
            // Lbcaptcha
            // 
            this.Lbcaptcha.AutoSize = true;
            this.Lbcaptcha.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lbcaptcha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbcaptcha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbcaptcha.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lbcaptcha.Location = new System.Drawing.Point(60, 277);
            this.Lbcaptcha.Name = "Lbcaptcha";
            this.Lbcaptcha.Size = new System.Drawing.Size(81, 24);
            this.Lbcaptcha.TabIndex = 3;
            this.Lbcaptcha.Text = "Captcha";
            // 
            // Tbcaptchadis
            // 
            this.Tbcaptchadis.BackColor = System.Drawing.SystemColors.MenuText;
            this.Tbcaptchadis.Enabled = false;
            this.Tbcaptchadis.ForeColor = System.Drawing.Color.AliceBlue;
            this.Tbcaptchadis.Location = new System.Drawing.Point(153, 290);
            this.Tbcaptchadis.Name = "Tbcaptchadis";
            this.Tbcaptchadis.ReadOnly = true;
            this.Tbcaptchadis.Size = new System.Drawing.Size(112, 20);
            this.Tbcaptchadis.TabIndex = 1;
            this.Tbcaptchadis.WordWrap = false;
            // 
            // Pbicon
            // 
            this.Pbicon.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pbicon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbicon.Image = ((System.Drawing.Image)(resources.GetObject("Pbicon.Image")));
            this.Pbicon.Location = new System.Drawing.Point(245, 78);
            this.Pbicon.Name = "Pbicon";
            this.Pbicon.Size = new System.Drawing.Size(50, 51);
            this.Pbicon.TabIndex = 4;
            this.Pbicon.TabStop = false;
            // 
            // TBcaptcha
            // 
            this.TBcaptcha.BackColor = System.Drawing.SystemColors.MenuText;
            this.TBcaptcha.ForeColor = System.Drawing.Color.AliceBlue;
            this.TBcaptcha.Location = new System.Drawing.Point(153, 264);
            this.TBcaptcha.Name = "TBcaptcha";
            this.TBcaptcha.Size = new System.Drawing.Size(112, 20);
            this.TBcaptcha.TabIndex = 1;
            // 
            // Lbmessage
            // 
            this.Lbmessage.AutoSize = true;
            this.Lbmessage.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lbmessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbmessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbmessage.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lbmessage.Location = new System.Drawing.Point(306, 277);
            this.Lbmessage.Name = "Lbmessage";
            this.Lbmessage.Size = new System.Drawing.Size(81, 24);
            this.Lbmessage.TabIndex = 3;
            this.Lbmessage.Text = "Captcha";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(506, 470);
            this.Controls.Add(this.Pbicon);
            this.Controls.Add(this.Lbmessage);
            this.Controls.Add(this.Lbcaptcha);
            this.Controls.Add(this.Lbpassword);
            this.Controls.Add(this.Lbusername);
            this.Controls.Add(this.Btlogin);
            this.Controls.Add(this.Btreset);
            this.Controls.Add(this.Tbusername);
            this.Controls.Add(this.TBcaptcha);
            this.Controls.Add(this.Tbcaptchadis);
            this.Controls.Add(this.Tbpassword);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.Pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbpassword;
        private System.Windows.Forms.TextBox Tbusername;
        private System.Windows.Forms.Button Btreset;
        private System.Windows.Forms.Button Btlogin;
        private System.Windows.Forms.Label Lbusername;
        private System.Windows.Forms.Label Lbpassword;
        private System.Windows.Forms.Label Lbcaptcha;
        private System.Windows.Forms.TextBox Tbcaptchadis;
        private System.Windows.Forms.PictureBox Pbicon;
        private System.Windows.Forms.TextBox TBcaptcha;
        private System.Windows.Forms.Label Lbmessage;
    }
}