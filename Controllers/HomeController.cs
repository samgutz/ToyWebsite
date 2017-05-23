using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Managers;
using WebApplication.Models.NewsViewModels;
using WebApplication.Models.ContactViewModels;


namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Just what you've been looking for";

            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Have questions? We can help! ";
            return View();
        }

        [HttpPost] 
         public IActionResult Contact(ContactViewModel model)
         {
             try
             {
                ContactManger.SendNotificationEmail(model);
                return RedirectToAction("ContactSuccessMessage");
             }
             catch
             {
                 ModelState.AddModelError(string.Empty, "Unable to Send Message at this time");
                 return
             }
         }

        public IActionResult ContactSuccessMessage()
        {
            ViewData["Message"] = "We will be in contact soon!";
            return View();
        }
        
        public IActionResult News()
        {
            List<Article> news = NewsManager.GetNews();
            NewsViewModel model = new NewsViewModel(news);
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
