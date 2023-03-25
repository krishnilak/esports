using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Player
{
    public partial class ViewAllPlayers : System.Web.UI.Page
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
    } 
        
    

}