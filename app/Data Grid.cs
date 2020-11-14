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
        public Data_Grid()
        {
            InitializeComponent();
        }

        private void Data_Grid_Load(object sender, EventArgs e)
        {
            //disables datagrid autohighlight on cells
            dayToday.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            this.dataGrid.DefaultCellStyle.SelectionBackColor = this.dataGrid.DefaultCellStyle.BackColor;
            this.dataGrid.DefaultCellStyle.SelectionForeColor = this.dataGrid.DefaultCellStyle.ForeColor;
            header();
            dataGrid.DataSource = table;
            dataGrid.Columns[0].Width = 65;
            dataGrid.Columns[1].Width = 108;
            dataGrid.Columns[2].Width = 92;
            dataGrid.Columns[3].Width = 65;
            dataGrid.Columns[4].Width = 54;
            showData();
        }
        public void header() {
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Task", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Status", typeof(bool));
        }

        private void updateButton(object sender, EventArgs e)
        {
            update();
        }
        public void showData()
        {
            table.Clear();
            string[] lines = getFile();
            if (lines.Length < 1)
            {
                table.Rows.Add("you", "take a break", "for", "now", "false");
            }
            else {
                string[] elements; // get the elements from a line;
                for (int i = 0; i < lines.Length; i++)
                {
                    elements = lines[i].Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                                                                           //makes the date to a short one - Nov/08/2020
                    elements[2] = DateTime.Parse(elements[2]).ToString("MMM/dd/yyyy");
                    table.Rows.Add(elements); //adds element to a row
                }
                //disables datagrid sort feature
                foreach (DataGridViewColumn col in dataGrid.Columns) {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }
        public string[] getFile()
        {
            string[] file = File.ReadAllLines(path);
            return file;
        }
        public void update() {
            List<string> temp = new List<string>();
            temp = File.ReadAllLines(path).ToList();
            if (temp.Count() > 0) {
                List<int> checkedMark = new List<int>();
                int numRows = ((DataTable)this.dataGrid.DataSource).Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    //checks the values of every row under "status"
                    if (dataGrid.Rows[i].Cells[4].Value.ToString() == "True")
                    {
                        checkedMark.Add(i);
                    }

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
