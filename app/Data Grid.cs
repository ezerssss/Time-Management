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
            if (Form1.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                APIFunction apiFunc = new APIFunction();
                apiFunc.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(apiFunc);
            }
        }

        public void showData()
        {
            panel1.Controls.Clear();
            table.Clear();
            string readLine;
            int i = 0;
            IDictionary<DateTime, int> dates = new Dictionary<DateTime, int>();
            using (StreamReader sr = new StreamReader(path)) 
            {
                while ((readLine = sr.ReadLine()) != null)
                {
                    string[] elements = readLine.Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                    //makes the date to a short one - Nov/08/2020
                    DateTime dateTime, dateToDetermine = new DateTime();
                    if (DateTime.TryParse(elements[2], out dateTime))
                    {
                        if (!dates.ContainsKey(dateTime.AddDays(-2)))
                        {
                            dates.Add(dateTime.AddDays(-2), 1);
                            dateToDetermine = dateTime.AddDays(-2);
                        }     
                        else
                        {
                            if (dates[dateTime.AddDays(-2)] < 5)
                            {
                                dates[dateTime.AddDays(-2)] += 1;
                                dateToDetermine = dateTime.AddDays(-2);
                            }                         
                            else
                            {
                                int dayBefore = -1;
                                while (dates.ContainsKey(dateTime.AddDays(dayBefore-2)) && dates[dateTime.AddDays(dayBefore-2)] >= 5)
                                    dayBefore -= 1;
                                if (!dates.ContainsKey(dateTime.AddDays(dayBefore-2)))
                                    dates.Add(dateTime.AddDays(dayBefore-2), 1);
                                else
                                    dates[dateTime.AddDays(dayBefore-2)] += 1;
                                dateToDetermine = dateTime.AddDays(dayBefore-2);
                            }                                       
                        }
                        elements[2] = dateTime.ToString("MM/dd");
                    }
                    if (DateTime.Compare(dateToDetermine, DateTime.Now) <= 0 || elements[2] == "---")
                    {
                        printTaskLine(elements, i);
                        i++;
                    }                            
                }
                rowCounter = 0;
            }
        }

        private void printTaskLine(string[] displayElements, int verticalOffset)
        {
            string text = displayElements[1];
            string display = text;
            if (text.Length > 16)
            {
                display = text.Substring(0, 17);
                display += "...";
            }

            verticalOffset = verticalOffset * 30 + 5;

            TextBox taskBox = new TextBox();
            ToolTip tp = new ToolTip();
            tp.ShowAlways = true;

            Button removeTask = new Button();
            panel1.Controls.Add(removeTask);
            removeTask.Top = verticalOffset + 2;
            removeTask.Left = 2;
            removeTask.Width = 22;
            removeTask.Height = 22;
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
            datebox.Text = " " + displayElements[2];
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
            timebox.Text = " " + displayElements[3];
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
            subjbox.Text = " " + displayElements[0];
            subjbox.Font = new Font("Bahnschrift SemiBold", 10);
            subjbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            subjbox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel3.Image")));
            subjbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            subjbox.Name = "subj" + rowCounter;
            tp.SetToolTip(subjbox, displayElements[0]);
            
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
            List<string> taskList = new List<string>();
            string readTask;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((readTask = sr.ReadLine()) != null)
                    taskList.Add(readTask);
            }
            Button btn = (Button)sender;
            string name = btn.Name;
            string count = name.Remove(name.IndexOf("button"), name.IndexOf("button") + 6);
            taskList.RemoveAt(int.Parse(count));
            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var line in taskList)
                    sw.WriteLine(line);
            }
            showData();
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

    }
}
