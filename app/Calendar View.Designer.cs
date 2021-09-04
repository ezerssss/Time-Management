namespace app
{
    partial class Calendar_View
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_View));
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.assignmentScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLogin = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.birdBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.links = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.assignmentScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Questrial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(41)))));
            button1.Location = new System.Drawing.Point(205, 41);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 40);
            button1.TabIndex = 9;
            button1.Text = "To-do";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendar.Font = new System.Drawing.Font("Questrial", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calendar.Location = new System.Drawing.Point(87, 106);
            this.calendar.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // assignmentScreen
            // 
            this.assignmentScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(41)))));
            this.assignmentScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assignmentScreen.Controls.Add(this.label1);
            this.assignmentScreen.Location = new System.Drawing.Point(6, 296);
            this.assignmentScreen.Name = "assignmentScreen";
            this.assignmentScreen.Size = new System.Drawing.Size(372, 190);
            this.assignmentScreen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Questrial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(359, 91);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 83);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.userLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userLogin.FlatAppearance.BorderSize = 0;
            this.userLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.userLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.userLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogin.Image = ((System.Drawing.Image)(resources.GetObject("userLogin.Image")));
            this.userLogin.Location = new System.Drawing.Point(84, 500);
            this.userLogin.Margin = new System.Windows.Forms.Padding(0);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(79, 50);
            this.userLogin.TabIndex = 12;
            this.userLogin.UseVisualStyleBackColor = false;
            this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.addTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Image = ((System.Drawing.Image)(resources.GetObject("addTask.Image")));
            this.addTask.Location = new System.Drawing.Point(166, 500);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(79, 50);
            this.addTask.TabIndex = 13;
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // birdBox
            // 
            this.birdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(41)))));
            this.birdBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("birdBox.BackgroundImage")));
            this.birdBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.birdBox.Location = new System.Drawing.Point(66, 313);
            this.birdBox.Name = "birdBox";
            this.birdBox.Size = new System.Drawing.Size(271, 147);
            this.birdBox.TabIndex = 9;
            this.birdBox.TabStop = false;
            this.birdBox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-20, 282);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 280);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(386, 290);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // links
            // 
            this.links.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.links.Cursor = System.Windows.Forms.Cursors.Hand;
            this.links.FlatAppearance.BorderSize = 0;
            this.links.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.links.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.links.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.links.ForeColor = System.Drawing.Color.Transparent;
            this.links.Image = ((System.Drawing.Image)(resources.GetObject("links.Image")));
            this.links.Location = new System.Drawing.Point(248, 500);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(64, 50);
            this.links.TabIndex = 16;
            this.links.UseVisualStyleBackColor = false;
            this.links.Click += new System.EventHandler(this.links_Click);
            // 
            // Calendar_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.links);
            this.Controls.Add(this.birdBox);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.assignmentScreen);
            this.Controls.Add(this.calendar);
            this.Controls.Add(button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calendar_View";
            this.Size = new System.Drawing.Size(386, 559);
            this.Load += new System.EventHandler(this.Calendar_View_Load);
            this.assignmentScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Panel assignmentScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button userLogin;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.PictureBox birdBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button links;
    }
}
