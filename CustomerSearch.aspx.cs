using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");

            string sql;

            sql = "SELECT * FROM myusers where name ='" + TextBox1.Text + "' ";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())

            {

                Label1.Text = (string)reader["name"];
                Label2.Text = (string)reader["password"];
                Label3.Text = (string)reader["role"];
                DateTime d1 = (DateTime)reader["RegistDate"];
                Label4.Text = d1.ToString("yyyy-MM-dd");
            }
            else

            {

                Label1.Text = "no user found ";
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
            }

            reader.Close();

            conn.Close();

        }

    }
}