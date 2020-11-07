using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        //ang location kay tupad rajud sa .exe file
        string path = Application.StartupPath + @"\file.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                MessageBox.Show("File created");
                Application.Restart();
                //^^^ incase nga naa problem with reading
            }

            //sets calendar user control to be default launch panel
            Calendar_View cv = new Calendar_View();
            cv.Dock = DockStyle.Fill;
            screen.Controls.Add(cv);



        }
        //array method for getting file, kay mu error usahay if ika daghan i declare
        private string[] getFile()
        {
            string[] file = File.ReadAllLines(path);
            return file;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool drag = false;
        private Point start = new Point(0, 0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start.X, p.Y - this.start.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void logo2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void logo2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start.X, p.Y - this.start.Y);
            }
        }

        private void logo2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start.X, p.Y - this.start.Y);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void task_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();

           // if (screen.Controls.ContainsKey("Task_Lists") || screen.Controls.ContainsKey("Calendar_View") || screen.Controls.ContainsKey("add_task"))
           // {
                Data_Grid dg = new Data_Grid();
                dg.Dock = DockStyle.Fill;
                screen.Controls.Add(dg);
            //}
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            //checks if panel is in task list or add task
           // if (screen.Controls.ContainsKey("Task_Lists") || screen.Controls.ContainsKey("add_task") || screen.Controls.ContainsKey("Data_Grid")) {

                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                screen.Controls.Add(cv);
            //}
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            //if (screen.Controls.ContainsKey("Task_Lists") || screen.Controls.ContainsKey("Calendar_View") || screen.Controls.ContainsKey("Data_Grid")) {

                add_task at = new add_task();
                at.Dock = DockStyle.Fill;
                screen.Controls.Add(at);
            //}

                
        }
    }
}
