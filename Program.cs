using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailSenderMercury
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpClient s;
                MailMessage msg;

                s = new SmtpClient();
                msg = new MailMessage();
                //s.Host = "smtp.ihostexchange.net";
                //s.Port = 54566; 
                s.UseDefaultCredentials = true;
                s.Credentials = new NetworkCredential("support", "");
                s.EnableSsl = false;           
                msg.IsBodyHtml = true;
                msg.Body = "hello ";
                msg.Subject = "website";
                msg.To.Add("");
                msg.From = new MailAddress("");
                s.Send(msg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
