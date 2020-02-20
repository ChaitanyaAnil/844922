using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace SMTPdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromAddress = new MailAddress("chaitanyaanil97@gmail.com", "from");
            var toAddress = new MailAddress("sasidurgaprasad@gmail.com", "to");
            const string fromPassword = "******";
            const string subject = "subjct";
            const string body = "Body --sampleemail sending through smtp";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
