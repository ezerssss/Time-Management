﻿using System;
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
        string path = Application.StartupPath + @"\file.txt";
        string local = Application.StartupPath + @"\local.txt";
        string ignored = Application.StartupPath + @"\ignored.txt";
        string[] x = { "|#$#|" };
        List<string> removeList = new List<string>();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Grid));

        IDictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        bool showAll = true;

        public Data_Grid()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Maximum = -1;
            panel1.HorizontalScroll.SmallChange = 0;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScroll = true;
            this.DoubleBuffered = true;
            enableDoubleBuff(panel1);
        }

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        public int rowCounter = 0;

        private void Data_Grid_Load(object sender, EventArgs e)
        {
            //disables datagrid autohighlight on cells
            dayToday.Text = "Today is " + DateTime.Now.ToString("dd MMMM yyyy");
            showData();
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

        private void updateButton(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                if (CheckForInternetConnection())
                {
                    APIFunction apiFunc = new APIFunction();
                    apiFunc.Dock = DockStyle.Fill;
                    while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                    GC.Collect();
                    EarlyBird.Instance.screenContainer.Controls.Add(apiFunc);
                }
                else
                    MessageBox.Show("No Internet Connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showData()
        {
            noTaskPic.Visible = true;
            removeList.Clear();
            panel1.Controls.Clear();
            string readLine;
            int i = 0;
            dictionary.Clear();
            IDictionary<DateTime, int> dates = new Dictionary<DateTime, int>();
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    while ((readLine = sr.ReadLine()) != null)
            //    {
            //        if (!File.ReadAllText(ignored).Contains(readLine))
            //        {
            //            string[] elements = readLine.Split(x, StringSplitOptions.None); //splits the line into elements and stores it
            //                                                                            //makes the date to a short one - Nov/08/2020
            //                                                                            //MessageBox.Show(elements[2]);
            //            DateTime dateTime, dateToDetermine = new DateTime();
            //            string date = "---";
            //            if (DateTime.TryParse(elements[2], out dateTime))
            //            {
            //                if (!dates.ContainsKey(dateTime.AddDays(-3)))
            //                {
            //                    dates.Add(dateTime.AddDays(-3), 1);
            //                    dateToDetermine = dateTime.AddDays(-3);
            //                }
            //                else
            //                {
            //                    if (dates[dateTime.AddDays(-3)] < 5)
            //                    {
            //                        dates[dateTime.AddDays(-3)] += 1;
            //                        dateToDetermine = dateTime.AddDays(-3);
            //                    }
            //                    else
            //                    {
            //                        int dayBefore = -1;
            //                        while (dates.ContainsKey(dateTime.AddDays(dayBefore - 3)) && dates[dateTime.AddDays(dayBefore - 3)] >= 5)
            //                            dayBefore -= 1;
            //                        if (!dates.ContainsKey(dateTime.AddDays(dayBefore - 3)))
            //                            dates.Add(dateTime.AddDays(dayBefore - 3), 1);
            //                        else
            //                            dates[dateTime.AddDays(dayBefore - 3)] += 1;
            //                        dateToDetermine = dateTime.AddDays(dayBefore - 3);
            //                    }
            //                }
            //                date = elements[2];
            //                MessageBox.Show(elements[2]);
            //                elements[2] = dateTime.ToString("MM/dd");
            //            }
            //            if (DateTime.Compare(dateToDetermine, DateTime.Now) <= 0 || elements[2] == "---")
            //            {
            //                if (!dictionary.ContainsKey(elements[2]))
            //                {
            //                    dictionary.Add(elements[2], new List<string>());
            //                    dictionary[elements[2]].Add(string.Join(x[0], elements));
            //                }
            //                else
            //                {
            //                    dictionary[elements[2]].Add(string.Join(x[0], elements));
            //                }
            //                printTaskLine(elements, i);
            //                removeList.Add(elements[0] + x[0] + elements[1] + x[0] + date + x[0] + elements[3] + x[0] + elements[4]);
            //                i++;
            //                foreach (var key in dictionary)
            //                {
            //                    Console.WriteLine(key);
            //                    Console.WriteLine(key.Key);
            //                    foreach (var value in key.Value)
            //                    {
            //                        Console.WriteLine("-" + value);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    rowCounter = 0;

            //}
            using (StreamReader sr = new StreamReader(path))
            {
                while ((readLine = sr.ReadLine()) != null)
                {
                    if (!File.ReadAllText(ignored).Contains(readLine))
                    {

                        string[] elements = readLine.Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                                                                                        //makes the date to a short one - Nov/08/2020
                                                                                        //MessageBox.Show(elements[2]);
                        if (!dictionary.ContainsKey(elements[2]))
                        {
                            dictionary.Add(elements[2], new List<string>());
                            dictionary[elements[2]].Add(string.Join(x[0], elements));
                        }
                        else
                        {
                            dictionary[elements[2]].Add(string.Join(x[0], elements));
                        }
                    }
                }
                foreach (var pair in dictionary)
                {
                    DateTime dateTime, dateToDetermine = new DateTime();
                    string date = "---";
                    if (DateTime.TryParse(pair.Key, out dateTime))
                    {
                        if (!dates.ContainsKey(dateTime.AddDays(-3)))
                        {
                            dates.Add(dateTime.AddDays(-3), 1);
                            dateToDetermine = dateTime.AddDays(-3);
                        }
                        else
                        {
                            if (dates[dateTime.AddDays(-3)] < 5)
                            {
                                dates[dateTime.AddDays(-3)] += 1;
                                dateToDetermine = dateTime.AddDays(-3);
                            }
                            else
                            {
                                int dayBefore = -1;
                                while (dates.ContainsKey(dateTime.AddDays(dayBefore - 3)) && dates[dateTime.AddDays(dayBefore - 3)] >= 5)
                                    dayBefore -= 1;
                                if (!dates.ContainsKey(dateTime.AddDays(dayBefore - 3)))
                                    dates.Add(dateTime.AddDays(dayBefore - 3), 1);
                                else
                                    dates[dateTime.AddDays(dayBefore - 3)] += 1;
                                dateToDetermine = dateTime.AddDays(dayBefore - 3);
                            }
                        }
                        date = pair.Key;
                        //elements[2] = dateTime.ToString("MM/dd"); murag important
                    }
                    if (DateTime.Compare(dateToDetermine, DateTime.Now) <= 0 || pair.Key == "---")
                    {
                        int verticalOffsets = i * 60 + 50;
                        Label collectiveDate = new Label();
                        if (pair.Key == "---")
                            collectiveDate.Text = "No deadline set";
                        else
                            collectiveDate.Text = pair.Key;
                        collectiveDate.Name = "colDate" + rowCounter;
                        collectiveDate.Width = panel1.Width-11;
                        collectiveDate.Height = 24;
                        collectiveDate.Left = 11;
                        collectiveDate.Font = new Font("Questrial", 11);
                        collectiveDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                        //collectiveDate.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel1.Image")));
                        collectiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        collectiveDate.Top = verticalOffsets;


                        panel1.Controls.Add(collectiveDate);

                        foreach (var value in pair.Value)
                        {
                            
                            string[] elements = value.Split(x, StringSplitOptions.None);
                            printTaskLine(elements, i);
                            removeList.Add(elements[0] + x[0] + elements[1] + x[0] + date + x[0] + elements[3] + x[0] + elements[4]);
                            // or pwede ata,,
                            //removeList.Add(value);
                            i++;
                        }
                        i++;                
                    }
                }


                rowCounter = 0;
            }
        }

        private void printTaskLine(string[] displayElements, int verticalOffset)
        {
            noTaskPic.Visible = false;
            string text = displayElements[1];
            string display = text;
            DateTime dateTime= new DateTime();
            displayElements[2] = dateTime.ToString("MM/dd"); 


            ToolTip tp = new ToolTip();
            tp.ShowAlways = true;

            Label heading = new Label();
            heading.Width = 200;
            heading.Height = 30;
            heading.Left = 8;
            heading.Top = 7;
            heading.Text = "Task/s";
            heading.Font = new Font("Questrial", 18);
            heading.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            panel1.Controls.Add(heading);
            panel1.Controls.Add(showAllTask);
            panel1.Controls.Add(button1);

            Button removeTask = new Button();
            removeTask.Top = verticalOffset * 60 + 95;

            removeTask.Left = 1;
            removeTask.Width = 22;
            removeTask.Height = 22;
            removeTask.Name = "button" + rowCounter;
            removeTask.Image = ((System.Drawing.Image)(resources.GetObject("referenceButton.Image")));
            removeTask.FlatAppearance.BorderSize = 0;
            removeTask.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            removeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeTask.Cursor = Cursors.Hand;


            //Label datebox = new Label();
            //datebox.Top = verticalOffset;
            //datebox.Left = removeTask.Left + removeTask.Width + 5;
            //datebox.Width = 50;
            //datebox.Height = 24;
            //datebox.Text = displayElements[2];
            //datebox.Font = new Font("Questrial", 10);
            //datebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //datebox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel1.Image")));
            //datebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //datebox.Name = "date" + rowCounter;


            Label timebox = new Label();
            timebox.Top = verticalOffset * 60 + 93;
            timebox.Left = removeTask.Left + removeTask.Width + 10;
            timebox.Width = 90;
            timebox.Height = 24;
            timebox.Text = " " + displayElements[3];
            timebox.Font = new Font("Questrial", 14);
            timebox.BackColor = Color.FromArgb(255, 180, 0);
            timebox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //timebox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel2.Image")));
            timebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            timebox.Name = "time" + rowCounter;
            

            Label subjbox = new Label();
            subjbox.Top = verticalOffset * 60 + 93;

            subjbox.Left = timebox.Left + timebox.Width + 14;
            subjbox.Width = 199;
            subjbox.AutoEllipsis = true;
            subjbox.Height = 24;
            subjbox.Text = " " + displayElements[0].ToUpper() + " - " + display;
            subjbox.Font = new Font("Questrial", 13);
            subjbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            subjbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            //subjbox.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel3.Image")));
            subjbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            subjbox.Name = "subj" + rowCounter;
            tp.SetToolTip(subjbox, displayElements[0] + " - " + display);
            

            //Label taskBox = new Label();
            //taskBox.Top = verticalOffset * 30 + 57;
            //taskBox.Left = subjbox.Left + subjbox.Width - 7;
            //taskBox.Width = 120;
            //taskBox.AutoEllipsis = true;
            //taskBox.Text = "- " + display;
            //taskBox.Font = new Font("Questrial", 13);
            //taskBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //taskBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E18829");
            //taskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //taskBox.Name = "task" + rowCounter;

            //tp.SetToolTip(taskBox, text);

            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(350, 84),
                Location = new Point(0, verticalOffset * 60 + 55),
                Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")))
            };

            panel1.Controls.Add(removeTask);
            //panel1.Controls.Add(datebox); fakyu
            panel1.Controls.Add(timebox);
            panel1.Controls.Add(subjbox);
            //panel1.Controls.Add(taskBox); fakyu
            panel1.Controls.Add(picture);

            rowCounter++;
            removeTask.Click += new EventHandler(removeTask_Click);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(cv);
            }
        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            int count = int.Parse(name.Remove(name.IndexOf("button"), name.IndexOf("button") + 6));
            string[] elementsForTitle = removeList[count].Split(x, StringSplitOptions.None);
            PopUp pp = new PopUp();
            pp.Text = elementsForTitle[1];
            DialogResult choice = pp.ShowDialog();                  
            if (choice == DialogResult.Yes)
            {
                List<string> taskList = new List<string>();
                List<string> localList = new List<string>();
                string readTask;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((readTask = sr.ReadLine()) != null)
                        taskList.Add(readTask);
                }
                using (StreamReader sr = new StreamReader(local))
                {
                    while ((readTask = sr.ReadLine()) != null)
                        localList.Add(readTask);
                }
                string[] elements = removeList[count].Split(x, StringSplitOptions.None);          
                if (bool.Parse(elements[4]))
                {
                    localList.Remove(removeList[count]);
                    taskList.Remove(removeList[count]);
                    File.WriteAllText(local, String.Empty);
                    using (StreamWriter sw = new StreamWriter(local))
                    {
                        foreach (var line in localList)
                            sw.WriteLine(line);
                    }
                }

                else
                {
                    taskList.Remove(removeList[count]);
                }
                File.WriteAllText(path, String.Empty);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var line in taskList)
                        sw.WriteLine(line);
                }
            }
            string[] element = removeList[count].Split(x, StringSplitOptions.None);
            if (!bool.Parse(element[4]) && choice == DialogResult.Ignore)
            {
                string reader;
                List<string> ignoredList = new List<string>();
                using (StreamReader sr = new StreamReader(ignored))
                {
                    while ((reader = sr.ReadLine()) != null)
                        ignoredList.Add(reader);
                }
                ignoredList.Add(removeList[count]);
                File.WriteAllText(ignored, String.Empty);
                using (StreamWriter sw = new StreamWriter(ignored))
                {
                    foreach (var lines in ignoredList)
                        sw.WriteLine(lines);
                }
            }
            else if (bool.Parse(element[4]) && choice == DialogResult.Ignore) {
                List<string> taskList = new List<string>();
                List<string> localList = new List<string>();
                string readTask;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((readTask = sr.ReadLine()) != null)
                        taskList.Add(readTask);
                }
                using (StreamReader sr = new StreamReader(local))
                {
                    while ((readTask = sr.ReadLine()) != null)
                        localList.Add(readTask);
                }
                string[] elements = removeList[count].Split(x, StringSplitOptions.None);
                if (bool.Parse(elements[4]))
                {
                    localList.Remove(removeList[count]);
                    taskList.Remove(removeList[count]);
                    File.WriteAllText(local, String.Empty);
                    using (StreamWriter sw = new StreamWriter(local))
                    {
                        foreach (var line in localList)
                            sw.WriteLine(line);
                    }
                }

                else
                {
                    taskList.Remove(removeList[count]);
                }
                File.WriteAllText(path, String.Empty);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var line in taskList)
                        sw.WriteLine(line);
                }
            }
            else if (choice == DialogResult.No)
            {
                //nothing
            }
            while (pp.Controls.Count > 0) pp.Controls[0].Dispose();
            GC.Collect();
            if (showAll)
            {
                showData();
            }
            else
            {
                showAllFuntion();
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                add_task at = new add_task();
                at.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                EarlyBird.Instance.screenContainer.Controls.Add(at);
            }
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(lg);
            }
        }

        private void showAllTask_Click(object sender, EventArgs e)
        {
            
            if (showAll)
            {           
                showAllTask.Image = ((System.Drawing.Image)(resources.GetObject("todo_image.Image")));
                showAllTask.Text = "";
                dayToday.Text = "All Tasks";
                showAllFuntion();
            }
            else
            {
                showAllTask.Image = ((System.Drawing.Image)(resources.GetObject("show_image.Image")));
                showAllTask.Text = "";
                showAll = true;
                dayToday.Text = "Today is " + DateTime.Now.ToString("dd MMMM yyyy");
                showData();
            }
        }

        //private void showAllFuntion()
        //{
        //    string readline;
        //    int i = 0;
        //    removeList.Clear();
        //    panel1.Controls.Clear();
        //    panel1.Refresh();
        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        while ((readline = sr.ReadLine()) != null)
        //        {
        //            if (!File.ReadAllText(ignored).Contains(readline)) {
        //                string[] elements = readline.Split(x, StringSplitOptions.None);
        //                DateTime dateTime = new DateTime();
        //                string date = "---";
        //                if (DateTime.TryParse(elements[2], out dateTime))
        //                {
        //                    date = elements[2];
        //                    elements[2] = dateTime.ToString("MM/dd");
        //                }
        //                printTaskLine(elements, i);
        //                removeList.Add(elements[0] + x[0] + elements[1] + x[0] + date + x[0] + elements[3] + x[0] + elements[4]);
        //                i++;
        //            }
        //        }
        //    }
        //    rowCounter = 0;
        //    showAll = false;
        //}

        private void showAllFuntion()
        {
            string readline;
            int i = 0;
            removeList.Clear();
            panel1.Controls.Clear();
            panel1.Refresh();
            dictionary.Clear();

            Label heading = new Label();
            heading.Width = 200;
            heading.Height = 30;
            heading.Left = 8;
            heading.Top = 7;
            heading.Text = "Task/s";
            heading.Font = new Font("Questrial", 18);
            heading.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            panel1.Controls.Add(heading);

            using (StreamReader sr = new StreamReader(path))
            {
                while ((readline = sr.ReadLine()) != null)
                {
                    if (!File.ReadAllText(ignored).Contains(readline))
                    {
                        string[] elements = readline.Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                                                                                        //makes the date to a short one - Nov/08/2020
                                                                                        //MessageBox.Show(elements[2]);
                        if (!dictionary.ContainsKey(elements[2]))
                        {
                            dictionary.Add(elements[2], new List<string>());
                            dictionary[elements[2]].Add(string.Join(x[0], elements));
                        }
                        else
                        {
                            dictionary[elements[2]].Add(string.Join(x[0], elements));
                        }
                    }
                }
                foreach (var pair in dictionary)
                {
                    DateTime dateTime = new DateTime();
                    string date = "---";
                    if (DateTime.TryParse(pair.Key, out dateTime))
                    {
                        date = pair.Key;
                        //elements[2] = dateTime.ToString("MM/dd");
                    }
                    int verticalOffset = i * 60 + 50;
                    Label collectiveDate = new Label();
                    if (pair.Key == "---")
                        collectiveDate.Text = "No deadline set";
                    else
                        collectiveDate.Text = pair.Key;
                    collectiveDate.Name = "colDate" + rowCounter;
                    collectiveDate.Width = panel1.Width - 11;
                    collectiveDate.Height = 24;
                    collectiveDate.Left = 11;
                    collectiveDate.Font = new Font("Questrial", 11);
                    collectiveDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    //collectiveDate.Image = ((System.Drawing.Image)(resources.GetObject("referenceLabel1.Image")));
                    collectiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    collectiveDate.Top = verticalOffset;
                    //i++;
                    panel1.Controls.Add(collectiveDate);
                    foreach (var value in pair.Value)
                    {
                        string[] elements = value.Split(x, StringSplitOptions.None);
                        printTaskLine(elements, i);
                        removeList.Add(elements[0] + x[0] + elements[1] + x[0] + date + x[0] + elements[3] + x[0] + elements[4]);
                        i++;
                    }
                    i++;
                }
                        
            }
            rowCounter = 0;
            showAll = false;
        }

        private void links_Click(object sender, EventArgs e)
        {
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("Data_Grid"))
            {
                links li = new links();
                li.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                this.Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(li);
            }
        }
    }
}
