using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Compliance;

namespace WindowsFormsApp1
{
    public partial class CRListDisplay : Form
    {
        public CRListDisplay()
        {
            InitializeComponent();
        }

        public void BindCRDetails(List<CRIssueDetails> listIssues)
        {
            DataTable dt = new DataTable();
           // dt.Columns.Add("NO", typeof(string));
            dt.Columns.Add("CR_NO", typeof(string));
            dt.Columns.Add("Solution", typeof(string));
            // dt.Columns.Add("CHIA_NO", typeof(string));
            dt.Columns.Add("ST_Feature", typeof(string));
            dt.Columns.Add("ENG18_Feature", typeof(string));
            dt.Columns.Add("JForms", typeof(string));
            dt.Columns.Add("RequirementLink", typeof(string));
            dt.Columns.Add("Requirement_ClosureDate", typeof(string));
            dt.Columns.Add("DesignLink", typeof(string));
            dt.Columns.Add("Designt_ClosureDate", typeof(string));
            dt.Columns.Add("CodeLink", typeof(string));
            dt.Columns.Add("Code_ClosureDate", typeof(string));
            dt.Columns.Add("TestCaseLink", typeof(string));
            dt.Columns.Add("TestCase_ClosureDate", typeof(string));

            //int slno = 0;
            foreach (CRIssueDetails issue in listIssues)
            {
                //slno++;
                DataRow dr = dt.NewRow();
                //dr["NO"] = slno;
                dr["CR_NO"] = issue.CR_NO;
                dr["Solution"] = issue.Solution;
                dr["ST_Feature"] = issue.ST_Feature;
                dr["ENG18_Feature"] = issue.ENG18_Feature;
                dr["JForms"] = issue.JForms;
                dr["RequirementLink"] = issue.RequirementLink;
                dr["Requirement_ClosureDate"] = issue.Requirement_ClosureDate;
                dr["DesignLink"] = issue.DesignLink;
                dr["Designt_ClosureDate"] = issue.Designt_ClosureDate;
                dr["CodeLink"] = issue.CodeLink;
                dr["Code_ClosureDate"] = issue.Code_ClosureDate;
                dr["TestCaseLink"] = issue.TestLink;
                dr["TestCase_ClosureDate"] = issue.Test_ClosureDate;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
