using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");

            string sql;
            sql = "SELECT * FROM itemsall where Id ='" + Request.QueryString["idd"] + "' ";
            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                Label1.Text = (string)reader["name"];
                Image1.ImageUrl = "~//imgs//" + (string)reader["imagefilename"];
                Label3.Text = Convert.ToString((int)reader["price"]);
                Label4.Text = Convert.ToString((int)reader["quantity"]);
                if ((Boolean)reader["discountyes"] == true) Label5.Text = "yes";
                else Label5.Text = "no";
              
            }

            reader.Close();
            conn.Close();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");

            string sql;
            sql = "UPDATE itemsall  SET quantity  = quantity   - '" + TextBox1.Text + "'  where (id ='" + Request.QueryString["idd"] + "' )";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();

            Session["name"] = "alaa";// should be assigned during login 
            sql = "insert into orders  (username,itemid,quantity) values ( '" + (string)Session["name"] + "' , '" + Request.QueryString["idd"] + "', '" + TextBox1.Text + "' )";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Label8.Text = "thank you for buying from our store";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label7.Text = Convert.ToString(Convert.ToInt16(Label3.Text) * Convert.ToInt16(TextBox1.Text));
        }


    }
}