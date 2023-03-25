using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Player
{
    public partial class ViewTeam : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            string playerId = "2";

            string query = "select * from TeamPlayer where playerId = '{0}'";
            query = string.Format(query, playerId);

            DataTable dt = Con.getData(query);

            string teamId = dt.Rows[0]["teamId"].ToString();

            getTeamDetails(teamId);
            getTeamPlayers(teamId);
        }

        private void getTeamPlayers(string teamId)
        {
            string query = "select * from TeamPlayer where teamId = '{0}'";
            query = string.Format(query, teamId); 
            team_players_tbl.DataSource = Con.getData(query);
            team_players_tbl.DataBind();
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

            tname.Text = tn;
            temail.Text = email;
            townerid.Text = toid;
            tmaxprice.Text = mp;
            tid.Text = teamId;

            tname.DataBind();
            temail.DataBind();
            townerid.DataBind();
            tmaxprice.DataBind();
            tid.DataBind();

        }
    }
    }
