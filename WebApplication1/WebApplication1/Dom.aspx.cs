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
    public partial class Dom : System.Web.UI.Page
    {
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=|DataDirectory|\BazaDanych.mdf;Integrated Security=True");
        SqlCommand Sq;

        String IDlist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IDlist = Convert.ToString(Session["Dom"]);
                int IDtego = Convert.ToInt32(IDlist);
                var context = new BazaDanychEntities();

                using (BazaDanychEntities ctx = new BazaDanychEntities())
                {
                    var query = (from c in ctx.LISTING                                 
                                 where c.LISTING_ID == IDtego
                                 select new
                                 {
                                     c.HLCN,
                                     c.HOUSE_PRICE,
                                     c.BATHROOMS,
                                     c.BEDROOMS,
                                     c.HOME_LOCATION,
                                     c.CONTACT_NAME,
                                     c.E_MAIL_CONTACT,
                                     c.PHONE_CONTACT,
                                     c.ADDRESS,
                                     c.SQUARE_FEET,
                                     c.YEAR_BUILD,
                                     c.LOT_SIZE,
                                     c.GARAGE,
                                     c.NOTES}).First();

                    if (query != null)
                    {
                        NaglowekStronyDomu.InnerText = "Dom - " + Convert.ToString(query.HLCN);

                        Label1.Text = "Cena: " + Convert.ToString(query.HOUSE_PRICE) + "zł";
                        Label2.Text = "Ilość sypialni: " + Convert.ToString(query.BEDROOMS);
                        Label3.Text = "Adres: " + Convert.ToString(query.HOME_LOCATION);
                        Label4.Text = "Powierzchnia budowy: " + Convert.ToString(query.SQUARE_FEET);
                        Label5.Text = "Garaz: " + Convert.ToString(query.GARAGE); ;
                        Label6.Text = "Telefon: " + Convert.ToString(query.PHONE_CONTACT); ;
                        Label7.Text = "Okreg: " + Convert.ToString(query.ADDRESS);
                        Label8.Text = "Ilosc lazienek: " + Convert.ToString(query.BATHROOMS);
                        Label9.Text = "Rok budowy: " + Convert.ToString(query.YEAR_BUILD);
                        Label10.Text = "Powierzchnia dzialki: " + Convert.ToString(query.LOT_SIZE);
                        Label11.Text = "Kontaktowa osoba: " + Convert.ToString(query.CONTACT_NAME);
                        Label12.Text = "Poczta elektroniczna: " + Convert.ToString(query.E_MAIL_CONTACT);
                        Label13.Text = "" + Convert.ToString(query.NOTES);
                    }
                }



                //sda = new SqlDataAdapter("Select * from LISTING where LISTING_ID ='"+IDlist+"'",conn);
                //DataTable Dtt = new DataTable();
                //sda.Fill(Dtt);

                //NaglowekStronyDomu.InnerText = "Dom - " + Convert.ToString(Dtt.Rows[0][1]);

                //Label1.Text = "Cena: " + Convert.ToString(Dtt.Rows[0][2]) + "zł";
                //Label2.Text = "Ilość sypialni: " + Convert.ToString(Dtt.Rows[0][4]);
                //Label3.Text = "Adres: " + Convert.ToString(Dtt.Rows[0][9]);
                //Label4.Text = "Powierzchnia budowy: " + Convert.ToString(Dtt.Rows[0][10]);
                //Label5.Text = "Garaz: " + Convert.ToString(Dtt.Rows[0][13]); ;
                //Label6.Text = "Telefon: " + Convert.ToString(Dtt.Rows[0][8]); ;
                //Label7.Text = "Okreg: " + Convert.ToString(Dtt.Rows[0][5]);
                //Label8.Text = "Ilosc lazienek: " + Convert.ToString(Dtt.Rows[0][3]);
                //Label9.Text = "Rok budowy: " + Convert.ToString(Dtt.Rows[0][11]);
                //Label10.Text = "Powierzchnia dzialki: " + Convert.ToString(Dtt.Rows[0][12]);
                //Label11.Text = "Kontaktowa osoba: " + Convert.ToString(Dtt.Rows[0][6]);
                //Label12.Text = "Poczta elektroniczna: " + Convert.ToString(Dtt.Rows[0][7]);
                //Label13.Text = "" +  Convert.ToString(Dtt.Rows[0][14]);

                sda = new SqlDataAdapter("Select IMAGE_PATH from LISTING_IMG where LISTING_ID='"+ IDlist + "'",conn);
                DataTable Dtt = new DataTable();
                sda.Fill(Dtt);
                DataList1.DataSource = Dtt;
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Dom"] = null;
            Response.Redirect("~/MainMenu.aspx");           
        }
    }
}
