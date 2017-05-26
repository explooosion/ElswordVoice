using System;
using System.Text;

using System.Xml;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;
namespace ElswordVoice.Config
{
    class Net
    {
        /**
          *網頁資料存放區XML － 2016/02/14 IncrEdibLe (Robby)
          */

        private XmlDocument xmlDoc;
        private XmlNode node;

        private string version = String.Empty;
        private string message = String.Empty;
        private string download = String.Empty;
        private string info_content = String.Empty;
        private string info_date = String.Empty;

        private string url = Properties.Resources.XML; // 讀取公告的位置(暫時用AWS S3 .. 一年試用快屆滿了QQ)
        //private string url = String.Empty;

        private MailMessage mail;
        private SmtpClient smtp;
        private Attachment attachment;

        private bool LoadXML()
        {
            try
            {
                // 讀取網址的 XML 並解析
                xmlDoc = new XmlDocument();
                xmlDoc.Load(url);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public string GetVersion()
        {
            if (LoadXML() == true)
            {
                node = xmlDoc.DocumentElement.SelectSingleNode("/response/version");
                version = node.InnerText;
                Console.WriteLine("version:{0}", version);
            }
            return version;
        }

        public string GetDownloadUrl()
        {
            if (LoadXML() == true)
            {
                node = xmlDoc.DocumentElement.SelectSingleNode("/response/download");
                download = node.InnerText;
                Console.WriteLine("download:{0}", download);
            }
            return download;
        }

        public string GetMessage()
        {
            if (LoadXML() == true)
            {
                node = xmlDoc.DocumentElement.SelectSingleNode("/response/message");
                message = node.InnerText;
                Console.WriteLine("message:{0}", message);
            }
            return message;
        }

        public string GetInfoContent()
        {
            if (LoadXML() == true)
            {
                node = xmlDoc.DocumentElement.SelectSingleNode("/response/info/content");
                info_content = node.InnerText;
                Console.WriteLine("info_content:{0}", info_content);
            }
            return info_content;
        }

        public string GetInfoDate()
        {
            if (LoadXML() == true)
            {
                node = xmlDoc.DocumentElement.SelectSingleNode("/response/info/date");
                info_date = node.InnerText;
                Console.WriteLine("info_date:{0}", info_date);
            }
            return info_date;
        }


        // Mail ==============================================================================

        public void SetMail(string from, string to, string name, string subject, string body, string photo_name, string phto_path)
        {
            mail = new MailMessage(from, to);

            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Priority = MailPriority.High;

            mail.Subject = subject;

            body = body.Replace(Environment.NewLine, "<br>");
            mail.Body = "回報暱稱： " + name + "<br>" + "問題內容： " + body;

            smtp = new SmtpClient("msa.hinet.net", 25); // 使用hinet當作跳板寄信

            if (photo_name != "無" && File.Exists(phto_path))
            {
                attachment = new Attachment(phto_path);
                mail.Attachments.Add(attachment);
            }
        }

        public void SendMail()
        {
            if (smtp != null && mail != null)
            {
                smtp.Send(mail);
                Application.DoEvents();

                smtp = null;  //清空
                mail.Dispose(); //釋放資源
            }
        }
    }
}
