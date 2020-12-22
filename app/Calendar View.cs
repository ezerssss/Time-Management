using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace app
{
    public partial class Calendar_View : UserControl
    {
        string path;
        string[] splitter = { "|#$#|" };
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_View));

        public Calendar_View()
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory() + "\\file.txt";
            checkAssignments();
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            checkAssignments();
        }

        private void printCalendarTask(string time, string subject, string assignment, int verticalOffset)
        {
            string text = subject + " - " + assignment;
            string display = text;
            if (text.Length > 22)
            {
                display = text.Substring(0, 23);
                display += "...";
            }
            Label timebox = new Label();
            assignmentScreen.Controls.Add(timebox);
            timebox.Top = verticalOffset * 30 + 5;
            timebox.Left = 20;
            timebox.Width = 64;
            timebox.Height = 24;
            timebox.Text = time;
            timebox.Font = new Font("Century Gothic Bold", 10);
            timebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            timebox.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            timebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            TextBox taskBox = new TextBox();
            ToolTip tp = new ToolTip();
            tp.ShowAlways = true;

            assignmentScreen.Controls.Add(taskBox);
            taskBox.Top = verticalOffset * 30 + 7;
            taskBox.Left = 90;
            taskBox.Width = 220;
            taskBox.Text = display;
            taskBox.ReadOnly = true;
            taskBox.Font = new Font("Century Gothic", 12);
            taskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tp.SetToolTip(taskBox, text);
        }

        private void checkAssignments()
        {
            string readLine;
            assignmentScreen.Controls.Clear();
            assignmentScreen.AutoScroll = true;
            assignmentScreen.Text = "";
            bool assignment = false;
            int yoffset = 0;
            using (StreamReader sr = new StreamReader(path)) {
                while ((readLine = sr.ReadLine()) != null) {
                    string[] task = readLine.Split(splitter, StringSplitOptions.None);
                    DateTime dateTime;
                    if (DateTime.TryParse(task[2], out dateTime))
                    {
                        if (dateTime.ToString("MMM/dd/yyyy") == calendar.SelectionStart.ToString("MMM/dd/yyyy"))
                        {
                            birdBox.Visible = false;
                            printCalendarTask(task[3], task[0], task[1], yoffset);
                            assignment = true;
                            yoffset += 1;
                        }       
                    }
                }
            }
            if (!assignment)
            {
                birdBox.Visible = true;
            }
        }

        private void Calendar_View_Load(object sender, EventArgs e)
        {
            //boldDates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                Data_Grid dg = new Data_Grid();
                dg.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(dg);
            }
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(lg);
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                add_task at = new add_task();
                at.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(at);
            }
        }

        private void assignmentScreen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
