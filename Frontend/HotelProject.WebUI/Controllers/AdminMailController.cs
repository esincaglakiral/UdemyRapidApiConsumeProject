using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)  //mailkit ile mail gönderme işlemi
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "caglakiral@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);   //kimden alacağı

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);  //kime alacağı

            var bodyBuilder = new BodyBuilder();   //mesajın içeriği
            bodyBuilder.TextBody = model.MessageContent;
            mimeMessage.Body = bodyBuilder.ToMessageBody();


            mimeMessage.Subject = model.Subject;


            SmtpClient client = new SmtpClient();  // mailkitin smtp paketini kullanıyoruz
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("caglakiral@gmail.com", "ovrlurtpavyfrmwb");  //mail, password key
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
