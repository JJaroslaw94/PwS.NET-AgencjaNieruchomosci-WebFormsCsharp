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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\PwS.NET-AgencjaNieruchomosci-WebFormsCsharp\WebApplication1\WebApplication1\App_Data\BazaDanych.mdf;Integrated Security=True");
        SqlCommand Sq;

        String IDlist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IDlist = Convert.ToString(Session["Dom"]);
                sda = new SqlDataAdapter("Select * from LISTING where LISTING_ID ='"+IDlist+"'",conn);
                DataTable Dtt = new DataTable();
                sda.Fill(Dtt);

                NaglowekStronyDomu.InnerText = "Dom - " + Convert.ToString(Dtt.Rows[0][1]);

                Label1.Text = "Cena: " + Convert.ToString(Dtt.Rows[0][2]) + "zł";
                Label2.Text = "Ilość sypialni: " + Convert.ToString(Dtt.Rows[0][4]);
                Label3.Text = "Adres: " + Convert.ToString(Dtt.Rows[0][9]);
                Label4.Text = "Powierzchnia budowy: " + Convert.ToString(Dtt.Rows[0][10]);
                Label5.Text = "Garaz: " + Convert.ToString(Dtt.Rows[0][13]); ;
                Label6.Text = "Telefon: " + Convert.ToString(Dtt.Rows[0][8]); ;
                Label7.Text = "Okreg: " + Convert.ToString(Dtt.Rows[0][5]);
                Label8.Text = "Ilosc lazienek: " + Convert.ToString(Dtt.Rows[0][3]);
                Label9.Text = "Rok budowy: " + Convert.ToString(Dtt.Rows[0][11]);
                Label10.Text = "Powierzchnia dzialki: " + Convert.ToString(Dtt.Rows[0][12]);
                Label11.Text = "Kontaktowa osoba: " + Convert.ToString(Dtt.Rows[0][6]);
                Label12.Text = "Poczta elektroniczna: " + Convert.ToString(Dtt.Rows[0][7]);
                Label13.Text =   Convert.ToString(Dtt.Rows[0][14]);
            }
        }
    }
}