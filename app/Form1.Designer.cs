namespace app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.taskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskButton.BackgroundImage")));
            this.taskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskButton.FlatAppearance.BorderSize = 0;
            this.taskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.taskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskButton.Location = new System.Drawing.Point(172, 505);
            this.taskButton.Margin = new System.Windows.Forms.Padding(2);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(55, 55);
            this.taskButton.TabIndex = 5;
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.task_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.calendarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarButton.BackgroundImage")));
            this.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.calendarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Location = new System.Drawing.Point(57, 505);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(55, 55);
            this.calendarButton.TabIndex = 7;
            this.calendarButton.UseVisualStyleBackColor = false;
            this.calendarButton.Click += new System.EventHandler(this.calendar_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Location = new System.Drawing.Point(0, 84);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(388, 404);
            this.screen.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 87);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(57, 11);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(249, 66);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 4;
            this.logo2.TabStop = false;
            this.logo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseDown);
            this.logo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseMove);
            this.logo2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.closeButton.Location = new System.Drawing.Point(342, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.addTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTaskButton.BackgroundImage")));
            this.addTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.addTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addTaskButton.Location = new System.Drawing.Point(282, 507);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(50, 50);
            this.addTaskButton.TabIndex = 10;
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTask_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(347, 569);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 591);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.taskButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

