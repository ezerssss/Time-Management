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
    public partial class login : UserControl
    {
        string accPath = Application.StartupPath + @"\acc.txt";
        bool hide = true;
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
                lines.Add(username.Text);
                lines.Add(password.Text);
                File.WriteAllLines(accPath, lines);
                resetText();
                readFile();
                MessageBox.Show("account created");
            }
        }
        public void readFile() {
            string[] lines = getFile();
            if (lines.Length > 0)
            {
                label3.Text = lines[0];
                label4.Text = lines[1];

            }
        }
        private string[] getFile()
        {
            string[] file = File.ReadAllLines(accPath);
            return file;
        }
        private void resetText()
        {
            username.Text = "Enter username";
            username.ForeColor = Color.LightGray;
            password.Text = "Enter password";
            password.PasswordChar = '\0';
            hide = true;
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
            readFile();
        }

        private void showPass(object sender, EventArgs e)
        {
            if (password.Text != "Enter password") {
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
        }
    }
}
