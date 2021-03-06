// Author: Oluwaseun Kelani      Student No: 160584173
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using ExAvocateprog15.DAO;

namespace ExAvocateprog15
{
    public partial class Pending_Application : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Applicant login = (Applicant)Session["login"];
                ExAvDAO Applicant = new ExAvDAO(login.username, login.password);

                GrdV_App.DataSource = Applicant.GetAvailableExAvs();
                GrdV_App.Columns[0].Visible = true;
                GrdV_App.DataBind();
                GrdV_App.Columns[0].Visible = false;

                lb_Firstname.Text = login.firstname;
                lb_Lastname.Text = login.lastname;
                lb_pApp.Text = Convert.ToString(Applicant.GetNumberOfExAvApplications());


                if (Applicant.GetNumberOfExAvApplications() == 0)
                    label_Error.Visible = true;
                else
                    label_Error.Visible = false;
            }
        }






        protected void App_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ExAv_application.aspx");
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Pending_Application.aspx");
        }
        protected void GrdV_App_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Withdraw")
            {
                Applicant applicant = (Applicant)Session["login"];
                ApplicantDAO withdraw = new ApplicantDAO(applicant.username, applicant.password);

                int index = Convert.ToInt32(e.CommandArgument);
                int exid = Convert.ToInt32(GrdV_App.Rows[index].Cells[0].Text);


                 withdraw.WithdrawApplication(exid);

            }
        }

        protected void GrdV_App_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
