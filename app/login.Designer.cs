﻿namespace app
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.username.Location = new System.Drawing.Point(68, 296);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(254, 28);
            this.username.TabIndex = 1;
            this.username.Text = "Enter username";
            this.username.WordWrap = false;
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Location = new System.Drawing.Point(68, 359);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(254, 28);
            this.password.TabIndex = 2;
            this.password.Text = "Enter password";
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 224);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Image = ((System.Drawing.Image)(resources.GetObject("login_button.Image")));
            this.login_button.Location = new System.Drawing.Point(137, 416);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(110, 43);
            this.login_button.TabIndex = 0;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(147, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 14);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Continue anyway";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(329, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showPass);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_button);
            this.Name = "login";
            this.Size = new System.Drawing.Size(388, 562);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}