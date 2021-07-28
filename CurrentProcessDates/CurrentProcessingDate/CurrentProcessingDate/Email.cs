using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace LearnEnglishWords
{
    internal class Email
    {
        internal static void SendReport(string report,string FullText)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sanchessls@gmail.com");
                mail.To.Add("sanchessls@gmail.com");
                mail.Subject = report;
                mail.Body = FullText;

                int i = 0;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sanchessls@gmail.com", "125811271125811271");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
    }
}
