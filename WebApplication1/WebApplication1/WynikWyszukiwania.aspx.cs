using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WynikWyszukiwania : System.Web.UI.Page
    {
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\PwS.NET-AgencjaNieruchomosci-WebFormsCsharp\WebApplication1\WebApplication1\App_Data\BazaDanych.mdf;Integrated Security=True");
        SqlCommand Sq;

        String where;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                where = Convert.ToString(Session["CzescQuery"]);

                sda = new SqlDataAdapter("Select * from LISTING "+where+"", conn);
                DataTable Dtt = new DataTable();
                sda.Fill(Dtt);

                Label1.Text = "Znaleziono " + Dtt.Rows.Count + " rekory(ów).";

                GridView.DataSource = Dtt;
                GridView.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Poszukiwanie.aspx");
        }

        protected void WybranyPracownik_Click(object sender, EventArgs e)
        {
            Session["Dom"] = Convert.ToString((sender as LinkButton).CommandArgument);
            Response.Redirect("~/Dom.aspx");
        }
    }
}