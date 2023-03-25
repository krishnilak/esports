using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Admin
{
    public partial class ManagePlayes : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            getAllPlayers();

        }

        private void getAllPlayers()
        {
            string query = "select * from Player";
            players_tbl.DataSource = Con.getData(query);
            players_tbl.DataBind();
        }

        private void getPlayerDetails(string playerId)
        {
            string query = "select * from Player where playerId = '{0}'";
            query = string.Format(query, playerId);
            DataTable dt= Con.getData(query);

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

        protected void addPlayerClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            string pn = pname.Text;
            string pmob = pmobile.Text;
            string pe = pemail.Text;
            string ps = pstatus.Text;
            string pp = pbaseprice.Text;
            string pass = "1234";

            string query = "insert into Player (playerId, playerName, mobile, email, password,  status, basePrice) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
            query = string.Format(query, p_id, pn, pmob, pe, pass, ps, pp);
            Con.setData(query);
            getAllPlayers();
        }

        protected void deletePlayerClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            string query = "delete from Player where playerId = '{0}'";
            query = string.Format(query, p_id);
            Con.setData(query);
            getAllPlayers();

        }

        protected void setBasePriceClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            string pp = pbaseprice.Text;

            string query = "update Player set basePrice='{0}' where playerId = '{1}'";
            query = string.Format(query, pp, p_id);
            Con.setData(query);
            getAllPlayers();
        }

        protected void setStatusClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            string ps = pstatus.Text;

            string query = "update Player set status='{0}' where playerId = '{1}'";
            query = string.Format(query, ps, p_id);
            Con.setData(query);
            getAllPlayers();
        }

        protected void viewPlayerDetailsClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            getPlayerDetails(p_id);
        }

        protected void updatePlayerClick(object sender, EventArgs e)
        {
            string p_id = pid.Text;
            string pn = pname.Text;
            string pmob = pmobile.Text;
            string pe = pemail.Text;
            string ps = pstatus.Text;
            string pp = pbaseprice.Text;

            string query = "update Player set playerName = '{0}', mobile = '{1}', email='{2}',  status = '{3}', basePrice = '{4}' where playerId = '{5}'";
            query = string.Format(query, pn, pmob, pe, ps, pp, p_id);
            Con.setData(query);
            getAllPlayers();


        }

    }
}