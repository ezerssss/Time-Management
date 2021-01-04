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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLogin = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.birdBox = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            this.assignmentScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(264, 33);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(144, 52);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calendar.Location = new System.Drawing.Point(115, 113);
            this.calendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendar.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // assignmentScreen
            // 
            this.assignmentScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assignmentScreen.Controls.Add(this.label1);
            this.assignmentScreen.Location = new System.Drawing.Point(45, 364);
            this.assignmentScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignmentScreen.Name = "assignmentScreen";
            this.assignmentScreen.Size = new System.Drawing.Size(436, 236);
            this.assignmentScreen.TabIndex = 5;
            this.assignmentScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.assignmentScreen_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "11:00AM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(517, 395);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 53);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.White;
            this.userLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userLogin.FlatAppearance.BorderSize = 0;
            this.userLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.userLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogin.Image = ((System.Drawing.Image)(resources.GetObject("userLogin.Image")));
            this.userLogin.Location = new System.Drawing.Point(176, 615);
            this.userLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(67, 62);
            this.userLogin.TabIndex = 12;
            this.userLogin.UseVisualStyleBackColor = false;
            this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.White;
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Image = ((System.Drawing.Image)(resources.GetObject("addTask.Image")));
            this.addTask.Location = new System.Drawing.Point(277, 615);
            this.addTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(68, 63);
            this.addTask.TabIndex = 13;
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // birdBox
            // 
            this.birdBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("birdBox.BackgroundImage")));
            this.birdBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birdBox.Location = new System.Drawing.Point(45, 364);
            this.birdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birdBox.Name = "birdBox";
            this.birdBox.Size = new System.Drawing.Size(436, 236);
            this.birdBox.TabIndex = 9;
            this.birdBox.TabStop = false;
            this.birdBox.Visible = false;
            // 
            // Calendar_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birdBox);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(button1);
            this.Controls.Add(this.assignmentScreen);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calendar_View";
            this.Size = new System.Drawing.Size(515, 688);
            this.Load += new System.EventHandler(this.Calendar_View_Load);
            this.assignmentScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Panel assignmentScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button userLogin;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.PictureBox birdBox;
    }
}
