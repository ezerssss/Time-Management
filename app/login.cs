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
using System.Diagnostics;

namespace app
{
    public partial class login : UserControl
    {
        string accPath = Application.StartupPath + @"\acc.txt";
        bool hide;
        public login()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, MouseEventArgs e)
        {
            if (username.Text == "Enter username")
                  username.Text = "";
            username.ForeColor = Color.Black;
        }

        private void password_Click(object sender, MouseEventArgs e)
        {
            if (password.Text == "Enter password") 
                password.Text = "";
            password.ForeColor = Color.Black;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "" || username.Text == "Enter username" || password.Text == "Enter password") {
                MessageBox.Show("Invalid username or password");
            }
            else {
                File.WriteAllText(accPath, String.Empty);
                List<string> lines = new List<string>();
                lines.Add("true");
                lines.Add(username.Text);
                lines.Add(password.Text);
                File.WriteAllLines(accPath, lines);
                resetText();
                afterLogin();
            }
        }

        private void resetText()
        {
            username.Text = "Enter username";
            username.ForeColor = Color.LightGray;
            password.Text = "Enter password";
            password.PasswordChar = '*';
            hide = false;
            password.ForeColor = Color.LightGray;
            username.Enabled = false;
            username.Enabled = true;
            password.Enabled = false;
            password.Enabled = true;
        }
        private void login_Load(object sender, EventArgs e)
        {
            resetText();
            if (!File.Exists(accPath))
            {
                File.Create(accPath);
                MessageBox.Show("Account File created");
            }
        }

        private void showPass(object sender, EventArgs e)
        {
            if (hide)
            {
                password.PasswordChar = '*';
                hide = false;
            }
            else
            {
                password.PasswordChar = '\0';
                hide = true;
            }     
        }

        private void afterLogin()
        {
            if (Form1.Instance.screenContainer.Controls.ContainsKey("login"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(cv);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            afterLogin();
        }
    }
}
