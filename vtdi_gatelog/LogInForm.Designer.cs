﻿namespace vtdi_gatelog
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
            this.Pbicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbpassword
            // 
            this.Tbpassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.Tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbpassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.Tbpassword.Location = new System.Drawing.Point(122, 297);
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '*';
            this.Tbpassword.Size = new System.Drawing.Size(291, 24);
            this.Tbpassword.TabIndex = 1;
            // 
            // Tbusername
            // 
            this.Tbusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tbusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tbusername.BackColor = System.Drawing.SystemColors.MenuText;
            this.Tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbusername.ForeColor = System.Drawing.Color.AliceBlue;
            this.Tbusername.Location = new System.Drawing.Point(121, 193);
            this.Tbusername.Name = "Tbusername";
            this.Tbusername.Size = new System.Drawing.Size(291, 24);
            this.Tbusername.TabIndex = 1;
            // 
            // Btreset
            // 
            this.Btreset.BackColor = System.Drawing.SystemColors.ControlText;
            this.Btreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btreset.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Btreset.FlatAppearance.BorderSize = 2;
            this.Btreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.Btreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.Btreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btreset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btreset.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btreset.Location = new System.Drawing.Point(330, 395);
            this.Btreset.Name = "Btreset";
            this.Btreset.Size = new System.Drawing.Size(92, 39);
            this.Btreset.TabIndex = 2;
            this.Btreset.Text = "Reset";
            this.Btreset.UseVisualStyleBackColor = false;
            this.Btreset.Click += new System.EventHandler(this.Btreset_Click);
            // 
            // Btlogin
            // 
            this.Btlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btlogin.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Btlogin.FlatAppearance.BorderSize = 2;
            this.Btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.Btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.Btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btlogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btlogin.Location = new System.Drawing.Point(109, 395);
            this.Btlogin.Name = "Btlogin";
            this.Btlogin.Size = new System.Drawing.Size(92, 39);
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
            this.Lbusername.Location = new System.Drawing.Point(221, 142);
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
            this.Lbpassword.Location = new System.Drawing.Point(226, 254);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(86, 23);
            this.Lbpassword.TabIndex = 3;
            this.Lbpassword.Text = "Password";
            // 
            // Pbicon
            // 
            this.Pbicon.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pbicon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbicon.Image = ((System.Drawing.Image)(resources.GetObject("Pbicon.Image")));
            this.Pbicon.Location = new System.Drawing.Point(236, 40);
            this.Pbicon.Name = "Pbicon";
            this.Pbicon.Size = new System.Drawing.Size(58, 58);
            this.Pbicon.TabIndex = 4;
            this.Pbicon.TabStop = false;
            // 
            // LogInForm
            // 
            this.AcceptButton = this.Btlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.Btreset;
            this.ClientSize = new System.Drawing.Size(533, 555);
            this.Controls.Add(this.Pbicon);
            this.Controls.Add(this.Lbpassword);
            this.Controls.Add(this.Lbusername);
            this.Controls.Add(this.Btlogin);
            this.Controls.Add(this.Btreset);
            this.Controls.Add(this.Tbusername);
            this.Controls.Add(this.Tbpassword);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(533, 555);
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
        private System.Windows.Forms.PictureBox Pbicon;
    }
}