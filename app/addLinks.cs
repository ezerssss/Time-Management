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
    public partial class addLinks : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addLinks));
        string link = Application.StartupPath + @"\links.txt";
        List<string> links = new List<string>();
        string x = "|#$#|";

        public addLinks()
        {
            InitializeComponent();
        }

        private void addLinks_Load(object sender, EventArgs e)
        {
            hours.Text = "01";
            minutes.Text = "00";
            day.Text = "AM";           
            string readLine;
            using (StreamReader sr = new StreamReader(link))
            {
                while ((readLine = sr.ReadLine()) != null)
                {
                    links.Add(readLine);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        string[] seperator = { "_" };

        private void subject_Click(object sender, EventArgs e)
        {
            if (subject.Text == "Enter subject name")
                subject.Text = "";
            subject.ForeColor = Color.Black;
        }

        List<string> days = new List<string>();

        private void repeat_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name.Contains("_u"))
            {
                btn.Image = ((System.Drawing.Image)(resources.GetObject("clickedPic.Image")));
                btn.Name = btn.Name.Split(seperator, StringSplitOptions.None)[0] + "_c";
                days.Add(btn.Name.Split(seperator, StringSplitOptions.None)[0]);
            }
            else
            {
                btn.Image = ((System.Drawing.Image)(resources.GetObject("notClickPic.Image")));
                btn.Name = btn.Name.Split(seperator, StringSplitOptions.None)[0] + "_u";
                days.Remove(btn.Name.Split(seperator, StringSplitOptions.None)[0]);
            }
        }

        public bool checkLinkUrl(string r)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(r, UriKind.Absolute, out uriResult)
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (days.Count < 1 || subject.Text == "Enter subject name" || subject.Text == "" || linkText.Text == "Enter Link" || linkText.Text == "")
            {
                MessageBox.Show("Invalid input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkLinkUrl(linkText.Text))
            {
                MessageBox.Show("Invalid Link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string dayClicked = "";
                foreach (var d in days)
                {
                    dayClicked += d;
                }
                links.Add(hours.Text + ":" + minutes.Text + day.Text + x + dayClicked + x + subject.Text + x + linkText.Text);
                using (StreamWriter sw = new StreamWriter(link)) 
                {
                    foreach (var line in links)
                    {
                        sw.WriteLine(line);
                    }
                }
                EarlyBird.Instance.sortListLink();
                GC.Collect();
                MessageBox.Show("Add link successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void linkText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void linkText_Click(object sender, EventArgs e)
        {
            if (linkText.Text == "Enter Link")
                linkText.Text = "";
            linkText.ForeColor = Color.Black;
        }
    }
}
