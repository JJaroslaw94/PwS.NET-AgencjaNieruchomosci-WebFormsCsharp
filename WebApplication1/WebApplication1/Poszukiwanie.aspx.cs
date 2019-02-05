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
    public partial class Poszukiwanie : System.Web.UI.Page
    {

        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\PwS.NET-AgencjaNieruchomosci-WebFormsCsharp\WebApplication1\WebApplication1\App_Data\BazaDanych.mdf;Integrated Security=True");
        SqlCommand Sq;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DDL1
                DropDownList1.Items.Add("Nie wyznaczone");
                DropDownList1.Items.Add("50000");
                DropDownList1.Items.Add("100000");
                DropDownList1.Items.Add("150000");
                DropDownList1.Items.Add("200000");

                //DDL2
                DropDownList2.Items.Add("Nie wyznaczone");
                DropDownList2.Items.Add("150000");
                DropDownList2.Items.Add("200000");
                DropDownList2.Items.Add("300000");
                DropDownList2.Items.Add("500000");


                //DDL3
                DropDownList3.Items.Add("Nie wyznaczone");
                DropDownList3.Items.Add("Min 1");
                DropDownList3.Items.Add("Min 2");
                DropDownList3.Items.Add("Min 3");
                DropDownList3.Items.Add("Min 4");

                //DDL4
                DropDownList4.Items.Add("Nie wyznaczone");
                DropDownList4.Items.Add("Min 1");
                DropDownList4.Items.Add("Min 2");
                DropDownList4.Items.Add("Min 3");
                DropDownList4.Items.Add("Min 4");

                //DDL5
                DropDownList5.Items.Add("Nie wyznaczone");

                sda = new SqlDataAdapter("Select HOME_LOCATION from LISTING", conn);
                DataTable Dtt = new DataTable();
                sda.Fill(Dtt);

                int iloscOkregow = Dtt.Rows.Count;

                for (int i =0; i<iloscOkregow; i++)
                {
                    if (DropDownList5.Items.FindByText(Convert.ToString(Dtt.Rows[i][0])) == null)
                    {
                        DropDownList5.Items.Add(Convert.ToString(Dtt.Rows[i][0]));
                    }
                }
                

                //DDL6
                DropDownList6.Items.Add("Nie wyznaczone");
                DropDownList6.Items.Add("Cenie");
                DropDownList6.Items.Add("Łazienkach");
                DropDownList6.Items.Add("Sypialniach");
            }
            
        }

        protected void ButtonPosz1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMenu.aspx");
        }

        protected void ButtonPosz2_Click(object sender, EventArgs e)
        {
            String where = "";

            int indexDDL1 = DropDownList1.SelectedIndex;
            int indexDDL2 = DropDownList2.SelectedIndex;
            int indexDDL3 = DropDownList3.SelectedIndex;
            int indexDDL4 = DropDownList4.SelectedIndex;
            int indexDDL5 = DropDownList5.SelectedIndex;
            int indexDDL6 = DropDownList6.SelectedIndex;



            Boolean flagaAND = false;

            if (indexDDL1 == 0)
                {} else
            if (indexDDL1 == 1)
                { where = where + "where HOUSE_PRICE > '50000' "; }
            else 
            if (indexDDL1 == 2)
                { where = where + "where HOUSE_PRICE > '100000' "; }
            else
            if (indexDDL1 == 3)
                { where = where + "where HOUSE_PRICE > '150000' "; }
            else
            if (indexDDL1 == 4)
                { where = where + "where HOUSE_PRICE > '200000' "; }

          
            if (indexDDL2 == 0)
            { }
            else
            if (indexDDL2 == 1)
            {
                if (where.Length != 0)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " HOUSE_PRICE < '150000' ";
                flagaAND = true;
            }
            else
            if (indexDDL2 == 2)
            {
                if (where.Length != 0)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " HOUSE_PRICE < '200000' ";
                flagaAND = true;
            }
            else
            if (indexDDL2 == 3)
            {
                if (where.Length != 0)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " HOUSE_PRICE < '300000' ";
                flagaAND = true;
            }
            else
            if (indexDDL2 == 4)
            {
                if (where.Length != 0)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " HOUSE_PRICE < '500000' ";
                flagaAND = true;
            }
          
            if (indexDDL3 == 0)
            { }
            else
            if (indexDDL3 == 1)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BATHROOMS > '0' ";
                flagaAND = true;
            }
            else
            if (indexDDL3 == 2)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BATHROOMS > '1' ";
                flagaAND = true;
            }
            else
            if (indexDDL3 == 3)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BATHROOMS > '2' ";
                flagaAND = true;
            }
            else
            if (indexDDL3 == 4)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BATHROOMS > '3' ";
                flagaAND = true;
            }
                       
            if (indexDDL4 == 0)
            {  }
            else
            if (indexDDL4 == 1)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BEDROOMS > '0' ";
                flagaAND = true;
            }
            else
            if (indexDDL4 == 2)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BEDROOMS > '1' ";
                flagaAND = true;
            }
            else
            if (indexDDL4 == 3)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BEDROOMS > '2' ";
                flagaAND = true; }
            else
            if (indexDDL4 == 4)
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " BEDROOMS > '3' ";
                flagaAND = true;
            }           

            if (indexDDL5 == 0)
            { }
            else            
            {
                if (where.Length != 0 && flagaAND)
                {
                    where = where + "AND";
                }
                if (where.Length == 0)
                {
                    where = where + "where";
                }
                where = where + " HOME_LOCATION ='"+DropDownList5.Text+"' ";
            }

            if (indexDDL6 == 0)
            {

            }
            else
            if (indexDDL6 == 1)
            {
                where = where + "Order by HOUSE_PRICE";
            }
            else
            if (indexDDL6 == 2)
            {
                where = where + "Order by BATHROOMS";
            }
            else
            if (indexDDL6 == 3)
            {
                where = where + "Order by BEDROOMS";
            }

            Session["CzescQuery"] = where;
            Response.Redirect("~/WynikWyszukiwania.aspx");
            Label1.Text = where;
            ButtonPosz2.Text = ""+ indexDDL1 + indexDDL2 + indexDDL3 + indexDDL4 + indexDDL5 + indexDDL6;
        }
    }
}