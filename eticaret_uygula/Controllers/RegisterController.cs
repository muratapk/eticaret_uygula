using eticaret_uygula.Dto;
using eticaret_uygula.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace eticaret_uygula.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            Random random = new Random();
            int code = 0;
            code = random.Next(10000, 1000000);
            AppUser appuser=new AppUser()
            {
                FirstName = appUserRegisterDto.FirstName,   
                LastName = appUserRegisterDto.LastName, 
                City = appUserRegisterDto.City,
                UserName = appUserRegisterDto.UserName,
                Email = appUserRegisterDto.Email,   
            };
            var result=await _userManager.CreateAsync(appuser,appUserRegisterDto.Password);
            if(result.Succeeded)
            {
                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAdressFrom = new MailboxAddress("Eticaret Uygulaması", "ciplakmurat@gmail.com");
                MailboxAddress mailboxAddressTo = new MailboxAddress("User", appuser.Email);
                mimeMessage.From.Add(mailboxAdressFrom);
                mimeMessage.To.Add(mailboxAddressTo);
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Kaydınız Başarılı Şekilde Gerçekleşti";
                mimeMessage.Body=bodyBuilder.ToMessageBody();
                mimeMessage.Subject = "ETicaret Uygulaması";
                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("muratciplak917@gmail.com", "ayvs pnsr jumg cdqa");
                client.Send(mimeMessage);
                client.Disconnect(true);
                TempData["Mail"] = appUserRegisterDto.Email;
                return RedirectToAction("Confirmation");

            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
