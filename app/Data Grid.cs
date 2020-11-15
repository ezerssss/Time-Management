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
    public partial class Data_Grid : UserControl
    {
       
        DataTable table = new DataTable();
        string path = Application.StartupPath + @"\file.txt";
        string[] x = { "|#$#|" };
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Grid));
        public Data_Grid()
        {
            InitializeComponent();
        }
        public int rowCounter = 0;
        private void Data_Grid_Load(object sender, EventArgs e)
        {
            //disables datagrid autohighlight on cells
            dayToday.Text = DateTime.Now.ToString("dd MMMM yyyy");

            showData();
        }

        private void updateButton(object sender, EventArgs e)
        {
            update(false,69);
        }
        public void showData()
        {
            table.Clear();
            string[] lines = getFile();
            if (lines.Length < 1)
            {
                //table.Rows.Add("you", "take a break", "for", "now", "false

            }
            else {
                string[] elements; // get the elements from a line;
                for (int i = 0; i < lines.Length; i++)
                {
                    elements = lines[i].Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                                                                           //makes the date to a short one - Nov/08/2020
                    elements[2] = DateTime.Parse(elements[2]).ToString("MM/dd");
                    //table.Rows.Add(elements[4],elements[2],elements[3],elements[0],elements[1]); //adds element to a ro
                    printTaskLine(elements, i);
                }
                rowCounter = 0;
            }
        }
        public string[] getFile()
        {
            string[] file = File.ReadAllLines(path);
            return file;
        }
        public void update(bool removeRow, int whatRow) {
            panel1.Controls.Clear();
            List<string> temp = new List<string>();
            temp = File.ReadAllLines(path).ToList();
            if (temp.Count() > 0) {
                List<int> checkedMark = new List<int>();
                if (removeRow == true)
                {
                    checkedMark.Add(whatRow);
                    //temp.RemoveAt()
                }


                checkedMark.Sort();
                for (int j = checkedMark.Count() - 1; j >= 0; j--)
                {
                    temp.RemoveAt(checkedMark[j]);
                }
                File.WriteAllText(path, String.Empty);
                File.WriteAllLines(path, temp);
                getFile();
                checkedMark.Clear();
            }
            showData();
            temp.Clear();
        }

        private void printTaskLine(string[] displayElements, int verticalOffset)
        {
            string text = displayElements[1];
            string display = text;
            if (text.Length > 22)
            {
                display = text.Substring(0, 22);
                display += "...";
            }

            verticalOffset = verticalOffset * 30 + 5;

            Button removeTask = new Button();
            panel1.Controls.Add(removeTask);
            removeTask.Top = verticalOffset + 2;
            removeTask.Left = 2;
            removeTask.Width = 20;
            removeTask.Height = 20;
            removeTask.Name = "button" + rowCounter;
            removeTask.Image = ((System.Drawing.Image)(resources.GetObject("referenceButton.Image")));
            removeTask.FlatAppearance.BorderSize = 1;
            removeTask.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            removeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            Label datebox = new Label();
            panel1.Controls.Add(datebox);
            datebox.Top = verticalOffset;
            datebox.Left = removeTask.Left + removeTask.Width + 5;
            datebox.Width = 50;
            datebox.Height = 24;
            datebox.Text = displayElements[2];
            datebox.Font = new Font("Bahnschrift SemiBold", 11);
            datebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            datebox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel1.Image")));
            datebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            datebox.Name = "date" + rowCounter;

            Label timebox = new Label();
            panel1.Controls.Add(timebox);
            timebox.Top = verticalOffset;
            timebox.Left = datebox.Left + datebox.Width;
            timebox.Width = 80;
            timebox.Height = 24;
            timebox.Text = displayElements[3];
            timebox.Font = new Font("Bahnschrift SemiBold", 10);
            timebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            timebox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel2.Image")));
            timebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            timebox.Name = "time" + rowCounter;

            Label subjbox = new Label();
            panel1.Controls.Add(subjbox);
            subjbox.Top = verticalOffset;
            subjbox.Left = timebox.Left + timebox.Width;
            subjbox.Width = 64;
            subjbox.Height = 24;
            subjbox.Text = displayElements[0];
            subjbox.Font = new Font("Bahnschrift SemiBold", 10);
            subjbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            subjbox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel3.Image")));
            subjbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            subjbox.Name = "subj" + rowCounter;

            TextBox taskBox = new TextBox();
            ToolTip tp = new ToolTip();
            tp.ShowAlways = true;
            panel1.Controls.Add(taskBox);
            taskBox.Top = verticalOffset + 2;
            taskBox.Left = subjbox.Left + subjbox.Width + 5;
            taskBox.Width = 220;
            taskBox.Text = display;
            taskBox.ReadOnly = true;
            taskBox.Font = new Font("Bahnschrift SemiBold", 11);
            taskBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            taskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            taskBox.Name = "task" + rowCounter;
            tp.SetToolTip(taskBox, text);

            rowCounter++;
            removeTask.Click += new EventHandler(removeTask_Click);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(cv);
            }
        }
        private void removeTask_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Bollocks");
            Button btn = (Button)sender;
            for (int g = 0; g < rowCounter + 1; g++)
            {
                //System.Windows.Forms.MessageBox.Show("Balls" + g);
                if (btn.Name == ("button" +g))
                {
                    /*Label dyt1 = panel1.Controls.Find(("date" + g), true).FirstOrDefault() as Label;
                    dyt1.Dispose();
                    Label tym1 = panel1.Controls.Find(("time" + g), true).FirstOrDefault() as Label;
                    tym1.Dispose();
                    Label sub1 = panel1.Controls.Find(("subj" + g), true).FirstOrDefault() as Label;
                    sub1.Dispose();
                    TextBox tsk1 = panel1.Controls.Find(("task" + g), true).FirstOrDefault() as TextBox;
                    tsk1.Dispose();
                    /*for (int t = g + 1 ; t < rowCounter + 1; t++)
                    {
                        Label dyt = panel1.Controls.Find(("date"+t), true).FirstOrDefault() as Label;
                        dyt.Width -= 30;
                        Label tym = panel1.Controls.Find(("time"+t), true).FirstOrDefault() as Label;
                        tym.Width -= 30;
                        Label sub = panel1.Controls.Find(("subj"+t), true).FirstOrDefault() as Label;
                        sub.Width -= 30;
                        TextBox tsk = panel1.Controls.Find(("task"+t), true).FirstOrDefault() as TextBox;
                        tsk.Width -= 30;
                    }*/
                    update(true,g);
                    break;
                }
            }
        }
        private void addTask_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                add_task at = new add_task();
                at.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(at);
            }
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(lg);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void referenceLabel_Click(object sender, EventArgs e)
        {

        }

        private void referenceLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
