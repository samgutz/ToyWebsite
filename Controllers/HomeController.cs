using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Managers;
using WebApplication.Models.NewsViewModels;


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
            ViewData["Message"] = "Sam Gutierrez's Personal Website";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
