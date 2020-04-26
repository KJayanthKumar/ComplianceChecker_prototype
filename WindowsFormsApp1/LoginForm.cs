using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var directoryEntry = new DirectoryEntry("LDAP://corpdcberl01.northamerica.cerner.net");
            directoryEntry.Username = UsernameTB.Text;
            directoryEntry.Password = passwordTB.Text;
            var directorySearcher = new DirectorySearcher(directoryEntry);
            SearchResult result = directorySearcher.FindOne();
            CRIssues cr = new CRIssues();
            cr.GetCRIssueList(UsernameTB.Text, passwordTB.Text);
        }
    }
}
