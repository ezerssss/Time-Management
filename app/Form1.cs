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
        string accPath = Application.StartupPath + @"\acc.txt";
        public Form1()
        {
            InitializeComponent();
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Form1();
                return _obj;
            }
        }

        public Panel screenContainer
        {
            get { return screen; }
            set { screen = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            if (!File.Exists(path))
            {
                File.Create(path);
                Application.Restart();
            }
            if (!File.Exists(accPath))
            {
                using (StreamWriter writer = new StreamWriter(accPath))
                {
                    writer.WriteLine("false");
                }
            }

            if (CheckForInternetConnection())
            {
                string[] checkLogin = File.ReadAllLines(accPath);
                if (checkLogin[0] == "false")
                {
                    login lg = new login();
                    lg.Dock = DockStyle.Fill;
                    screen.Controls.Add(lg);
                }
                else
                {
                    Calendar_View cv = new Calendar_View();
                    cv.Dock = DockStyle.Fill;
                    screen.Controls.Add(cv);
                }
            }
            else
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                screen.Controls.Add(cv);
            }
            

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

        private void screen_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start.X, p.Y - this.start.Y);
            }
        }

        private void screen_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
