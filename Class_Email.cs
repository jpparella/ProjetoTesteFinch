using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace pFinchFila
{
    
    public class Class_Email
    {
        System.Net.Mail.MailMessage mailMessage;
        public String Error = "";

        public Class_Email(String destinatario)
        {
            mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress("contatesteenvio17@gmail.com");
            mailMessage.To.Add(new System.Net.Mail.MailAddress(destinatario));
            
            mailMessage.IsBodyHtml = false;
        }

        public bool EmailInicio(String ID,String Cliente,String Usuario)
        {
            
            mailMessage.Subject = "Serviço iniciado";
            mailMessage.Body = "O usuário com CPF: " + Usuario + " iniciou o serviço " + ID + " do cliente " + Cliente; ;

            //Cópia:
            //mailMessage.CC.Add(new System.Net.Mail.MailAddress("copia@email.com"));

            //Cópia oculta:
            //mailMessage.Bcc.Add(new System.Net.Mail.MailAddress("copia.oculta@email.com"));

            using (var smtp = new System.Net.Mail.SmtpClient())
            { //está tudo fixo aqui para evitar problemas de configuração.
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("contatesteenvio17@gmail.com", "TestarEnvios@123");

                //Exemplo de anexo de texto:
                //mailMessage.Attachments.Add(new System.Net.Mail.Attachment(
                //   new MemoryStream(Encoding.UTF8.GetBytes("conteudo do arquivo")),
                //   "anexo.txt", System.Net.Mime.MediaTypeNames.Text.Plain));

                try
                {
                    smtp.Send(mailMessage);
                }
                catch (System.Exception erro)
                {
                    Error = erro.Message;
                    return false;
                }
            }
           
            return true;
            
        }

        public bool EmailFecha(String ID, String Cliente, String Usuario)
        {

            mailMessage.Subject = "Serviço Finalizado";
            mailMessage.Body = "O usuário com CPF: " + Usuario + " finalizou o serviço " + ID + " do cliente " + Cliente; ;

            //Cópia:
            //mailMessage.CC.Add(new System.Net.Mail.MailAddress("copia@email.com"));

            //Cópia oculta:
            //mailMessage.Bcc.Add(new System.Net.Mail.MailAddress("copia.oculta@email.com"));

            using (var smtp = new System.Net.Mail.SmtpClient())
            { //está tudo fixo aqui para evitar problemas de configuração.
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("contatesteenvio17@gmail.com", "TestarEnvios@123");

                //Exemplo de anexo de texto:
                //mailMessage.Attachments.Add(new System.Net.Mail.Attachment(
                //   new MemoryStream(Encoding.UTF8.GetBytes("conteudo do arquivo")),
                //   "anexo.txt", System.Net.Mime.MediaTypeNames.Text.Plain));

                try
                {
                    smtp.Send(mailMessage);
                }
                catch (System.Exception erro)
                {
                    Error = erro.Message;
                    return false;
                }
            }

            return true;

        }



    }
}
