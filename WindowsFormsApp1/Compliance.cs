using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Compliance
    {
        public class CRDetails
        {
            public List<CRIssueDetails> issueInfo { get; set; }

            [Display(Name = "From Date")]
            public DateTime? FromDate { get; set; }

            [Display(Name = "To Date")]
            public DateTime? ToDate { get; set; }

        }
        public class CRIssueDetails
        {
            public string CR_NO { get; set; }
            public string Solution { get; set; }
            public string ST_Feature { get; set; }
            public string ENG18_Feature { get; set; }
            public string JForms { get; set; }
            public string RequirementLink { get; set; }
            public string Requirement_ClosureDate { get; set; }
            public string DesignLink { get; set; }
            public string Designt_ClosureDate { get; set; }
            public string CodeLink { get; set; }
            public string Code_ClosureDate { get; set; }
            public string TestLink { get; set; }
            public string Test_ClosureDate { get; set; }
        }

        public class Rootobject
        {
            public string expand { get; set; }
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public Issue[] issues { get; set; }
        }

        public class Issue
        {
            public string expand { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string key { get; set; }
            public Fields fields { get; set; }
        }

        public class Fields
        {
            public string customfield_19200 { get; set; }
            public object customfield_19201 { get; set; }
            public object customfield_19202 { get; set; }
            public object customfield_19203 { get; set; }
            public string customfield_13100 { get; set; }
            public object customfield_17700 { get; set; }
            public object customfield_19208 { get; set; }
            public object customfield_19209 { get; set; }
            public string customfield_13101 { get; set; }
            public object customfield_17704 { get; set; }
            public string customfield_19204 { get; set; }
            public Resolution resolution { get; set; }
            public object customfield_17703 { get; set; }
            public string customfield_19205 { get; set; }
            public object customfield_19206 { get; set; }
            public object customfield_17701 { get; set; }
            public object customfield_19207 { get; set; }
            public object customfield_10500 { get; set; }
            public DateTime? lastViewed { get; set; }
            public Customfield_18900 customfield_18900 { get; set; }
            public object customfield_18901 { get; set; }
            public string[] labels { get; set; }
            public object aggregatetimeoriginalestimate { get; set; }
            public Issuelink[] issuelinks { get; set; }
            public Assignee assignee { get; set; }
            public object[] customfield_19300 { get; set; }
            public object[] components { get; set; }
            public object[] customfield_19301 { get; set; }
            public object[] customfield_19302 { get; set; }
            public object customfield_17003 { get; set; }
            public object customfield_17002 { get; set; }
            public object customfield_17001 { get; set; }
            public object customfield_17000 { get; set; }
            public object customfield_19303 { get; set; }
            public object customfield_17800 { get; set; }
            public string[] customfield_10600 { get; set; }
            public object customfield_18200 { get; set; }
            public Subtask[] subtasks { get; set; }
            public DateTime? customfield_14400 { get; set; }
            public Reporter reporter { get; set; }
            public object customfield_12102 { get; set; }
            public Progress progress { get; set; }
            public Votes votes { get; set; }
            public Issuetype issuetype { get; set; }
            public object customfield_19400 { get; set; }
            public object customfield_19401 { get; set; }
            public DateTime? customfield_17102 { get; set; }
            public DateTime? customfield_17101 { get; set; }
            public Project project { get; set; }
            public object customfield_11000 { get; set; }
            public object customfield_10700 { get; set; }
            public object customfield_10701 { get; set; }
            public Customfield_10703 customfield_10703 { get; set; }
            public Customfield_10704 customfield_10704 { get; set; }
            public DateTime? resolutiondate { get; set; }
            public Watches watches { get; set; }
            public object customfield_18301 { get; set; }
            public object customfield_18302 { get; set; }
            public object customfield_18303 { get; set; }
            public Customfield_16800 customfield_16800 { get; set; }
            public object customfield_14500 { get; set; }
            public Customfield_14501[] customfield_14501 { get; set; }
            public string customfield_10016 { get; set; }
            public object customfield_11900 { get; set; }
            public DateTime? updated { get; set; }
            public object customfield_19500 { get; set; }
            public object customfield_17201 { get; set; }
            public object customfield_17200 { get; set; }
            public object timeoriginalestimate { get; set; }
            public string description { get; set; }
            public string customfield_10010 { get; set; }
            public object customfield_17202 { get; set; }
            public Customfield_10011 customfield_10011 { get; set; }
            public Customfield_11100[] customfield_11100 { get; set; }
            public object customfield_13401 { get; set; }
            public Customfield_11101[] customfield_11101 { get; set; }
            public object customfield_10012 { get; set; }
            public object customfield_19501 { get; set; }
            public object customfield_13400 { get; set; }
            public object customfield_10013 { get; set; }
            public object customfield_19502 { get; set; }
            public object customfield_10014 { get; set; }
            public object customfield_19503 { get; set; }
            public object customfield_13402 { get; set; }
            public object customfield_19504 { get; set; }
            public object customfield_10005 { get; set; }
            public object customfield_10006 { get; set; }
            public object customfield_10007 { get; set; }
            public object customfield_10008 { get; set; }
            public object customfield_10009 { get; set; }
            public string summary { get; set; }
            public string customfield_18400 { get; set; }
            public string customfield_10000 { get; set; }
            public Customfield_10001 customfield_10001 { get; set; }
            public object[] customfield_14601 { get; set; }
            public object customfield_12301 { get; set; }
            public Customfield_10002 customfield_10002 { get; set; }
            public object customfield_16900 { get; set; }
            public object customfield_10003 { get; set; }
            public object customfield_10004 { get; set; }
            public object environment { get; set; }
            public object duedate { get; set; }
            public Customfield_17302[] customfield_17302 { get; set; }
            public Fixversion[] fixVersions { get; set; }
            public DateTime? customfield_11200 { get; set; }
            public object customfield_10901 { get; set; }
            public object customfield_16321 { get; set; }
            public object customfield_16200 { get; set; }
            public object customfield_16320 { get; set; }
            public object customfield_16325 { get; set; }
            public object customfield_18504 { get; set; }
            public object customfield_16324 { get; set; }
            public object customfield_16323 { get; set; }
            public float? customfield_16202 { get; set; }
            public object customfield_16322 { get; set; }
            public object customfield_16201 { get; set; }
            public Priority priority { get; set; }
            public object customfield_10100 { get; set; }
            public string customfield_14700 { get; set; }
            public object customfield_16328 { get; set; }
            public object customfield_16327 { get; set; }
            public object customfield_16326 { get; set; }
            public object customfield_14812 { get; set; }
            public string customfield_14813 { get; set; }
            public object customfield_16319 { get; set; }
            public object timeestimate { get; set; }
            public object[] versions { get; set; }
            public Status status { get; set; }
            public object customfield_16310 { get; set; }
            public string customfield_15100 { get; set; }
            public object customfield_16314 { get; set; }
            public object customfield_16312 { get; set; }
            public object customfield_16311 { get; set; }
            public object customfield_16318 { get; set; }
            public object customfield_16317 { get; set; }
            public string customfield_19700 { get; set; }
            public object customfield_16316 { get; set; }
            public object customfield_16315 { get; set; }
            public string customfield_14803 { get; set; }
            public string customfield_10205 { get; set; }
            public object customfield_16309 { get; set; }
            public string[] customfield_14801 { get; set; }
            public object customfield_16308 { get; set; }
            public string[] customfield_14802 { get; set; }
            public object customfield_10206 { get; set; }
            public Customfield_10207 customfield_10207 { get; set; }
            public int? aggregatetimeestimate { get; set; }
            public Customfield_10208 customfield_10208 { get; set; }
            public object customfield_20000 { get; set; }
            public Creator creator { get; set; }
            public string customfield_14000 { get; set; }
            public Aggregateprogress aggregateprogress { get; set; }
            public object customfield_16307 { get; set; }
            public string customfield_10200 { get; set; }
            public string[] customfield_14800 { get; set; }
            public object customfield_10202 { get; set; }
            public object customfield_14913 { get; set; }
            public object customfield_14914 { get; set; }
            public object customfield_14911 { get; set; }
            public object customfield_14912 { get; set; }
            public object customfield_14917 { get; set; }
            public object customfield_14918 { get; set; }
            public object customfield_14915 { get; set; }
            public object customfield_14916 { get; set; }
            public object[] customfield_19002 { get; set; }
            public int? timespent { get; set; }
            public object customfield_19802 { get; set; }
            public object customfield_15200 { get; set; }
            public object customfield_17500 { get; set; }
            public object customfield_19804 { get; set; }
            public object customfield_19805 { get; set; }
            public int? aggregatetimespent { get; set; }
            public object customfield_14910 { get; set; }
            public object customfield_10311 { get; set; }
            public object customfield_19800 { get; set; }
            public object customfield_14901 { get; set; }
            public object customfield_17617 { get; set; }
            public object customfield_10306 { get; set; }
            public object customfield_14907 { get; set; }
            public object customfield_10307 { get; set; }
            public object customfield_10308 { get; set; }
            public Customfield_10309 customfield_10309 { get; set; }
            public int workratio { get; set; }
            public object customfield_14908 { get; set; }
            public object customfield_14909 { get; set; }
            public object customfield_20100 { get; set; }
            public DateTime? created { get; set; }
            public object customfield_17612 { get; set; }
            public string customfield_16401 { get; set; }
            public object customfield_17616 { get; set; }
            public object customfield_17615 { get; set; }
            public object customfield_17614 { get; set; }
            public object customfield_18700 { get; set; }
            public string customfield_17613 { get; set; }
            public object customfield_17608 { get; set; }
            public Customfield_17607 customfield_17607 { get; set; }
            public object customfield_17606 { get; set; }
            public object customfield_15301 { get; set; }
            public object customfield_17601 { get; set; }
            public string customfield_19901 { get; set; }
            public object customfield_15302 { get; set; }
            public object customfield_17600 { get; set; }
            public string customfield_19902 { get; set; }
            public object customfield_15300 { get; set; }
            public object customfield_17605 { get; set; }
            public object customfield_17604 { get; set; }
            public object customfield_17603 { get; set; }
            public object customfield_17602 { get; set; }
            public string customfield_19900 { get; set; }
            public object customfield_12703 { get; set; }
            public object customfield_19211 { get; set; }
            public object customfield_19212 { get; set; }
            public object customfield_19213 { get; set; }
            public object customfield_19214 { get; set; }
            public object[] customfield_18000 { get; set; }
            public object customfield_19210 { get; set; }
            public object customfield_19215 { get; set; }
            public string customfield_19217 { get; set; }
            public object customfield_10400 { get; set; }
        }

        public class Resolution
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
        }

        public class Customfield_18900
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Assignee
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class Avatarurls
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Reporter
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls1 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class Avatarurls1
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Progress
        {
            public int progress { get; set; }
            public int total { get; set; }
            public int percent { get; set; }
        }

        public class Votes
        {
            public string self { get; set; }
            public int votes { get; set; }
            public bool hasVoted { get; set; }
        }

        public class Issuetype
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId { get; set; }
        }

        public class Project
        {
            public string self { get; set; }
            public string id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public Avatarurls2 avatarUrls { get; set; }
            public Projectcategory projectCategory { get; set; }
        }

        public class Avatarurls2
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Projectcategory
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
        }

        public class Customfield_10703
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_10704
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public bool archived { get; set; }
            public bool released { get; set; }
        }

        public class Watches
        {
            public string self { get; set; }
            public int watchCount { get; set; }
            public bool isWatching { get; set; }
        }

        public class Customfield_16800
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_10011
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_10001
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_10002
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Priority
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Status
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public Statuscategory statusCategory { get; set; }
        }

        public class Statuscategory
        {
            public string self { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class Customfield_10207
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_10208
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Creator
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string emailAddress { get; set; }
            public Avatarurls3 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class Avatarurls3
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Aggregateprogress
        {
            public int progress { get; set; }
            public int total { get; set; }
            public int percent { get; set; }
        }

        public class Customfield_10309
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_17607
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Issuelink
        {
            public string id { get; set; }
            public string self { get; set; }
            public Type type { get; set; }
            public Inwardissue inwardIssue { get; set; }
        }

        public class Type
        {
            public string id { get; set; }
            public string name { get; set; }
            public string inward { get; set; }
            public string outward { get; set; }
            public string self { get; set; }
        }

        public class Inwardissue
        {
            public string id { get; set; }
            public string key { get; set; }
            public string self { get; set; }
            public Fields1 fields { get; set; }
        }

        public class Fields1
        {
            public string summary { get; set; }
            public Status1 status { get; set; }
            public Priority1 priority { get; set; }
            public Issuetype1 issuetype { get; set; }
        }

        public class Status1
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public Statuscategory1 statusCategory { get; set; }
        }

        public class Statuscategory1
        {
            public string self { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class Priority1
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Issuetype1
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId { get; set; }
        }

        public class Subtask
        {
            public string id { get; set; }
            public string key { get; set; }
            public string self { get; set; }
            public Fields2 fields { get; set; }
        }

        public class Fields2
        {
            public string summary { get; set; }
            public Status2 status { get; set; }
            public Priority2 priority { get; set; }
            public Issuetype2 issuetype { get; set; }
        }

        public class Status2
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public Statuscategory2 statusCategory { get; set; }
        }

        public class Statuscategory2
        {
            public string self { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class Priority2
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Issuetype2
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId { get; set; }
        }

        public class Customfield_14501
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_11100
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_11101
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Customfield_17302
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class Fixversion
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public bool archived { get; set; }
            public bool released { get; set; }
            public string releaseDate { get; set; }
        }

        /*-----------------------------* JForms *-------------------*/
        public class Rootobject1
        {
            public Object1 _object { get; set; }
        }

        public class Object1
        {
            public string url { get; set; }
            public string title { get; set; }
            public string summary { get; set; }
        }

        /*--------------------------------------------------------------*/
        //public class Rootobject2
        //{
        //    public Reviews reviews { get; set; }
        //}

        //public class Reviews
        //{
        //    public Reviewdata[] reviewData { get; set; }
        //}

        //public class Reviewdata
        //{
        //    public string allowReviewersToJoin { get; set; }
        //    public Author author { get; set; }
        //    public DateTime closeDate { get; set; }
        //    public DateTime createDate { get; set; }
        //    public string description { get; set; }
        //    public DateTime dueDate { get; set; }
        //    public string jiraIssueKey { get; set; }
        //    public object linkedIssues { get; set; }
        //    public string metricsVersion { get; set; }
        //    public Moderator moderator { get; set; }
        //    public string name { get; set; }
        //    public Permaid permaId { get; set; }
        //    public string permaIdHistory { get; set; }
        //    public string projectKey { get; set; }
        //    public string state { get; set; }
        //    public string type { get; set; }
        //    public Parentreview parentReview { get; set; }
        //}

        //public class Author
        //{
        //    public string avatarUrl { get; set; }
        //    public string displayName { get; set; }
        //    public string userName { get; set; }
        //}

        //public class Moderator
        //{
        //    public string avatarUrl { get; set; }
        //    public string displayName { get; set; }
        //    public string userName { get; set; }
        //}

        //public class Permaid
        //{
        //    public string id { get; set; }
        //}

        //public class Parentreview
        //{
        //    public string id { get; set; }
        //}
    }
}
