﻿using System;
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
    public partial class logOutUser : UserControl
    {
        string accPath = Application.StartupPath + @"\acc.txt";
        public logOutUser()
        {
            InitializeComponent();
            var pos = this.PointToScreen(userNameInitial.Location);
            pos = pictureBox2.PointToClient(pos);
            userNameInitial.Parent = pictureBox2;
            userNameInitial.Location = pos;
            List<string> details = new List<string>();
            using (StreamReader sr = new StreamReader(accPath))
            {
                String ReadLine;
                while ((ReadLine = sr.ReadLine()) != null)
                    details.Add(ReadLine);
            }
            userNameInitial.Text = details[1] + "!";
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            string accPath = Application.StartupPath + @"\acc.txt";
            using (StreamWriter sw = new StreamWriter(accPath))
            {
                sw.WriteLine("false");
            }
            login lg = new login();
            lg.Dock = DockStyle.Fill;
            while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
            GC.Collect();
            EarlyBird.Instance.screenContainer.Controls.Add(lg);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Calendar_View cv = new Calendar_View();
            cv.Dock = DockStyle.Fill;
            while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
            GC.Collect();
            EarlyBird.Instance.screenContainer.Controls.Add(cv);
        }
    }
}
