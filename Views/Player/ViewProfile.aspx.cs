using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Player
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            string playerId = "2";
            getPlayerDetails(playerId);
        }


        private void getPlayerDetails(string playerId)
        {
            string query = "select * from Player where playerId = '{0}'";
            query = string.Format(query, playerId);
            DataTable dt = Con.getData(query);

            string pn = dt.Rows[0]["playerName"].ToString();
            string mobile = dt.Rows[0]["mobile"].ToString();
            string email = dt.Rows[0]["email"].ToString();
            string status = dt.Rows[0]["status"].ToString();
            string bp = dt.Rows[0]["basePrice"].ToString();

            pname.Text = pn;
            pmobile.Text = mobile;
            pemail.Text = email;
            pstatus.Text = status;
            pbaseprice.Text = bp;
            pid.Text = playerId;

            pname.DataBind();
            pmobile.DataBind();
            pemail.DataBind();
            pstatus.DataBind();
            pbaseprice.DataBind();
            pid.DataBind();

        }
    }
}