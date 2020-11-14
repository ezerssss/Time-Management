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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.ComboBox();
            this.minutes = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.task = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.CustomFormat = "day, MMM/dd/yyyy";
            this.date.Location = new System.Drawing.Point(126, 155);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(181, 20);
            this.date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task    : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date     : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time     : ";
            // 
            // hours
            // 
            this.hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.hours.Location = new System.Drawing.Point(125, 181);
            this.hours.MaxDropDownItems = 6;
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(45, 21);
            this.hours.TabIndex = 5;
            // 
            // minutes
            // 
            this.minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.minutes.Location = new System.Drawing.Point(192, 181);
            this.minutes.MaxDropDownItems = 15;
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(45, 21);
            this.minutes.TabIndex = 6;
            // 
            // day
            // 
            this.day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.day.Location = new System.Drawing.Point(243, 181);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(41, 21);
            this.day.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(126, 104);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(181, 20);
            this.subject.TabIndex = 9;
            this.subject.Text = "Enter subject of task";
            this.subject.Click += new System.EventHandler(this.subject_Click);
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(126, 129);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(181, 20);
            this.task.TabIndex = 10;
            this.task.Text = "Enter task detail";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addTask);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ": ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.task);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.day);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Name = "add_task";
            this.Size = new System.Drawing.Size(388, 404);
            this.Load += new System.EventHandler(this.add_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hours;
        private System.Windows.Forms.ComboBox minutes;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}
