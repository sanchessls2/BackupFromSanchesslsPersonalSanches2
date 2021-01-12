using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace LearnEnglishWords
{
    internal class Email
    {
        internal static void SendReport(string report,List<MemoryStream> attachs)
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

                int i = 0;
                foreach (var item in attachs)
                {
                    i++;
                    item.Position = 0;
                    mail.Attachments.Add(new Attachment(item, "Graph" + i + ".Jpeg", "image/jpg"));
                }


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
