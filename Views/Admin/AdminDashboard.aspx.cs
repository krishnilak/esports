using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Admin
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_tropies(object sender, EventArgs e)
        {
            Response.Redirect("ManageTrophies.aspx");
        }

        protected void btn_teams(object sender, EventArgs e)
        {
            Response.Redirect("ManageTeams.aspx");
        }

        protected void btn_reports(object sender, EventArgs e)
        {
            Response.Redirect("GenerateReports.aspx");
        }

        protected void btn_players(object sender, EventArgs e)
        {
            Response.Redirect("ManagePlayes.aspx");
        }
    }
}