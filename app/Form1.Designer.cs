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
            this.task = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // task
            // 
            this.task.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.task.FlatAppearance.BorderSize = 0;
            this.task.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.task.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task.Image = ((System.Drawing.Image)(resources.GetObject("task.Image")));
            this.task.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.task.Location = new System.Drawing.Point(156, 441);
            this.task.Margin = new System.Windows.Forms.Padding(2);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(66, 66);
            this.task.TabIndex = 5;
            this.task.UseVisualStyleBackColor = true;
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // calendar
            // 
            this.calendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendar.FlatAppearance.BorderSize = 0;
            this.calendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.Image = ((System.Drawing.Image)(resources.GetObject("calendar.Image")));
            this.calendar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.calendar.Location = new System.Drawing.Point(72, 441);
            this.calendar.Margin = new System.Windows.Forms.Padding(2);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(66, 66);
            this.calendar.TabIndex = 7;
            this.calendar.UseVisualStyleBackColor = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Location = new System.Drawing.Point(37, 73);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(220, 370);
            this.screen.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 227);
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
            this.logo2.Location = new System.Drawing.Point(50, 12);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(185, 55);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 4;
            this.logo2.TabStop = false;
            this.logo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseDown);
            this.logo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseMove);
            this.logo2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logo2_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(247, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 530);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.task);
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

        }

        #endregion
        private System.Windows.Forms.Button task;
        private System.Windows.Forms.Button calendar;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Button button2;
    }
}

