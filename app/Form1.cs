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

        string[] x = { "|#$#|" };
        //ang location kay tupad rajud sa .exe file
        string path = Application.StartupPath + @"\file.txt";
        string accPath = Application.StartupPath + @"\acc.txt";
        string local = Application.StartupPath + @"\local.txt";
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            enableDoubleBuff(screen);
        }

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
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
            if (!File.Exists(local))
            {
                using (StreamWriter sw = new StreamWriter(local)) { }
                Application.Restart();
            }
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path)) { }
                Application.Restart();
            }
            else
            {
                sortList();
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
                    APIFunction apiFunc = new APIFunction();
                    apiFunc.Dock = DockStyle.Fill;
                    screen.Controls.Add(apiFunc);
                }

            }
            else
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                screen.Controls.Add(cv);
            }


        }

        public void sortList() {          
            List<string> list = new List<string>();
            string readLine;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((readLine = sr.ReadLine()) != null) {
                    list.Add(readLine);
                }
                    
            }
            using (StreamReader sr = new StreamReader(local))
            {
                while ((readLine = sr.ReadLine()) != null) {
                    list.Add(readLine);
                }
            }
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
