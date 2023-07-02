using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EmailBottunClick(object sender, EventArgs e)
        {

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("aimanturanil@ gmail.com");
            mail.To.Add(textbox1.Text); // receiver email address
            mail.Subject = "Test Mail - 1";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = textbox2.Text;
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("aimanturani@ gmail.com", "123d");
            SmtpServer.EnableSsl = true;
            //   SmtpServer.Send(mail);
            statusLabel.Text = "Email sent.";

        }
    }
}