using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static WindowsFormsApp1.Compliance;

namespace WindowsFormsApp1
{
    public class CRIssues
    {
        private string user;
        private string password;
        public Rootobject Rootobjectdetails = null;
        public static List<CRIssueDetails> listIssues = null;
        public CRIssueDetails Crsobj = null;
        public CRDetails Crs = null;

        public void GetCRIssueList(string usr, string pwd)
        {
            user = usr;
            password = pwd;
            string url = "https://jira2.cerner.com/rest/api/2/search?jql=project = GLB AND issuetype = Defect AND resolution = Done AND assignee is not EMPTY AND resolved >= 2020-01-11 AND resolved <= 2020-02-20  &maxResults=1000";
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + password;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            Rootobjectdetails = JsonConvert.DeserializeObject<Rootobject>(content);
            listIssues = new List<CRIssueDetails>();
            for (int i = 0; i < Rootobjectdetails.issues.Length; i++)
            {
                Dictionary<string, string> Reviews = new Dictionary<string, string>();
                Crsobj = new CRIssueDetails();
                Crsobj.CR_NO = Rootobjectdetails.issues[i].fields.customfield_17613.ToString();
                Crsobj.Solution = Rootobjectdetails.issues[i].fields.project.name.ToString();
                Crsobj.ST_Feature = GetFeatureOf(Crsobj.CR_NO, "SOLUTION_TEST");
                Crsobj.ENG18_Feature = GetFeatureOf(Crsobj.CR_NO, "2018.01_SVC_ENG");
                Crsobj.JForms = GetJFormOf(Crsobj.CR_NO);
                GetReviewsOf(Crsobj.CR_NO, ref Reviews);
                if(Reviews.ContainsKey("RR_ID"))
                {
                    Crsobj.RequirementLink = Reviews["RR_ID"] == null ? "NA" : Reviews["RR_ID"];
                }
                if(Reviews.ContainsKey("DR_ID"))
                {
                    Crsobj.DesignLink = Reviews["DR_ID"] == null ? "NA" : Reviews["DR_ID"];
                }     
                if(Reviews.ContainsKey("CR_ID"))
                {
                    Crsobj.CodeLink = Reviews["CR_ID"];
                }
                if (Reviews.ContainsKey("TR_ID"))
                {
                    Crsobj.TestLink = Reviews["TR_ID"];
                }
                if (Reviews.ContainsKey("RR_CD"))
                {
                    Crsobj.Requirement_ClosureDate = Reviews["RR_CD"] == null ? "NA" : Reviews["RR_CD"];
                }
                if (Reviews.ContainsKey("DR_CD"))
                {
                    Crsobj.Designt_ClosureDate = Reviews["DR_CD"] == null ? "NA" : Reviews["DR_CD"];
                }
                if (Reviews.ContainsKey("CR_CD"))
                {
                    Crsobj.Code_ClosureDate = Reviews["CR_CD"];
                }
                if(Reviews.ContainsKey("TR_CD"))
                {
                    Crsobj.Test_ClosureDate = Reviews["TR_CD"];
                }
                listIssues.Add(Crsobj);
            }
            Crs = new CRDetails();
            Crs.issueInfo = listIssues;
            CRListDisplay Crdisplay = new CRListDisplay();
            Crdisplay.BindCRDetails(listIssues);
            Crdisplay.Show();
        }

        public string GetFeatureOf(string CR_No, string pipeline)
        {
            string features_nums = "";
            string url = "https://api.milltools.cerner.net/pipelines/" + pipeline + "/features?solutionChange=" + CR_No;
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + password;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            string toBeSearched = "\"features\":";
            string codestring = content.Substring(content.IndexOf(toBeSearched) + toBeSearched.Length);
            codestring = codestring.Remove(codestring.Length - 3);
            JArray array = JArray.Parse(codestring);

            foreach (JObject obj in array.Children<JObject>())
            {
                foreach (JProperty singleProp in obj.Properties())
                {
                    if (singleProp.Name == "id")
                    {
                        if (features_nums != "")
                        {
                            features_nums = features_nums + ",";
                        }
                        features_nums = features_nums + singleProp.Value.ToString();
                    }
                }
            }
            return features_nums;
        }

        public string GetJFormOf(string CR_No)
        {
            string JForm = "";
            Object1 Rootobjectdetails1 = null;
            string url = "https://jira2.cerner.com/rest/api/2/issue/" + CR_No + "/remotelink";
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + password;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();

            JArray array = JArray.Parse(content);

            foreach (JObject obj in array.Children<JObject>())
            {
                foreach (JProperty singleProp in obj.Properties())
                {
                    if (singleProp.Name == "object")
                    {
                        Rootobjectdetails1 = JsonConvert.DeserializeObject<Object1>(singleProp.Value.ToString());

                        if (Rootobjectdetails1.title.StartsWith("JFORMS"))
                        {
                            //JForm.Add(Rootobjectdetails1.title, Rootobjectdetails1.url);
                            JForm = Rootobjectdetails1.title;
                        }
                    }
                }
            }
            return JForm;
        }

        public void GetReviewsOf(string CR_No, ref Dictionary<string, string> Reviews)
        {
            string url = "https://crucibleblr1.cerner.com/rest-service/search-v1/reviewsForIssue?jiraKey=" + CR_No;
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + password;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            foreach (XmlNode node in doc)
            {
                if (node.NodeType == XmlNodeType.XmlDeclaration)
                {
                    doc.RemoveChild(node);
                }
            }
            string json = JsonConvert.SerializeXmlNode(doc);


            string toBeSearched = "\"reviewData\":";
            string codestring = json.Substring(json.IndexOf(toBeSearched) + toBeSearched.Length);
            codestring = codestring.Remove(codestring.Length - 2);
            JArray array = JArray.Parse(codestring);


            foreach (JObject obj in array.Children<JObject>())
            {
                string date = "";
                string id = "";
                string Reviewname = "";
                foreach (JProperty singleProp in obj.Properties())
                {
                    if (singleProp.Name == "name")
                    {
                        Reviewname = singleProp.Value.ToString();
                    }
                    if (singleProp.Name == "permaIdHistory")
                    {
                        id = singleProp.Value.ToString();
                    }
                    if (singleProp.Name == "closeDate")
                    {
                        var s = singleProp.Value.ToString();
                        var firstSpaceIndex = s.IndexOf(" ");
                        date = s.Substring(0, firstSpaceIndex);
                    }
                }
                if (Reviewname.IndexOf("Design", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Reviews.Add("DR_CD", date);
                    Reviews.Add("DR_ID", id);
                }
                if (Reviewname.IndexOf("Code", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Reviews.Add("CR_CD", date);
                    Reviews.Add("CR_ID", id);
                }
                if (Reviewname.IndexOf("Requirement", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Reviews.Add("RR_CD", date);
                    Reviews.Add("RR_ID", id);
                }
                if (Reviewname.IndexOf("Test case", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Reviews.Add("TR_CD", date);
                    Reviews.Add("TR_ID", id);
                }
            }
        }
    }
}
