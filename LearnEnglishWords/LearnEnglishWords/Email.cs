using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace LearnEnglishWords
{
    internal class Email
    {
        internal static void SendReport(string report)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sanchessls@gmail.com");
                mail.To.Add("sanchessls@gmail.com");
                mail.To.Add("natalia-frade@hotmail.com");
                mail.Subject = "Treino de Inglês" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                mail.Body = report;

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

        internal static void SendProva(string v)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sanchessls@gmail.com");
                mail.To.Add("sanchessls@gmail.com");
                //mail.To.Add("natalia-frade@hotmail.com");
                mail.Subject = "PROVA NATALIA " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                mail.Body = v;

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
