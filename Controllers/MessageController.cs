using BlogApiDemo.DataAccessLayer;
using Business_Layer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult SendBox()
        {
            //var username = User.Identity.Name;
            //var usermail = c.Users.Where.(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var WriterID = c.Writers.Where.(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            
            //var values = mm.GetSendBoxListByWriter(writerID);
            return View(/*values*/);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
            //var username = User.Identity.Name;
            //var usermail = c.Users.Where.(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var WriterID = c.Writers.Where.(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            //p.SenderID = WriterID;
            p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("InBox");
        }


    }
}
