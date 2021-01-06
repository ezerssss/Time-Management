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
    public partial class logOutUser : UserControl
    {
        string accPath = Application.StartupPath + @"\acc.txt";
        public logOutUser()
        {
            InitializeComponent();
            List<string> details = new List<string>();
            using (StreamReader sr = new StreamReader(accPath))
            {
                String ReadLine;
                while ((ReadLine = sr.ReadLine()) != null)
                    details.Add(ReadLine);
            }
            String userNameFromFile = details[1].ToUpper();
            userNameInitial.Text = userNameFromFile.Substring(0,1);
            userNameDisplay.Text = userNameFromFile;
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
            EarlyBird.Instance.screenContainer.Controls.Clear();
            EarlyBird.Instance.screenContainer.Controls.Add(lg);
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Calendar_View cv = new Calendar_View();
            cv.Dock = DockStyle.Fill;
            EarlyBird.Instance.screenContainer.Controls.Clear();
            EarlyBird.Instance.screenContainer.Controls.Add(cv);
        }
    }
}
