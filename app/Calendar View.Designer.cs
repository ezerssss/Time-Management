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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.assignmentScreen = new System.Windows.Forms.TextBox();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(30, 9);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // assignmentScreen
            // 
            this.assignmentScreen.Location = new System.Drawing.Point(26, 200);
            this.assignmentScreen.Multiline = true;
            this.assignmentScreen.Name = "assignmentScreen";
            this.assignmentScreen.Size = new System.Drawing.Size(236, 146);
            this.assignmentScreen.TabIndex = 3;
            // 
            // toDoLabel
            // 
            this.toDoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoLabel.Location = new System.Drawing.Point(0, 0);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(288, 370);
            this.toDoLabel.TabIndex = 4;
            this.toDoLabel.Text = "ASSIGNMENT(S)";
            this.toDoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Size = new System.Drawing.Size(288, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TextBox assignmentScreen;
        private System.Windows.Forms.Label toDoLabel;
    }
}
