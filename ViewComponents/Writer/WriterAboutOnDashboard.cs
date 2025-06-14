﻿using Business_Layer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDahsboard : ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail)
                                    .Select(y => y.WriterID)
                                    .FirstOrDefault();
            var values = writermanager.GetWriterById(writerID);
            return View(values);


        }
    }

}
