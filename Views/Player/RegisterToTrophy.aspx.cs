using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Player
{
    public partial class RegisterToTrophy : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            getAllTrophies();

        }

        private void getAllTrophies()
        {
            string query = "select * from Trophy";
            trophy_tbl.DataSource = Con.getData(query);
            trophy_tbl.DataBind();
        }

   

        protected void registerTrophy(object sender, EventArgs e)
        {
            string trophyid = trid.Text;
            string playerid = "2"; //hardcoded value for now
            string tid = teamid.Text;

            string query = "insert into TeamPlayer (teamId, playerId) values('{0}', '{1}')";
            query = string.Format(query, tid, playerid);
            Con.setData(query);

            string query1 = "insert into TrophyTeam (teamId, trophyId) values('{0}', '{1}')";
            query = string.Format(query1, tid, trophyid);
            Con.setData(query);
        }
    }
}