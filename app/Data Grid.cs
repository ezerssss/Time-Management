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
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Task", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Status", typeof(bool));
            dataGrid.DataSource = table;
            showData();

        }
        private void updateButton(object sender, EventArgs e)
        {
            update();
        }
        public void showData()
        {
            table.Clear();
            string[] lines = getFile();
            string[] elements; // get the elements from a line;
            for (int i = 0; i < lines.Length; i++){
                elements = lines[i].Split(x, StringSplitOptions.None); //splits the line into elements and stores it
                table.Rows.Add(elements); //adds element to a row
            }
        }
        private string[] getFile()
        {
            string[] file = File.ReadAllLines(path);
            return file;
        }
        public void update() {
            List<string> oldLines = getFile().ToList();
            //kay if dili i show ang added task, dili siya mabasa sa update niya dili na ma show forever
            if (oldLines.Count != ((DataTable)this.dataGrid.DataSource).Rows.Count)
                showData();
            MessageBox.Show("old lines are " + oldLines.Count);
            List<string> lines = new List<string>();
            //always 5 man ang element, for now....
            string[] row = new string[5];
            //counts how many rows except the header
            int numRows = ((DataTable)this.dataGrid.DataSource).Rows.Count;
            MessageBox.Show("Before " + ((DataTable)this.dataGrid.DataSource).Rows.Count.ToString());
            for (int i = 0; i < numRows; i++)
            {
                //checks the values of every row under "status"
                if (dataGrid.Rows[i].Cells[4].Value.ToString() != "True") {
                    for (int j = 0; j < 5; j++) {
                        row[j] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                    lines.Add(row[0] + x[0] + row[1] + x[0] + row[2] + x[0] + row[3] + x[0] + row[4]);
                }
            }
            MessageBox.Show("Lines " + lines.Count.ToString());
            string[] empty = { };
            File.WriteAllLines(path, empty); //empties file to avoid duplication (alternate overwrite kay di ko kabaw lol)
            File.WriteAllLines(path, lines);
            showData();
        }

    }
}
