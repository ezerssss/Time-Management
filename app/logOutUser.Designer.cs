
namespace app
{
    partial class logOutUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logOutUser));
            this.userNameInitial = new System.Windows.Forms.Label();
            this.userNameDisplay = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameInitial
            // 
            this.userNameInitial.BackColor = System.Drawing.Color.Transparent;
            this.userNameInitial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNameInitial.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInitial.Image = ((System.Drawing.Image)(resources.GetObject("userNameInitial.Image")));
            this.userNameInitial.Location = new System.Drawing.Point(83, 97);
            this.userNameInitial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameInitial.Name = "userNameInitial";
            this.userNameInitial.Size = new System.Drawing.Size(219, 219);
            this.userNameInitial.TabIndex = 0;
            this.userNameInitial.Text = "na";
            this.userNameInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameDisplay
            // 
            this.userNameDisplay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameDisplay.Location = new System.Drawing.Point(0, 324);
            this.userNameDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameDisplay.Name = "userNameDisplay";
            this.userNameDisplay.Size = new System.Drawing.Size(386, 44);
            this.userNameDisplay.TabIndex = 2;
            this.userNameDisplay.Text = "na";
            this.userNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(147, 381);
            this.logOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(91, 29);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "LOGOUT";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.OrangeRed;
            this.goBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBack.BackgroundImage")));
            this.goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.FlatAppearance.BorderSize = 0;
            this.goBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBack.Location = new System.Drawing.Point(9, 9);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(31, 30);
            this.goBack.TabIndex = 14;
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // logOutUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.userNameDisplay);
            this.Controls.Add(this.userNameInitial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "logOutUser";
            this.Size = new System.Drawing.Size(386, 559);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameInitial;
        private System.Windows.Forms.Label userNameDisplay;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button goBack;
    }
}
