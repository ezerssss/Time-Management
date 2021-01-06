namespace app
{
    partial class add_task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_task));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.hours = new System.Windows.Forms.ComboBox();
            this.minutes = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.task = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.CustomFormat = "day, MMM/dd/yyyy";
            this.date.Font = new System.Drawing.Font("Questrial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(68, 280);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(266, 23);
            this.date.TabIndex = 0;
            // 
            // hours
            // 
            this.hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hours.Font = new System.Drawing.Font("Questrial", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.FormattingEnabled = true;
            this.hours.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "08",
            "10",
            "11",
            "12"});
            this.hours.Location = new System.Drawing.Point(136, 345);
            this.hours.MaxDropDownItems = 6;
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(45, 27);
            this.hours.TabIndex = 5;
            // 
            // minutes
            // 
            this.minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutes.Font = new System.Drawing.Font("Questrial", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.FormattingEnabled = true;
            this.minutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52 ",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minutes.Location = new System.Drawing.Point(199, 345);
            this.minutes.MaxDropDownItems = 15;
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(45, 27);
            this.minutes.TabIndex = 6;
            // 
            // day
            // 
            this.day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day.Font = new System.Drawing.Font("Questrial", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.day.Location = new System.Drawing.Point(250, 345);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(44, 27);
            this.day.TabIndex = 7;
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.White;
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subject.Font = new System.Drawing.Font("Questrial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.Color.Black;
            this.subject.Location = new System.Drawing.Point(82, 105);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(241, 18);
            this.subject.TabIndex = 9;
            this.subject.Text = "Enter subject of task";
            this.subject.Click += new System.EventHandler(this.subject_Click);
            this.subject.Enter += new System.EventHandler(this.subject_Enter);
            // 
            // task
            // 
            this.task.BackColor = System.Drawing.Color.White;
            this.task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.task.Font = new System.Drawing.Font("Questrial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task.ForeColor = System.Drawing.Color.Black;
            this.task.Location = new System.Drawing.Point(82, 189);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(235, 18);
            this.task.TabIndex = 10;
            this.task.Text = "Enter task details";
            this.task.Click += new System.EventHandler(this.task_Click);
            this.task.Enter += new System.EventHandler(this.task_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Questrial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Task";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addTask);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(185, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = ": ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Questrial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "ADD TASK";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.ForeColor = System.Drawing.Color.DarkGray;
            this.line1.Location = new System.Drawing.Point(75, 206);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(253, 13);
            this.line1.TabIndex = 15;
            this.line1.Text = "_________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(74, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "_________________________________________";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubjectLabel.Font = new System.Drawing.Font("Questrial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.SubjectLabel.Location = new System.Drawing.Point(75, 81);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(60, 22);
            this.SubjectLabel.TabIndex = 17;
            this.SubjectLabel.Text = "Subject";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskLabel.Font = new System.Drawing.Font("Questrial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.TaskLabel.Location = new System.Drawing.Point(75, 155);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(41, 22);
            this.TaskLabel.TabIndex = 18;
            this.TaskLabel.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Questrial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(75, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Questrial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(76, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(75, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "_________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(74, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "_________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(74, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "_________________________________________";
            // 
            // add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.task);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.day);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "add_task";
            this.Size = new System.Drawing.Size(386, 559);
            this.Load += new System.EventHandler(this.add_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox hours;
        private System.Windows.Forms.ComboBox minutes;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}
