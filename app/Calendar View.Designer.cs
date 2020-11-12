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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_View));
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.assignmentScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.assignmentScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calendar.Location = new System.Drawing.Point(81, 21);
            this.calendar.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // toDoLabel
            // 
            this.toDoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoLabel.Location = new System.Drawing.Point(0, 0);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(388, 404);
            this.toDoLabel.TabIndex = 4;
            this.toDoLabel.Text = "ASSIGNMENT(S)";
            this.toDoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assignmentScreen
            // 
            this.assignmentScreen.Controls.Add(this.label1);
            this.assignmentScreen.Location = new System.Drawing.Point(16, 218);
            this.assignmentScreen.Name = "assignmentScreen";
            this.assignmentScreen.Size = new System.Drawing.Size(356, 173);
            this.assignmentScreen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "11:00AM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // Calendar_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentScreen);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.toDoLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calendar_View";
            this.Size = new System.Drawing.Size(388, 404);
            this.Load += new System.EventHandler(this.Calendar_View_Load);
            this.assignmentScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Panel assignmentScreen;
        private System.Windows.Forms.Label label1;
    }
}
