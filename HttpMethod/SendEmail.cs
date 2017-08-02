using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HttpMethod
{
    class SendEmail
    {
        public static readonly string address = System.Configuration.ConfigurationManager.AppSettings["mailaddress"];
        public static readonly string username = System.Configuration.ConfigurationManager.AppSettings["username"];
        public static readonly string passward = System.Configuration.ConfigurationManager.AppSettings["passward"];
        public void Send(EmailModel model)
        {
            //声明一个可以用SmtpClient发送的邮件
            MailMessage mail = new MailMessage();
            //设置邮件的主题
            mail.Subject = model.Subject;

            //StringBuilder content = new StringBuilder();
            //content.Append("姓名：").Append(model.Name).Append("<br / >");
            //content.Append("邮箱：").Append(model.Email).Append("<br / >");
            //content.Append("手机：").Append(model.Mobile).Append("<br / >");
            //content.Append("信息：").Append(model.Content).Append("<br / >");

            //设置邮件的内容
            mail.Body = model.Body;
            //设置邮件内容的编码
            mail.BodyEncoding = Encoding.UTF8;
            //设置邮件是否为html格式
            mail.IsBodyHtml = true;
            //设置邮件的优先级
            mail.Priority = MailPriority.Normal;
            //声明一个用来发送邮件的帐号
            MailAddress mailaddress = new MailAddress(address);
            mail.From = mailaddress;

            //声明一个用来接收邮件的帐号
            MailAddress mailaddress_receive = new MailAddress(model.receiveAddress);
            //将接收邮件的帐号添加到收件人的地址集合，因为可以同时将一封邮件发送给多人，所以这里使用集合类型来存储收件人地址。
            mail.To.Add(mailaddress_receive);

            //声明一个简单邮件传输协议用来发送邮件
            SmtpClient smtpClient = new SmtpClient();
            //设置发件主机的SMTP服务器.比如163的SMTP服务器是：smtp.163.com，不同的主机有不同的SMTP服务器，需要我们到发件邮箱中查询。
            smtpClient.Host = model_emailAccounts.SendAddress;
            //
            smtpClient.UseDefaultCredentials = true;
            //设置SMTP事务的端口，这个也是要到发件邮箱中查询
            smtpClient.Port = 25;
            //设置发件邮箱账号的用户名和密码
            smtpClient.Credentials = new NetworkCredential(username, passward);
            //开始发送
            smtpClient.Send(mail);
        }

    }
    
        public class EmailModel
        {
            /// <summary>
            /// 邮件内容
            /// </summary>
            public string Body { get; set; }

            /// <summary>
            /// 邮件标题
            /// </summary>
            public string Subject { get; set; }

            /// <summary>
            /// 接收邮件的帐号
            /// </summary>
            public string receiveAddress { get; set; }
        }
        public class model_emailAccounts
        {
            public static readonly string SendAddress = System.Configuration.ConfigurationManager.AppSettings["SendAddress"];// "mail.bry.com.cn"; "mail.bry.com.cn";
        }
}
