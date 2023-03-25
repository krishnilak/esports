using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Admin
{
    public partial class ManageTeams : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            getAllTeams();
        }

        private void getAllTeams()
        {
            string query = "select * from Team";
            team_tbl.DataSource = Con.getData(query);
            team_tbl.DataBind();
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

        protected void addTeamClick(object sender, EventArgs e)
        {

            string t_id = tid.Text;
            string tn = tname.Text;
            string email = temail.Text;
            string toid = townerid.Text;
            string mp = tmaxprice.Text;

            string query = "insert into Team (teamId, teamName, teamOwnerId, email, maxPrice) values('{0}', '{1}', '{2}', '{3}', '{4}')";
            query = string.Format(query, t_id, tn, toid, email, mp);
            Con.setData(query);
            getAllTeams();
        }

        protected void deleteTeamClick(object sender, EventArgs e)
        {
            string t_id = tid.Text;
            string query = "delete from Team where teamId = '{0}'";
            query = string.Format(query, t_id);
            Con.setData(query);
            getAllTeams();
        }

        protected void setMaxPriceClick(object sender, EventArgs e)
        {
            string t_id = tid.Text;
            string tp = tmaxprice.Text;

            string query = "update Team set maxPrice='{0}' where teamId = '{1}'";
            query = string.Format(query, tp, t_id);
            Con.setData(query);
            getAllTeams();
        }

        protected void viewTeamDetailsClick(object sender, EventArgs e)
        {
            string t_id = tid.Text;
            getTeamDetails(t_id);
        }

        protected void updateTeamClick(object sender, EventArgs e)
        {
            string t_id = tid.Text;
            string tn = tname.Text;
            string email = temail.Text;
            string toid = townerid.Text;
            string mp = tmaxprice.Text;

            string query = "update Team set teamName = '{0}', teamOwnerId = '{1}', email='{2}',  maxPrice = '{3}' where teamId = '{4}'";
            query = string.Format(query, tn, toid, email, mp, t_id);
            Con.setData(query);
            getAllTeams();

        }
    }
}