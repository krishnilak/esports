using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication3.Views.Admin
{
    public partial class GenerateReports : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void playerReportClick(object sender, EventArgs e)
        {
            string query = "select * from Player";
            DataTable dt = Con.getData(query);
          
            StringBuilder sb = new StringBuilder();
            sb.Append("<table><tr><th>Player ID</th><th>Player Name</th><th>Mobile</th><th>Email</th><th>Status</th><th>Base Price</th></tr>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + dt.Rows[i]["playerId"] + "</td><td>" + dt.Rows[i]["playerName"] + "</td><td>" + dt.Rows[i]["mobile"] + "</td><td>" + dt.Rows[i]["email"]+ "</td><td>" + dt.Rows[i]["status"] + "</td><td>" + dt.Rows[i]["basePrice"] + "</td>" );
                sb.Append("</tr>");
             }
             sb.Append("</table>");

             StringReader sr = new StringReader(sb.ToString());
             Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
             HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
             PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
             
             pdfDoc.Open();
             htmlparser.Parse(sr);
             pdfDoc.Close();

             Response.ContentType = "application/pdf";
             Response.AddHeader("content-disposition", "attachment;filename=PlayersReports" + ".pdf");
             Response.Cache.SetCacheability(HttpCacheability.NoCache);
             Response.Write(pdfDoc);
             Response.End();

        }

        protected void teamReportClick(object sender, EventArgs e)
        {
            string query = "select * from Team";
            DataTable dt = Con.getData(query);

            StringBuilder sb = new StringBuilder();
            sb.Append("<table><tr><th>Team ID</th><th>Team Name</th><th>Team Owner ID</th><th>Email</th><th>Max Price</th></tr>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + dt.Rows[i]["teamId"] + "</td><td>" + dt.Rows[i]["teamName"] + "</td><td>" + dt.Rows[i]["teamOwnerId"] + "</td><td>" + dt.Rows[i]["email"] + "</td><td>" + dt.Rows[i]["maxPrice"] +  "</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            StringReader sr = new StringReader(sb.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=TeamsReports" + ".pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
        }

        protected void trophyReportClick(object sender, EventArgs e)
        {
            string query = "select * from Trophy";
            DataTable dt = Con.getData(query);

            StringBuilder sb = new StringBuilder();
            sb.Append("<table><tr><th>Trophy ID</th><th>Trophy Name</th><th>Venue</th><th>No of teams</th><th>Trophy Date</th></tr>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + dt.Rows[i]["trophyId"] + "</td><td>" + dt.Rows[i]["trophyName"] + "</td><td>" + dt.Rows[i]["venue"] + "</td><td>" + dt.Rows[i]["noOfTeams"] + "</td><td>" + dt.Rows[i]["trophyDate"] + "</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            StringReader sr = new StringReader(sb.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=TrophyReports" + ".pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}