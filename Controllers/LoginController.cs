using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task< IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                //Claim → "kullanıcı hakkında bilgi"dir.Bu örnekte kullanıcının mail adresini bir claim olarak kaydediyoruz.Bu bilgi daha sonra kullanılır → "Kim login oldu?", "Hangi mail ile?" vs.
    {
        new Claim(ClaimTypes.Name, p.WriterMail)
    };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity); //Principal → kullanıcının tüm kimliğini ve claimlerini temsil eder.Kısaca: Principal → "Bu kişi şu claim'lere sahip şu kullanıcıdır."
                await HttpContext.SignInAsync(principal);//Bu komutla cookie'ye bu principal (kullanıcı bilgisi) kaydediliyor.Tarayıcıya bir cookie gönderiliyor → böylece kullanıcı login olmuş sayılıyor.
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }

        }
    }
}
//Context c = new Context();
//var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
//if (datavalue != null)
//{
//    HttpContext.Session.SetString("username", p.WriterMail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}

//Claim → "kullanıcı hakkında bilgi"

//ClaimsIdentity → kullanıcının kimlik kartı

//ClaimsPrincipal → kullanıcının oturumu

//SignInAsync → bu kimliği cookie'ye kaydeder, tarayıcıya gönderir

//Sonraki sayfalarda bu cookie sayesinde kullanıcı tanınır.