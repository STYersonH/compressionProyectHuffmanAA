using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace FileCompressionTool
{
    internal class Correo
    {
        public string correo { get; set; }
        public string alias { get; set; }
        public string contrasenia { get; set; }
        public int puerto { get; set; }
        public string smtp { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
        public List<string> destinatarios { get; set; }
        public List<string> adjuntos { get; set; }
        //public string urlImage { get; set; }

        public static bool Send(Correo correo)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(correo.smtp, correo.puerto);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correo.correo, correo.alias);

                //permitir las enies
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                /*
                if (!string.IsNullOrEmpty(correo.urlImage))
                {
                    //Vista
                    AlternateView avHtml = AlternateView.CreateAlternateViewFromString(correo.cuerpo + "<br/><img src=cid:Imagen1>", null, "text/html");
                    LinkedResource lr = new LinkedResource(correo.urlImage, MediaTypeNames.Image.Jpeg);
                    lr.ContentId = "Imagen1";
                    avHtml.LinkedResources.Add(lr);
                    mail.AlternateViews.Add(avHtml);
                    mail.Body = lr.ContentId;
                }
                else
                {
                    mail.Body = correo.cuerpo;
                }
                */
                mail.Body = correo.cuerpo;

                mail.Subject = correo.asunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                foreach (var destinatario in correo.destinatarios)
                {
                    if (!string.IsNullOrWhiteSpace(destinatario))
                    {
                        mail.To.Add(destinatario);
                    }
                }

                foreach (var adjunto in correo.adjuntos)
                {
                    if (!string.IsNullOrWhiteSpace(adjunto))
                    {
                        mail.Attachments.Add(new Attachment(adjunto));
                    }
                }

                cliente.Credentials = new NetworkCredential(correo.correo, correo.contrasenia);
                cliente.EnableSsl = true;
                cliente.Send(mail);


                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }
    }
}
