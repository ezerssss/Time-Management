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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace app
{
    public partial class login : UserControl
    {
        string accPath = Application.StartupPath + @"\acc.txt";
        string path = Application.StartupPath + @"\file.txt";
        string[] splitter = { "|#$#|" };
        bool hide = true;
        bool userRemove = true;
        bool passRemove = true;
        int num = 0;
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

        private async void login_button_ClickAsync(object sender, EventArgs e)
        {          
            if (username.Text == "" || password.Text == "" || username.Text == "Enter username" || password.Text == "Enter password") {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckForInternetConnection())
                MessageBox.Show("No Internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                File.WriteAllText(accPath, String.Empty);
                File.WriteAllText(path, String.Empty);
                List<string> lines = new List<string>();
                string wsToken = "", userId = "";
                IDictionary<int, string> courseNameIds = new Dictionary<int, string>();
                List<string> courseIds = new List<string>();
                List<int> assCmids = new List<int>();
                List<int> forumCmids = new List<int>();
                List<int> quizCmids = new List<int>();
                List<string> list = new List<string>();
                string[] elements;
                List<string> sortedList = new List<string>();
                List<string> openList = new List<string>();
                String fullName;
                using (var client = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/login/token.php?service=moodle_mobile_app"))
                    {
                        //gets token
                        request.Content = new StringContent("username=" + username.Text + "&password=" + password.Text);//"username="+ uname.Text + "&password=" + password.Text rlopos Godofmischief.loki#117
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                        var response = await client.SendAsync(request);
                        string responseContent = await response.Content.ReadAsStringAsync();
                        if (!responseContent.Contains("Invalid login"))
                        {
                            getToken tokens = JsonConvert.DeserializeObject<getToken>(responseContent);
                            wsToken = tokens.token;
                        }
                        else
                        {
                            using (StreamWriter writer = new StreamWriter(accPath))
                            {
                                writer.WriteLine("false");
                            }
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resetText();
                            return;
                        }
                    }
                    if (wsToken != "")
                    {
                        EarlyBird.Globals.closeButtonDisable = true;
                        loggingIn.Visible = true;
                        loginBar.Visible = true;
                        //gets userId
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                        {
                            request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=core_webservice_get_site_info");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                            var response = await client.SendAsync(request);
                            string responseContent = await response.Content.ReadAsStringAsync();
                            userID id = JsonConvert.DeserializeObject<userID>(responseContent);
                            userId = id.userId;
                            fullName = id.fullname;
                            loginBar.Value += 4;
                        }
                        printProgress.Text = "User ID Successfully Stored";

                        //gets coursesOfUser
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                        {
                            request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=core_enrol_get_users_courses" + "&userid=" + userId);
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                            var response = await client.SendAsync(request);
                            string responseContent = await response.Content.ReadAsStringAsync();
                            List<courseIDs> cId = JsonConvert.DeserializeObject<List<courseIDs>>(responseContent);
                            foreach (var id in cId)
                            {
                                courseIds.Add(id.id.ToString() + "|#$#|" + id.displayName);
                                courseNameIds.Add(id.id, id.displayName);
                                if (loginBar.Value != 15)
                                    loginBar.Value += 1;
                                printProgress.Text = "Storing Courses: " + id.displayName;
                            }
                        }
                        if (loginBar.Value != 15)
                            loginBar.Value = 15;
                        printProgress.Text = "Course IDS Successfully Stored";

                        //gets Activites of each Course 
                        foreach (var id in courseIds)
                        {
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                            {
                                request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=core_completion_get_activities_completion_status" + "&courseid=" + id.Split(splitter, StringSplitOptions.None)[0] + "&userid=" + userId);
                                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                                var response = await client.SendAsync(request);
                                string responseContent = await response.Content.ReadAsStringAsync();
                                actIDsBig cmIDs = JsonConvert.DeserializeObject<actIDsBig>(responseContent);
                                foreach (var cmid in cmIDs.statuses)
                                {
                                    if (cmid.state == 0)
                                    {
                                        if (cmid.modname == "assign")
                                            assCmids.Add(cmid.CMID);
                                        else if (cmid.modname == "forum")
                                            forumCmids.Add(cmid.CMID);
                                        else if (cmid.modname == "quiz")
                                            quizCmids.Add(cmid.CMID);
                                        if (loginBar.Value != 40)
                                            loginBar.Value += 1;
                                        printProgress.Text = "Storing Tasks: " + cmid.CMID;
                                    }
                                }
                            }
                        }
                        if (loginBar.Value != 40)
                            loginBar.Value = 40;
                        printProgress.Text = "Task IDs Successfully Stored";

                        //gets DueDate and Name of Assignments

                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                        {
                            request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=mod_assign_get_assignments");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                            var response = await client.SendAsync(request);
                            string responseContent = await response.Content.ReadAsStringAsync();
                            dueDateBig dueDates = JsonConvert.DeserializeObject<dueDateBig>(responseContent);
                            int cmidDueDateConfirmed = 0;
                            while (cmidDueDateConfirmed < assCmids.Count)
                            {
                                foreach (var a in dueDates.courses)
                                {
                                    if (cmidDueDateConfirmed == assCmids.Count)
                                        break;
                                    if (a.assignments.Count != 0)
                                    {
                                        foreach (var b in a.assignments)
                                        {
                                            if (cmidDueDateConfirmed == assCmids.Count)
                                                break;
                                            if (b.cmid == assCmids[cmidDueDateConfirmed])
                                            {
                                                cmidDueDateConfirmed++;
                                                string pmorAM = UnixTimeStampToDateTime(b.duedate).ToString("tt").ToUpper();
                                                string date = UnixTimeStampToDateTime(b.duedate).ToString("ddd, d MMMM yyyy|#$#|hh:mm");
                                                if (date == "Thu, 1 January 1970|#$#|08:00")
                                                {
                                                    date = "---|#$#|---";
                                                    pmorAM = "";
                                                }                                                      
                                                list.Add(a.fullname + "|#$#|" + b.name + "|#$#|" + date + pmorAM );
                                                if (loginBar.Value != 60)
                                                    loginBar.Value += 1;
                                                printProgress.Text = "Storing Assignments: " + b.name;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (loginBar.Value != 60)
                            loginBar.Value = 60;
                        printProgress.Text = "Assignment IDs Successfully Stored";

                        //gets Name of forum
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                        {
                            request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=mod_forum_get_forums_by_courses");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                            var response = await client.SendAsync(request);
                            string responseContent = await response.Content.ReadAsStringAsync();
                            List<forumName> forums = JsonConvert.DeserializeObject<List<forumName>>(responseContent);
                            int forumCmidsCount = 0;
                            while (forumCmidsCount < forumCmids.Count)
                            {
                                foreach (var a in forums)
                                {
                                    if (forumCmidsCount == forumCmids.Count)
                                        break;
                                    if (a.cmid == forumCmids[forumCmidsCount])
                                    {
                                        forumCmidsCount++;
                                        if (a.duedate != 0)
                                        {
                                            string pmorAM = UnixTimeStampToDateTime(a.duedate).ToString("tt").ToUpper();
                                            string date = UnixTimeStampToDateTime(a.duedate).ToString("ddd, d MMMM yyyy|#$#|hh:mm");
                                            if (date == "Thu, 1 January 1970|#$#|08:00")
                                            {
                                                date = "---|#$#|---";
                                                pmorAM = "";
                                            }
                                            list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM );
                                            if (loginBar.Value != 80)
                                                loginBar.Value += 1;
                                            printProgress.Text = "Storing Forums: " + a.name;
                                        }
                                        else
                                        {
                                            string pmorAM = UnixTimeStampToDateTime(a.cutoffdate).ToString("tt").ToUpper();
                                            string date = UnixTimeStampToDateTime(a.cutoffdate).ToString("ddd, d MMMM yyyy|#$#|hh:mm");
                                            if (date == "Thu, 1 January 1970|#$#|08:00")
                                            {
                                                date = "---|#$#|---";
                                                pmorAM = "";
                                            }
                                            list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM );
                                            if (loginBar.Value != 80)
                                                loginBar.Value += 1;
                                            printProgress.Text = "Storing Forums: " + a.name;
                                        }
                                    }
                                }
                            }
                        }
                        if (loginBar.Value != 80)
                            loginBar.Value = 80;
                        printProgress.Text = "Forum IDs Successfully Stored";

                        //gets Quizzes by course
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                        {
                            request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=mod_quiz_get_quizzes_by_courses");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                            var response = await client.SendAsync(request);
                            string responseContent = await response.Content.ReadAsStringAsync();
                            quizzesBig quiz = JsonConvert.DeserializeObject<quizzesBig>(responseContent);
                            int quizidsCount = 0;
                            while (quizidsCount < quizCmids.Count)
                            {
                                foreach (var a in quiz.quizzes)
                                {
                                    if (quizidsCount == quizCmids.Count)
                                        break;
                                    if (a.coursemodule == quizCmids[quizidsCount])
                                    {
                                        quizidsCount++;
                                        string pmorAM = UnixTimeStampToDateTime(a.timeclose).ToString("tt").ToUpper();
                                        string date = UnixTimeStampToDateTime(a.timeclose).ToString("ddd, d MMMM yyyy|#$#|hh:mm");
                                        if (date == "Thu, 1 January 1970|#$#|08:00")
                                        {
                                            date = "---|#$#|---";
                                            pmorAM = "";
                                        }
                                        list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM );
                                        if (loginBar.Value != 99)
                                            loginBar.Value += 1;
                                        printProgress.Text = "Storing Quizzes: " + a.name;
                                    }
                                }
                            }
                        }
                        if (loginBar.Value != 100)
                            loginBar.Value = 100;
                        printProgress.Text = "Assignment IDs Successfully Stored";

                        lines.Add("true");
                        lines.Add(username.Text);
                        lines.Add(password.Text);
                        lines.Add(fullName);
                        using (StreamWriter sw = new StreamWriter(accPath))
                        {
                            foreach (var line in lines)
                                sw.WriteLine(line);
                        }
                        string[] x = { "|#$#|" };
                        while (list.Count > 0)
                        {
                            string[] earliest = list.First().Split(x, StringSplitOptions.None);
                            DateTime earliestDate = new DateTime();
                            foreach (var line in list)
                            {

                                elements = line.Split(x, StringSplitOptions.None);
                                string date = elements[2] + " " + elements[3];
                                if ((earliest[2] + " " + earliest[3]) != "--- ---")
                                {
                                    earliestDate = Convert.ToDateTime(earliest[2] + " " + earliest[3]);
                                }
                                if (date != "--- ---")
                                {
                                    int compare = DateTime.Compare(Convert.ToDateTime(Convert.ToDateTime(date).ToString("s")), Convert.ToDateTime(earliestDate.ToString("s")));
                                    if (compare < 0)
                                    {
                                        earliest = elements;
                                    }
                                }
                            }
                            string remove = earliest[0] + x[0] + earliest[1] + x[0] + earliest[2] + x[0] + earliest[3];
                            list.Remove(remove);
                            remove += "|#$#|false";
                            if ((earliest[2] + " " + earliest[3]) != "--- ---")
                                sortedList.Add(remove);
                            else
                                openList.Add(remove);

                        }
                        foreach (var ls in openList)
                            sortedList.Add(ls);

                        File.WriteAllText(path, String.Empty);
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            foreach (var line in sortedList)
                            {
                                sw.WriteLine(line);
                            }
                        }
                        EarlyBird.Globals.closeButtonDisable = false;
                        EarlyBird f1 = new EarlyBird();
                        f1.sortList();
                        resetText();
                        afterLogin();
                    }
                }
            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public class getToken
        {
            public string token { get; set; }
            public string privateToke { get; set; }
        }

        public class userID
        {
            public string userId { get; set; }
            public string fullname { get; set; }
        }

        public class courseIDs
        {
            public int id { get; set; }
            public string displayName { get; set; }
        }

        public class actIDsBig
        {
            public IList<actIDs> statuses { get; set; }
        }

        public class actIDs
        {
            public int CMID { get; set; }
            public int state { get; set; }
            public string modname { get; set; }
        }

        public class assTitlesBig
        {
            public assTitles cm { get; set; }
        }

        public class assTitles
        {
            public string name { get; set; }
            public int course { get; set; }
            public int id { get; set; }
        }

        public class dueDateBig
        {
            public IList<Cours> courses { get; set; }
        }

        public class Cours
        {
            public int id { get; set; }
            public string fullname { get; set; }
            public IList<dueDate> assignments { get; set; }
        }

        public class dueDate
        {
            public int cmid { get; set; }
            public string name { get; set; }
            public int duedate { get; set; }
        }

        public class forumName
        {
            public string name { get; set; }
            public int course { get; set; }
            public int cmid { get; set; }
            public int duedate { get; set; }
            public int cutoffdate { get; set; }
        }

        public class quizzesBig
        {
            public IList<quizzes> quizzes { get; set; }
        }

        public class quizzes
        {
            public int course { get; set; }
            public int coursemodule { get; set; }
            public string name { get; set; }
            public int timeclose { get; set; }
        }

        private void resetText()
        {
            username.Text = "Enter username";
            username.ForeColor = Color.LightGray;
            password.Text = "Enter password";
            
            hide = true;
            password.ForeColor = Color.LightGray;
            username.Enabled = false;
            username.Enabled = true;
            password.Enabled = false;
            password.Enabled = true;
        }

        private void login_Load(object sender, EventArgs e)
        {

            password.PasswordChar = '\0';
            EarlyBird.Globals.closeButtonDisable = false;
            if (!File.Exists(accPath))
            {
                using (StreamWriter writer = new StreamWriter(accPath))
                {
                    writer.WriteLine("false");
                }
                Application.Restart();
            }
            using (StreamReader sr = new StreamReader(accPath))
            {
                if (sr.ReadLine() == "true")
                {
                    logOutUser lO = new logOutUser();
                    while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                    GC.Collect();
                    EarlyBird.Instance.screenContainer.Controls.Add(lO);
                }
            }   
            resetText();
        }

        private void showPass(object sender, EventArgs e)
        {
            if (passRemove) {
                password.PasswordChar = '\0';
                hide = true;
            }
            else if (hide)
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
            if (EarlyBird.Instance.screenContainer.Controls.ContainsKey("login"))
            {
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                while (EarlyBird.Instance.screenContainer.Controls.Count > 0) EarlyBird.Instance.screenContainer.Controls[0].Dispose();
                GC.Collect();
                EarlyBird.Instance.screenContainer.Controls.Add(cv);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            afterLogin();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login_button_ClickAsync(sender, e);
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_ClickAsync(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_ClickAsync(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Enter username";
                username.ForeColor = Color.LightGray;
                userRemove = true;
            }
            if (passRemove)
                password.Text = "";
            if (num  < 1) {
                password.PasswordChar = '*';
                num++;
            }
            passRemove = false;
            password.ForeColor = Color.Black;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Enter password";
                password.ForeColor = Color.LightGray;
                passRemove = true;
            }           
            if (userRemove)
                username.Text = "";
            userRemove = false;
            username.ForeColor = Color.Black;
        }

        private void login_button_Enter(object sender, EventArgs e)
        {
            if (username.Text == "") {
                username.Text = "Enter username";
                userRemove = true;
            }
            if (userRemove)
                username.ForeColor = Color.LightGray;
            if (password.Text == "") {
                password.Text = "Enter password";
                passRemove = true;
            }
            if (passRemove)
                password.ForeColor = Color.LightGray;
               
        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Enter username";
                userRemove = true;
            }
            if (userRemove)
                username.ForeColor = Color.LightGray;
            if (password.Text == "")
            {
                password.Text = "Enter password";
                passRemove = true;
            }
            if (passRemove)
                password.ForeColor = Color.LightGray;
        }
    }
}
