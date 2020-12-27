namespace app
{
    partial class Data_Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Grid));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.userLogin = new System.Windows.Forms.Button();
            this.dayToday = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.referenceButton = new System.Windows.Forms.Label();
            this.referenceLabel3 = new System.Windows.Forms.Label();
            this.referenceLabel2 = new System.Windows.Forms.Label();
            this.referenceLabel1 = new System.Windows.Forms.Label();
            this.showAllTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateButton);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 149);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 48);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(97, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addTask
            // 
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Image = ((System.Drawing.Image)(resources.GetObject("addTask.Image")));
            this.addTask.Location = new System.Drawing.Point(211, 494);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(51, 51);
            this.addTask.TabIndex = 14;
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // userLogin
            // 
            this.userLogin.FlatAppearance.BorderSize = 0;
            this.userLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogin.Image = ((System.Drawing.Image)(resources.GetObject("userLogin.Image")));
            this.userLogin.Location = new System.Drawing.Point(149, 494);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(50, 50);
            this.userLogin.TabIndex = 15;
            this.userLogin.UseVisualStyleBackColor = true;
            this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // dayToday
            // 
            this.dayToday.BackColor = System.Drawing.Color.Transparent;
            this.dayToday.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayToday.ForeColor = System.Drawing.Color.White;
            this.dayToday.Image = ((System.Drawing.Image)(resources.GetObject("dayToday.Image")));
            this.dayToday.Location = new System.Drawing.Point(16, 79);
            this.dayToday.Name = "dayToday";
            this.dayToday.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.dayToday.Size = new System.Drawing.Size(356, 56);
            this.dayToday.TabIndex = 16;
            this.dayToday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.referenceButton);
            this.panel1.Controls.Add(this.referenceLabel3);
            this.panel1.Controls.Add(this.referenceLabel2);
            this.panel1.Controls.Add(this.referenceLabel1);
            this.panel1.Location = new System.Drawing.Point(3, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 300);
            this.panel1.TabIndex = 17;
            // 
            // referenceButton
            // 
            this.referenceButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceButton.ForeColor = System.Drawing.Color.White;
            this.referenceButton.Image = ((System.Drawing.Image)(resources.GetObject("referenceButton.Image")));
            this.referenceButton.Location = new System.Drawing.Point(15, 142);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(20, 20);
            this.referenceButton.TabIndex = 12;
            this.referenceButton.Text = "12/30";
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.referenceButton.Visible = false;
            // 
            // referenceLabel3
            // 
            this.referenceLabel3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceLabel3.ForeColor = System.Drawing.Color.White;
            this.referenceLabel3.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel3.Image")));
            this.referenceLabel3.Location = new System.Drawing.Point(15, 104);
            this.referenceLabel3.Name = "referenceLabel3";
            this.referenceLabel3.Size = new System.Drawing.Size(64, 24);
            this.referenceLabel3.TabIndex = 11;
            this.referenceLabel3.Text = "Subject";
            this.referenceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.referenceLabel3.Visible = false;
            // 
            // referenceLabel2
            // 
            this.referenceLabel2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceLabel2.ForeColor = System.Drawing.Color.White;
            this.referenceLabel2.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel2.Image")));
            this.referenceLabel2.Location = new System.Drawing.Point(15, 66);
            this.referenceLabel2.Name = "referenceLabel2";
            this.referenceLabel2.Size = new System.Drawing.Size(64, 24);
            this.referenceLabel2.TabIndex = 10;
            this.referenceLabel2.Text = "11:00AM";
            this.referenceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.referenceLabel2.Visible = false;
            // 
            // referenceLabel1
            // 
            this.referenceLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceLabel1.ForeColor = System.Drawing.Color.White;
            this.referenceLabel1.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel1.Image")));
            this.referenceLabel1.Location = new System.Drawing.Point(15, 24);
            this.referenceLabel1.Name = "referenceLabel1";
            this.referenceLabel1.Size = new System.Drawing.Size(50, 24);
            this.referenceLabel1.TabIndex = 9;
            this.referenceLabel1.Text = "12/30";
            this.referenceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.referenceLabel1.Visible = false;
            // 
            // showAllTask
            // 
            this.showAllTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAllTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllTask.Location = new System.Drawing.Point(211, 464);
            this.showAllTask.Name = "showAllTask";
            this.showAllTask.Size = new System.Drawing.Size(67, 24);
            this.showAllTask.TabIndex = 18;
            this.showAllTask.Text = "ALL";
            this.showAllTask.UseVisualStyleBackColor = true;
            this.showAllTask.Click += new System.EventHandler(this.showAllTask_Click);
            // 
            // Data_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showAllTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dayToday);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Name = "Data_Grid";
            this.Size = new System.Drawing.Size(388, 562);
            this.Load += new System.EventHandler(this.Data_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button userLogin;
        private System.Windows.Forms.Label dayToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label referenceLabel1;
        private System.Windows.Forms.Label referenceLabel3;
        private System.Windows.Forms.Label referenceLabel2;
        private System.Windows.Forms.Label referenceButton;
        private System.Windows.Forms.Button showAllTask;
    }
}
