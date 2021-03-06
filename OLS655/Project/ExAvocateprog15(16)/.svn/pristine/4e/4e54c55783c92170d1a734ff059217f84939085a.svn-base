using ExAvocateprog15.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExAvocateprog15
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    ApplicantDAO applicantdao = DatabaseHelper.Login(txtUserName.Text, txtPassword.Text);
                    Applicant applicant = applicantdao.ValidateApplicant();
                    Session.Add("login", applicant); // Save login information into session
                    Response.Redirect("~/Pending_Application.aspx");
                    
                }
                catch (Exception)
                {
                    lblInvalid.Visible = true;
                }
            }
        }
    }
}