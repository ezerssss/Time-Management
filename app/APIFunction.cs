using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace app
{
    public partial class APIFunction : UserControl
    {
        public APIFunction()
        {
            InitializeComponent();
        }

        string accPath = Application.StartupPath + @"\acc.txt";
        string path = Application.StartupPath + @"\file.txt";
        string[] splitter = { "|#$#|" };
        bool done = false;

        private async void APIFunction_LoadAsync(object sender, EventArgs e)
        {
            this.BringToFront();
            string[] accDetails = File.ReadAllLines(accPath);
            if (accDetails.Length < 3)
            {
                MessageBox.Show("No Account Stored", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.WriteAllText(accPath, String.Empty);
                using (StreamWriter writer = new StreamWriter(accPath))
                {
                    writer.WriteLine("false");
                }
                Calendar_View cv = new Calendar_View();
                cv.Dock = DockStyle.Fill;
                Form1.Instance.screenContainer.Controls.Clear();
                Form1.Instance.screenContainer.Controls.Add(cv);
                return;
            }
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
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/login/token.php?service=moodle_mobile_app"))
                {
                    //gets token
                    request.Content = new StringContent("username=" + accDetails[1] + "&password=" + accDetails[2]);//"username="+ uname.Text + "&password=" + password.Text rlopos Godofmischief.loki#117
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
                        MessageBox.Show("Invalid Login!");
                        return;
                    }
                }
                if (wsToken != "")
                {
                    //gets userId
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://khub.cvisc.pshs.edu.ph/webservice/rest/server.php?moodlewsrestformat=json"))
                    {
                        request.Content = new StringContent("wstoken=" + wsToken + "&wsfunction=core_webservice_get_site_info");
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                        var response = await client.SendAsync(request);
                        string responseContent = await response.Content.ReadAsStringAsync();
                        userID id = JsonConvert.DeserializeObject<userID>(responseContent);
                        userId = id.userId;
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
                                            list.Add(a.fullname + "|#$#|" + b.name + "|#$#|" + date + pmorAM);
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
                                        list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM);
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
                                        list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM);
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
                                    list.Add(courseNameIds[a.course] + "|#$#|" + a.name + "|#$#|" + date + pmorAM);
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
                    Form1 f1 = new Form1();
                    f1.sortList();
                    done = true;               
                    Calendar_View cv = new Calendar_View();
                    cv.Dock = DockStyle.Fill;
                    Form1.Instance.screenContainer.Controls.Clear();
                    Form1.Instance.screenContainer.Controls.Add(cv);
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
    }
}
