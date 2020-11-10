using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace app
{
    public partial class Calendar_View : UserControl
    {
        string path;
        string[] splitter = { "|#$#|" };
        List<string> lines = new List<string>();

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

        private void checkAssignments()
        {
            lines = File.ReadAllLines(path).ToList();
            assignmentScreen.Text = "";
            toDoLabel.Text = calendar.SelectionStart.ToString("MMM/dd/yyyy");
            bool assignment = false;
            foreach (string line in lines)
            {
                string[] task = line.Split(splitter, StringSplitOptions.None);
                if (DateTime.Parse(task[2]).ToString("MMM/dd/yyyy") == calendar.SelectionStart.ToString("MMM/dd/yyyy"))
                {
                    assignmentScreen.Text += task[0] + " - " + task[1] + Environment.NewLine;
                    assignment = true;
                }
            }
            if (!assignment)
            {
                assignmentScreen.Text = "None! YAY :)";
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
