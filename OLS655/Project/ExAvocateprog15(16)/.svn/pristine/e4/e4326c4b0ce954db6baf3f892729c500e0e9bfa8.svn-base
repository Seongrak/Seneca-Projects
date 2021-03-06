// Author : Seongrak Choi (156405177)

using ExAvocateprog15.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExAvocateprog15
{
    public partial class Home : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Applicant login = (Applicant)Session["login"];
                ExAvDAO exavDAO = new ExAvDAO(login.username, login.password);

                GvEx.DataSource = exavDAO.GetAvailableExAvs();
                GvEx.Columns[0].Visible = true;
                GvEx.DataBind();
                GvEx.Columns[0].Visible = false;
                
                lbFirst.Text = login.firstname;
                lbLast.Text = login.lastname;
                lbNum.Text = Convert.ToString(exavDAO.GetNumberOfExAvApplications());
            }


        }
        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Applicant login = (Applicant)Session["login"];
            ExAvDAO exavDAO = new ExAvDAO(login.username, login.password);

            int month = Convert.ToInt32(ddlMonth.SelectedValue);
            GvEx.DataSource = exavDAO.GetAvailableExAvs();
            GvEx.Columns[0].Visible = true;
            GvEx.DataBind();
            GvEx.Columns[0].Visible = false;

        }

        protected void btn_pending_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pending_Application.aspx"); // Return to Pending page
        }

        protected void GvEx_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if("Apply" == e.CommandName)
            {
                Applicant applicant = (Applicant)Session["login"];
                ApplyDAO applyDAO = new ApplyDAO(applicant.username, applicant.password);

                int index = Convert.ToInt32(e.CommandArgument);
                int exid = Convert.ToInt32(GvEx.Rows[index].Cells[0].Text);
                int mon = Convert.ToInt32(ddlMonth.SelectedValue);

                int result = applyDAO.Apply(exid,mon);

                if(result==1)
                {
                    Response.Redirect("~/Pending_Application.aspx");
                }
                else
                    lbError.Visible = true;

            }
            }
        }
    }