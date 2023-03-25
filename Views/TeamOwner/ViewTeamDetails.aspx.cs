using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.TeamOwner
{
    public partial class ViewTeamDetails : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            string teamOwnerId = "2";

            string query = "select * from Team where teamOwnerId = '{0}'";
            query = string.Format(query, teamOwnerId);

            DataTable dt = Con.getData(query);

            string teamId = dt.Rows[0]["teamId"].ToString();

            getTeamDetails(teamId);
            getTeamPlayers(teamId);
        }

        private void getTeamPlayers(string teamId)
        {
            string query = "select * from TeamPlayer where teamId = '{0}'";
            query = string.Format(query, teamId);

            tm_players_tbl.DataSource = Con.getData(query);
            tm_players_tbl.DataBind();
        }

        private void getTeamDetails(string teamId)
        {
            string query = "select * from Team where teamId = '{0}'";
            query = string.Format(query, teamId);
            DataTable dt = Con.getData(query);

            string tn = dt.Rows[0]["teamName"].ToString();
            string email = dt.Rows[0]["email"].ToString();
            string toid = dt.Rows[0]["teamOwnerId"].ToString();
            string mp = dt.Rows[0]["maxPrice"].ToString();


            tmname.Text = tn;
            tmemail.Text = email;
            tmownerid.Text = toid;
            tmmaxprice.Text = mp;
            tmid.Text = teamId;

            tmname.DataBind();
            tmemail.DataBind();
            tmownerid.DataBind();
            tmmaxprice.DataBind();
            tmid.DataBind();

        }
    }
}
