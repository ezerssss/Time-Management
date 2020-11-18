﻿using System;
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
        List<string> lines = new List<string>();
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
            using (StreamReader sr = new StreamReader(path)) {
                while ((readLine = sr.ReadLine()) != null) {
                    lines.Add(readLine);
                }
                sr.Close();
            }
            assignmentScreen.Controls.Clear();
            assignmentScreen.AutoScroll = true;
            assignmentScreen.Text = "";
            bool assignment = false;
            int yoffset = 0;
            foreach (string line in lines)
            {
                string[] task = line.Split(splitter, StringSplitOptions.None);
                if (lines.Count < 1)
                {
                    File.WriteAllText(path, "HElLO");
                }
                else if(task.Length < 5)
                {}
                else if(DateTime.Parse(task[2]).ToString("MMM/dd/yyyy") == calendar.SelectionStart.ToString("MMM/dd/yyyy"))
                {
                    printCalendarTask(task[3], task[0], task[1], yoffset);
                    assignment = true;
                    yoffset += 1;
                }
            }
            if (!assignment)
            {
                TextBox noAssignment = new TextBox();
                assignmentScreen.Controls.Add(noAssignment);
                noAssignment.Left = 21;
                noAssignment.Width = 289;
                noAssignment.Height = 173;
                noAssignment.Text = "INSERT NO ASSIGNMENTS PICTURE";
                noAssignment.Multiline = true;
                noAssignment.ReadOnly = true;
                noAssignment.Font = new Font("Century Gothic", 10);
                noAssignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void boldDates() {
            DateTime date = new DateTime();
            lines = File.ReadAllLines(path).ToList();
            foreach (string line in lines)
            {
                string[] task = line.Split(splitter, StringSplitOptions.None);
                date = Convert.ToDateTime(task[2]);
                calendar.AddBoldedDate(date);
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
    }
}
