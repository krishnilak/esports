using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string uname = Request.Form["UserName"];
            string pass = Request.Form["Password"];
            if(uname =="admin" && pass == "admin")
            {
                Response.Redirect("Admin/AdminDashboard.aspx");
            } else if (uname == "to" && pass == "to")
            {
                Response.Redirect("TeamOwner/TeamOwnerDashboard.aspx");
            } else if (uname == "p" && pass == "p")
            {
                Response.Redirect("Player/PlayerDashboard.aspx");
            } else
            {
                Response.Redirect("LoginError.aspx");
            }

        }
    }
}