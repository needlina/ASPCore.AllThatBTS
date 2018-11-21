using ASPCore.AllThatBTS.BizDac;
using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;

namespace ASPCore.AllThatBTS.Web.Controllers
{
    public class HomeController : Controller
    {
        UserBiz userBiz;
        public HomeController(IOptions<ConfigurationManager> settings)
        {
            userBiz = new UserBiz(settings);
        }

        public IActionResult Index()
        {
            List<User> users = userBiz.GetAllUser();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
