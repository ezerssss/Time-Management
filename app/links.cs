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
    public partial class links : UserControl
    {
        string link = Application.StartupPath + @"\links.txt";
        string[] x = { "|#$#|" };     
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Grid));

        public links()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Maximum = -1;
            panel1.HorizontalScroll.SmallChange = 0;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScroll = true;
            this.DoubleBuffered = true;
            for (int x = 0; x < this.Controls.Count; x++)
            {
                enableDoubleBuff(this.Controls[x]);
            }
        }

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        ToolTip tpExpe = new ToolTip();

        int offset = 0;
        List<string> linklist = new List<string>();
        bool enabledExperimental = false;      

        private void load(object sender, EventArgs e)
        {
            button3.Parent = pictureBox2;
            button3.Location = new Point(30, 25);
            button1.Parent = pictureBox2;
            button1.Location = new Point(145, 25);

            comboBox1.Visible = false;
            processData(DateTime.Now.DayOfWeek.ToString());
            comboBox1.Text = DateTime.Now.ToString("dddd");
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(DateTime.Now.ToString("dddd"));
            //label1.Text = "Class Links for " + comboBox1.Text;
            expeFeatures.Checked = enabledExperimental;
            tpExpe.ShowAlways = true;
            tpExpe.SetToolTip(button4, "Automatically open links 10 minutes before the time set. If the app crashes please contact the developers.");
            if (enabledExperimental)
            {
                label2.Text = "ENABLED";
            }
            else
            {
                label2.Text = "DISABLED";
            }
        }
 

        private void processData(string day)
        {
            pictureBox1.Visible = false;
            offset = 0;
            while (panel1.Controls.Count > 0) panel1.Controls[0].Dispose();
            linklist.Clear();
            string readline;
            int boolClassLink = 0;
            enabledExperimental = false;
            try
            {
                using (StreamReader sr = new StreamReader(link))
                {
                    enabledExperimental = bool.Parse(sr.ReadLine());
                    while ((readline = sr.ReadLine()) != null)
                    {
                        if (readline.Contains(day))
                        {
                            linklist.Add(readline);
                            boolClassLink++;
                        }
                    }
                }
                if (boolClassLink == 0)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    foreach (var link in linklist)
                    {
                        printTaskLine(offset, link);
                        offset++;
                    }
                }
                comboBox1.Visible = true;
            }
            catch (IOException)
            {
                processData(day);
            }                   
        }

        private void printTaskLine(int offset, string r)
        {
            string[] elements = r.Split(x, StringSplitOptions.None);

            ToolTip tp = new ToolTip();
            tp.ShowAlways = true;

            Button removeTask = new Button();
            removeTask.Top = offset * 64 + 39;
            
            removeTask.Left = 0;
            removeTask.Width = 30;
            removeTask.Height = 23;
            removeTask.Image = ((System.Drawing.Image)(resources.GetObject("deleteImage.Image")));
            removeTask.FlatAppearance.BorderSize = 0;
            removeTask.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            removeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeTask.Cursor = Cursors.Hand;

            removeTask.Name = r;
            removeTask.Click += new EventHandler(removeTask_Click);


            Label timebox = new Label();
            timebox.Top = offset * 64 + 39;
            timebox.Left = 44;
            timebox.Width = 90;
            timebox.Height = 24;
            timebox.Text = elements[0];
            timebox.Font = new Font("Questrial", 14);
            timebox.BackColor = Color.FromArgb(255, 180, 0);
            timebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            timebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Label subjbox = new Label();
            subjbox.Top = offset * 64 + 39;

            subjbox.Left = timebox.Left + timebox.Width + 14;
            subjbox.Width = 70;
            subjbox.AutoEllipsis = true;
            subjbox.Height = 24;
            subjbox.Text = elements[2].ToUpper();
            subjbox.Font = new Font("Questrial", 13);
            subjbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            subjbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            subjbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tp.SetToolTip(subjbox, elements[2]);

            LinkLabel linkbox = new LinkLabel();
            linkbox.Top = offset * 64 + 45;

            linkbox.Left = subjbox.Left + subjbox.Width;
            linkbox.Width = 125;
            linkbox.AutoEllipsis = true;
            linkbox.Height = 24;
            linkbox.Text = elements[3];
            linkbox.LinkClicked += new LinkLabelLinkClickedEventHandler(linkClick);
            linkbox.Font = new Font("Questrial", 8);
            linkbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            linkbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            linkbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(350, 84),
                Location = new Point(9, offset * 64),
                Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")))
            };

            panel1.Controls.Add(removeTask);
            panel1.Controls.Add(timebox);
            panel1.Controls.Add(subjbox);
            panel1.Controls.Add(linkbox);
            panel1.Controls.Add(picture); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addLinks al = new addLinks();
            DialogResult choice = al.ShowDialog();
            while (al.Controls.Count > 0) al.Controls[0].Dispose();
            GC.Collect();
            EarlyBird.Instance.getLinkFile();
            GC.Collect();
            processData(DateTime.Now.DayOfWeek.ToString());
        }

        string[] linkTextSeperator = { "Text: " };

        private void linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] linkText = sender.ToString().Split(linkTextSeperator, StringSplitOptions.None);
            System.Diagnostics.Process.Start(linkText[1]);
        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            linklist.Remove(btn.Name);
            using (StreamWriter sw = new StreamWriter(link))
            {
                sw.WriteLine(enabledExperimental);
                foreach (var link in linklist)
                    sw.WriteLine(link);
            }         
            processData(DateTime.Now.DayOfWeek.ToString());
        }

        private void expeFeatures_Click(object sender, EventArgs e)
        {
            experimentalClickHandle();
        }

        private void experimentalClickHandle()
        {
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(link))
            {
                enabledExperimental = bool.Parse(sr.ReadLine());
                string readline;
                while ((readline = sr.ReadLine()) != null)
                {
                    list.Add(readline);
                }
            }
            if (expeFeatures.Checked)
            {
                using (StreamWriter sw = new StreamWriter(link))
                {
                    sw.WriteLine("True");
                    foreach (var line in list)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(link))
                {
                    sw.WriteLine("False");
                    foreach (var line in list)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            MessageBox.Show("Restarting EarlyBird", "Experimental Features", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
            processData(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("links"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                tpExpe.Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(cv);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("links"))
            {
                Data_Grid dg = new Data_Grid();
                dg.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                tpExpe.Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(dg);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expeFeatures.Checked = !enabledExperimental;
            experimentalClickHandle();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            expeFeatures.Checked = !enabledExperimental;
            experimentalClickHandle();
        }
    }
}
