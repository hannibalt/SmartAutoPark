using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceHelp
{
    public class MailSender
    {
        public MailSender()
        {


        }

        public bool SendMail(string eposta, string context)
        {

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("autocarpark55@gmail.com");
                    mail.To.Add(eposta);
                    mail.Subject = "AutoCarPark Kayıt";
                    mail.Body = context + "\n İyi günler";
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("autocarpark55@gmail.com", "asd-123123");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }


        }
    }
}
