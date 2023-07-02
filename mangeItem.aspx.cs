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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.FileName != "")
            {
                string imgfile = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("imgs") + "\\" + imgfile);


                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
                string sql;
                sql = "insert into itemsall (name,descraption,price,discountyes, discountno,quantity,category, imagefilename) values ( '" + TextBox1.Text + "' , '" + TextBox5.Text + "' , '" + TextBox2.Text + "', '" + TextBox3.Text + "' , '" + RadioButton1.Checked + "' , '" + RadioButton2.Checked + "' , '" + DropDownList1.Text + "',   '" + imgfile + "' )" ;
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox5.Text = "";
                Label1.Text = "sucessfull inserted ";
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
            string sql;
            sql = "SELECT * FROM itemsall where name ='" + TextBox1.Text + "' ";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                TextBox2.Text = Convert.ToString((int)reader["price"]);
                TextBox3.Text = Convert.ToString((int)reader["quantity"]);
                RadioButton1.Checked = (bool)reader["discountyes"];
                RadioButton2.Checked = (bool)reader["discountno"];


                TextBox5.Text = (string)reader["descraption"];
                Label2.Text = ((string)reader["imagefilename"]);
                DropDownList1.Text = (string)reader["category"];


                Image1.ImageUrl = "~//images//" + ((string)reader["imagefilename"]);

            }
            reader.Close();
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string imgfile = "";
            if (FileUpload1.FileName != "")
            {
                imgfile = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("imgs") + "\\" + imgfile);
            }
            else imgfile = Label2.Text;
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
            string sql;
            sql = "update  itemsall set descraption ='" + TextBox5.Text + "' , price = '" + TextBox2.Text + "' ,  discountyes = '" + RadioButton1.Checked + "'  ,  discountno = '" + RadioButton2.Checked + "'      , quantity = '" + TextBox3.Text + "' , category = '" + DropDownList1.SelectedItem.Text + "', imagefilename = '" + imgfile + "'    where name ='" + TextBox1.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox5.Text = "";
            Label1.Text = "sucessfull updated ";

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rahaf\\OneDrive\\Documents\\mynewdb.mdf;Integrated Security=True;Connect Timeout=30");
            string sql;

            sql = "delete from itemsall where  name ='" + TextBox1.Text + "' " ;
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox5.Text = "";
                RadioButton2.Checked = true;
                DropDownList1.ClearSelection();
                Label1.Text = "sucessfully deleted ";
                Label2.Text = " ";
                Image1.ImageUrl = "";
            }
            catch (Exception ex)
            { Label1.Text = "Exception!<br />" + ex.Message; }

            finally { conn.Close(); }

        }
    }
}


