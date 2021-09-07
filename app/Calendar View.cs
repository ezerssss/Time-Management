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
        string path = Application.StartupPath + @"\file.txt";
        string[] splitter = { "|#$#|" };
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_View));

        public Calendar_View()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            for (int x = 0; x < this.Controls.Count; x++)
            {
                enableDoubleBuff(this.Controls[x]);
            }
            checkAssignments();
        }

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            checkAssignments();
        }

        private void printCalendarTask(string time, string subject, string assignment, int verticalOffset)
        {
            string text = subject.ToUpper() + "  -  " + assignment;
            string display = text;

            Label heading = new Label();
            heading.Width = 200;
            heading.Height = 30;
            heading.Left = 8;
            heading.Top = 7;
            heading.Text = "Task/s for " + calendar.SelectionStart.ToString("MMM d");
            heading.Font = new Font("Questrial", 16);
            heading.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            assignmentScreen.Controls.Add(heading);

            Label timebox = new Label();     
            timebox.Top = verticalOffset * 65 + 54;
            timebox.Left = 40;
            timebox.Width = 85;
            timebox.Height = 46;
            timebox.Text = time;
            timebox.BackColor = Color.FromArgb(255, 180, 0);
            timebox.Font = new Font("Questrial", 14);
            timebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            timebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            assignmentScreen.Controls.Add(timebox);


            Label taskBox = new Label();
            ToolTip tp = new ToolTip();
            tp.ShowAlways = true; 
            taskBox.Top = verticalOffset * 65 + 64;
            taskBox.Left = 143;
            taskBox.Width = 187;
            taskBox.Height = 38;
            taskBox.Text = display;
            taskBox.AutoEllipsis = true;
            taskBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            taskBox.Font = new Font("Questrial", 13);
            taskBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            taskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tp.SetToolTip(taskBox, text);
            assignmentScreen.Controls.Add(taskBox);

            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(350, 85),
                Location = new Point(5, verticalOffset * 65 + 26),
                Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")))
            };
            assignmentScreen.Controls.Add(picture);
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
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                Data_Grid dg = new Data_Grid();
                dg.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(dg);
            }
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(lg);
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                add_task at = new add_task();
                at.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                EarlyBird.Instance.screenContainer.Controls.Add(at);
            }
        }

        private void links_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Calendar_View"))
            {
                links li = new links();
                li.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(li);
            }
        }
    }
}
