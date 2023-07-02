using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alaax\\OneDrive\\Documents\\test.mdf;Integrated Security=True;Connect Timeout=30"); String sql;
            sql = "SELECT * FROM Orders" ;
            SqlCommand comm = new SqlCommand( sql , conn);

            conn.Open();

            SqlDataReader reader = comm.ExecuteReader(); 


            GridView1.DataSource = reader;
            GridView1.DataBind();

            reader.Close();
            conn.Close();
        }
    }
}