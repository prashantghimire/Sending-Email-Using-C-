using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sending
{
    class Program
    {
        static void Main(string[] args)
        {
            sendEmail("prashant.ghimire@selu.edu");
        }
        public static void sendEmail(string email){
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("w0512595@selu.edu");
                mail.Subject = "Hello";
                mail.Body = "How are you ?";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("your_email_address@gmail.com", "password");// Enter senders User name and password
                smtp.EnableSsl = true;
                Console.WriteLine("Sending email .... ");
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine("Email sending failed: " + e.Message);
            }

            Console.WriteLine("Email has been sent to "+email);
            Console.ReadKey();
        }
    }
}
