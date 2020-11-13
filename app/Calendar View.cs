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
            string display = "";
            for (int i = 0; i < text.Length; i++){
                if (display.Length > 21 && i > 3)
                {
                    display += "...";
                    break;
                }
                display += text[i];
            }
            Label timebox = new Label();
            assignmentScreen.Controls.Add(timebox);
            timebox.Top = verticalOffset * 30 + 5;
            timebox.Left = 20;
            timebox.Width = 64;
            timebox.Height = 24;
            timebox.Text = time;
            timebox.Font = new Font("Bahnschrift SemiBold", 11);
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
            taskBox.Font = new Font("Bahnschrift", 12);
            taskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tp.SetToolTip(taskBox, text);
        }
        private void checkAssignments()
        {
            lines = File.ReadAllLines(path).ToList();
            assignmentScreen.Controls.Clear();
            assignmentScreen.AutoScroll = true;
            assignmentScreen.Text = "";
            toDoLabel.Text = calendar.SelectionStart.ToString("MMM/dd/yyyy");
            bool assignment = false;
            int yoffset = 0;
            foreach (string line in lines)
            {
                string[] task = line.Split(splitter, StringSplitOptions.None);
                if (DateTime.Parse(task[2]).ToString("MMM/dd/yyyy") == calendar.SelectionStart.ToString("MMM/dd/yyyy"))
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
                noAssignment.Top = 20;
                noAssignment.Left = 44;
                noAssignment.Width = 270;
                noAssignment.Height = 150;
                noAssignment.Text = "Fucking beetch maderfacker ka naning nimo gud wala man lagi kay assignment you arse pillock you fucking diligent dickwad";
                noAssignment.Multiline = true;
                noAssignment.ReadOnly = true;
                noAssignment.Font = new Font("Bahnschrift SemiBold", 14);
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
            boldDates();
        }
    }
}
