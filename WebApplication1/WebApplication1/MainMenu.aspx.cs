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
    public partial class MainMenu : System.Web.UI.Page
    {
        
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=|DataDirectory|\BazaDanych.mdf;Integrated Security=True");
        SqlCommand Sq;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                divThankYou.Visible = false;
                divFailAut1.Visible = false;
            }

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void LinkButtonMMdoPrzeszukiwania_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Poszukiwanie.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select count(*) from LISTING where HLCN='" + TextBox1.Text + "'", conn);
            DataTable dtt = new DataTable();
            sda.Fill(dtt);

            if (dtt.Rows[0][0].ToString() == "1")
            {
                sda = new SqlDataAdapter("select HOME_LOCATION, LISTING_ID from LISTING where HLCN='" + TextBox1.Text + "'", conn);
                DataTable dttt = new DataTable();
                sda.Fill(dttt);

                lblmessage.Text = "Witamy na stronie nieruchomosci na ulicy: " + dttt.Rows[0][0];
                Session["Dom"] = Convert.ToString(dttt.Rows[0][1]);

                divThankYou.Visible = true;
            }
            else
            {

                Labelfailaut1.Text = " Przepraszamy! Nie ma takiej nieruchomości! ";
                divFailAut1.Visible = true;

            }  
        }

        protected void ButtonPopUp_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Dom.aspx");
        }

        protected void ButtonPopUp_Click2(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            divFailAut1.Visible = false;
        }
    }
}
