using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Views.Player
{
    public partial class ViewTrophies : System.Web.UI.Page
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
    }
}