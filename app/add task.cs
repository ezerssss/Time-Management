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
        string path = Application.StartupPath + @"\file.txt";
        string[] x = { "|#$#|" };
        public add_task()
        {
            InitializeComponent();
        }

        private void addTask(object sender, EventArgs e)
        {
            if (subject.Text == "" || task.Text == "" || hours.Text == "" || minutes.Text == "" || day.Text == "") {
                MessageBox.Show("Invalid Inputs!");
            }
            else
            {
                List<string> list = new List<string>();
                String readLine;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((readLine = sr.ReadLine()) != null) {
                        list.Add(readLine);
                    }
                    sr.Close();
                }
                readLine = subject.Text + x[0] + task.Text + x[0] + date.Text + x[0] + hours.Text + ":" + minutes.Text + day.Text + x[0] + "false";
                list.Add(readLine);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var lines in list)
                        sw.WriteLine(lines);
                }
                resetText();
                MessageBox.Show("add task successful");
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
            day.Text = "AM";
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
            if (Form1.Instance.screenContainer.Controls.ContainsKey("add_task"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(cv);
            }
        }
    }
}
