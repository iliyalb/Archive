using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// ~/Web.config:

/*
<mailSettings>
      <smtp deliveryMethod="Network" from="noreply@mailserver.com">
        <network
          defaultCredentials="true"
          port="25"
          host="mail.mailserver.com"
          password="12345"
          userName="noreply@mailserver.com"
          />
      </smtp>
</mailSettings>
*/

// ~/Views/SendingEmail.cshtml:

/*
 <table>
            @using (Html.BeginForm("SendingEmail", "Contact", FormMethod.Post))
            {

                <tr>
                    <td>
                        @Html.Label("Subject")
                    </td>
                    <td>
                        @Html.TextBox("Subject")
                    </td>
                </tr>
                <tr>
                    <td>
                        @Html.Label("Body")
                    </td>
                    <td>
                        @Html.TextArea("Body")
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" name="btnSend" value="Send Email" />
                    </td>
                </tr>
            }
        </table>
 */


namespace SOLUTION_NAME
{
    public class ContactController : Controller
    {
        // GET: /Contact/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendingEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendingEmail(string Subject, string Body)
        {
            System.Net.Mail.MailMessage objMM = new System.Net.Mail.MailMessage();
            System.Net.Mail.MailAddress objMA1 = new System.Net.Mail.MailAddress("noreply@mehrdadnaderi.com","Website Administrator",System.Text.Encoding.UTF8);

            objMM.From = objMA1;
            objMM.Sender = objMA1;
            objMM.ReplyToList.Add(objMA1);

            //System.Net.Mail.Attachment oAttachment = new System.Net.Mail.Attachment();
            //objMM.Attachments.Add()

            System.Net.Mail.MailAddress objMA2 = new System.Net.Mail.MailAddress("shirini@shirinkade.com","Shirin Shirini", System.Text.Encoding.UTF8);

            objMM.To.Add(objMA2);
            //objMM.CC.Add();
            //objMM.Bcc.Add();

            objMM.BodyEncoding = System.Text.Encoding.UTF8;
            objMM.Body = Body;
            objMM.IsBodyHtml = true;
            objMM.Subject = Subject;

            objMM.Priority = System.Net.Mail.MailPriority.Normal;
            objMM.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnFailure;

            System.Net.Mail.SmtpClient objSC = new System.Net.Mail.SmtpClient();
            objSC.Timeout = 10000;
            objSC.EnableSsl = true;
            objSC.Send(objMM);

            return View();
        }
	}
}