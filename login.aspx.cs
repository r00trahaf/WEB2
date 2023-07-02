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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
            sql = "SELECT * FROM myusers where name ='" + TextBox1.Text + "'and password ='" + TextBox2.Text + "' ";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                Session["role"] = (string)reader["role"];
                Session["user"] = (string)reader["name"];
                Session["pass"] = (string)reader["password"];
                if ((string)Session["role"] == "admin")
                    Server.Transfer("adminhome.aspx");
                else
                    Server.Transfer("customerhome.aspx");
            }
            else
            {
                TextBox1.Text = "no user found or password ";
            }
            reader.Close();
            conn.Close();

            if (CheckBox1.Checked)
            {
                HttpCookie myc = Request.Cookies["c2"];
                if (myc == null)
                {
                    myc = new HttpCookie("c2");
                }
                myc["na"] = TextBox1.Text;
                myc["pa"] = TextBox2.Text;
                myc["che"] = Convert.ToString(CheckBox1.Checked);
                Response.Cookies.Add(myc);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("reg.aspx");
        }
    }
}