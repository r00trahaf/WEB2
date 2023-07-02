using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3

{
    
    public partial class WebForm11 : System.Web.UI.Page
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
                Label1.Text = Convert.ToString((int)reader["Id"]);
                TextBox1.Text = (string)reader["name"];

                TextBox2.Text = Convert.ToString((int)reader["price"]);

                TextBox3.Text = (string)reader["category"];

                Image1.ImageUrl = "~//img//" + (string)reader["imagefilename"]; ;

            }

            reader.Close();
            conn.Close();
        }



        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\Menu.mdf;Integrated Security=True;Connect Timeout=30");
            string sql;
            sql = "SELECT * FROM itemsall where name ='" + TextBox1.Text + "' ";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {


                RadioButton1.Checked = ((Boolean)reader["discountYes"]);

                RadioButton2.Checked = ((Boolean)reader["discountNo"]);


                reader.Close();
                conn.Close();
            }


        }
    }
}
      
       

