using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Admin
{
    public partial class ManageTrophies : System.Web.UI.Page
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

        private void getTrophyDetails(string trophyId)
        {
            string query = "select * from Trophy where trophyId = '{0}'";
            query = string.Format(query, trophyId);
            DataTable dt = Con.getData(query);

            string trn = dt.Rows[0]["trophyName"].ToString();
            string trevenue = dt.Rows[0]["venue"].ToString();
            string tno = dt.Rows[0]["noOfTeams"].ToString();
            string td = dt.Rows[0]["trophyDate"].ToString();

            trname.Text = trn;
            trvenue.Text = trevenue;
            trno.Text = tno;
            trdate.Text = td;
            trid.Text = trophyId;

            trname.DataBind();
            trvenue.DataBind();
            trno.DataBind();
            trdate.DataBind();
            trid.DataBind();

        }

        protected void addTrophyClick(object sender, EventArgs e)
        {

            string name = trname.Text;
            string venue = trvenue.Text;
            string noofteams = trno.Text;
            string date = trdate.Text;
            string id = trid.Text;

            string query = "insert into Trophy (trophyId, trophyName, venue, noOfTeams, trophyDate) values('{0}', '{1}', '{2}', '{3}', '{4}')";
            query = string.Format(query, id, name, venue, noofteams, date);
            Con.setData(query);
            getAllTrophies();
        }

        protected void deleteTrophyClick(object sender, EventArgs e)
        {
            string id = trid.Text;
            string query = "delete from Trophy where trophyId = '{0}'";
            query = string.Format(query, id);
            Con.setData(query);
            getAllTrophies();
        }

        protected void viewTrophyDetailsClick(object sender, EventArgs e)
        {
            string t_id = trid.Text;
            getTrophyDetails(t_id);
        }

        protected void updateTrophyClick(object sender, EventArgs e)
        {
            string name = trname.Text;
            string venue = trvenue.Text;
            string noofteams = trno.Text;
            string date = trdate.Text;
            string id = trid.Text;

            string query = "update Trophy set trophyName = '{0}', venue = '{1}', noOfTeams='{2}',  trophyDate = '{3}' where trophyId = '{4}'";
            query = string.Format(query, name, venue, noofteams, date, id);
            Con.setData(query);
            getAllTrophies();

        }
    }
}