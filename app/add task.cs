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
    public partial class add_task : UserControl
    {
        string local = Application.StartupPath + @"\local.txt";
        string path = Application.StartupPath + @"\file.txt";
        bool subjectEnter = true;
        bool taskEnter = true;
        string[] x = { "|#$#|" };
        public add_task()
        {
            InitializeComponent();
        }

        private void addTask(object sender, EventArgs e)
        {
            if (subject.Text == "" || task.Text == "" || hours.Text == "" || minutes.Text == "" || day.Text == "" || subjectEnter || taskEnter) {
                MessageBox.Show("Invalid input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> list = new List<string>();
                String readLine;
                using (StreamReader sr = new StreamReader(local))
                {
                    while ((readLine = sr.ReadLine()) != null) {
                        list.Add(readLine);
                    }
                }
                readLine = subject.Text + x[0] + task.Text + x[0] + date.Text + x[0] + hours.Text + ":" + minutes.Text + day.Text + "|#$#|true";
                list.Add(readLine);
                using (StreamWriter sw = new StreamWriter(local))
                {
                    foreach (var lines in list)
                        sw.WriteLine(lines);
                }
                resetText();
                sortList(readLine);
                MessageBox.Show("Add task successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_task_Load(object sender, EventArgs e)
        {
            hours.IntegralHeight = false;
            minutes.IntegralHeight = false;
            resetText();
        }
        private void resetText() {
            hours.Text = "01";
            minutes.Text = "00";
            day.Text = "am";
            date.Value = DateTime.Today;
            subject.Text = "Enter subject of task";
            subject.ForeColor = Color.LightGray;
            task.Text = "Enter task detail";
            task.ForeColor = Color.LightGray;
            subject.Enabled = false;
            subject.Enabled = true;
            task.Enabled = false;
            task.Enabled = true;
        }

        private void key_down(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void task_Click(object sender, EventArgs e)
        {
            if (task.Text == "Enter task detail")
                task.Text = "";
            task.ForeColor = Color.Black;
        }

        private void subject_Click(object sender, EventArgs e)
        {
            if (subject.Text == "Enter subject of task")
                subject.Text = "";
            subject.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("add_task"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(cv);
            }
        }
        public void sortList(string rl)
        {
            List<string> list = new List<string>();
            string readLine;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((readLine = sr.ReadLine()) != null)
                    list.Add(readLine);
            }
            list.Add(rl);
            string[] elements;
            List<string> sortedList = new List<string>();
            List<string> openList = new List<string>();
            while (list.Count > 0)
            {
                string[] earliest = list.First().Split(x, StringSplitOptions.None);
                DateTime earliestDate = new DateTime();
                foreach (var line in list)
                {
                    elements = line.Split(x, StringSplitOptions.None);
                    string date = elements[2] + " " + elements[3];
                    if ((earliest[2] + " " + earliest[3]) != "--- ---")
                    {
                        earliestDate = Convert.ToDateTime(earliest[2] + " " + earliest[3]);
                    }
                    if (date != "--- ---")
                    {
                        int compare = DateTime.Compare(Convert.ToDateTime(Convert.ToDateTime(date).ToString("s")), Convert.ToDateTime(earliestDate.ToString("s")));
                        if (compare < 0)
                        {
                            earliest = elements;
                        }
                    }
                }
                string remove = earliest[0] + x[0] + earliest[1] + x[0] + earliest[2] + x[0] + earliest[3] + x[0] + earliest[4];
                list.Remove(remove);
                if ((earliest[2] + " " + earliest[3]) != "--- ---")
                    sortedList.Add(remove);
                else
                    openList.Add(remove);

            }
            foreach (var ls in openList)
                sortedList.Add(ls);

            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var lines in sortedList)
                {
                    sw.WriteLine(lines);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void subject_Enter(object sender, EventArgs e)
        {
            subject.Text = "";
            subject.ForeColor = Color.Black;
            subjectEnter = false;
        }

        private void task_Enter(object sender, EventArgs e)
        {
            task.Text = "";
            task.ForeColor = Color.Black;
            taskEnter = false;
        }

        private void subject_KeyDown(object sender, KeyEventArgs e)
        {
            subjectEnter = false;
        }

        private void task_KeyDown(object sender, KeyEventArgs e)
        {
            taskEnter = false;
        }
    }
}
