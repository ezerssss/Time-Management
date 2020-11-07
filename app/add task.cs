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
            if (subject.Text == "" || task.Text == "" || hours.Text == "" || minutes.Text == "" || day.Text == "")
            {
                MessageBox.Show("Invalid Inputs!");
            }
            else
            {
                List<string> lines = getFile().ToList();
                lines.Add(subject.Text + x[0] + task.Text + x[0] + date.Text + x[0] + hours.Text + ":" + minutes.Text + day.Text + x[0] + "false");
                File.WriteAllLines(path, lines);
                resetText();
                Data_Grid dg = new Data_Grid();
                dg.addroooow();
                MessageBox.Show("add task successful");
            }
        }

        private void add_task_Load(object sender, EventArgs e)
        {
            resetText();
        }
        private string[] getFile() {
            string[] file = File.ReadAllLines(path);
            return file;
        }
        private void resetText() {
            hours.Text = "12";
            minutes.Text = "00";
            day.Text = "AM";
            date.Value = DateTime.Today;
            subject.Text = "";
            task.Text = "";
        }
    }
}
