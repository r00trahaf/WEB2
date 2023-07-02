using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string r = "customer";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
            String sql;
            sql = "insert into myusers(name,password,role) values ( '" + TextBox1.Text + "' , '" + TextBox2.Text + "', '" + r + "')";
            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();
            comm.ExecuteNonQuery();

            conn.Close();


            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox2.Text = "";
            Label1.Visible = true;

            Label1.Text = "You have successfully added new customer acount";
            Response.Redirect("customerhome.aspx");


        }

       
    }
}