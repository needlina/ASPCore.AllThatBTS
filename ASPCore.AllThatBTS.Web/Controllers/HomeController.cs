using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.AllThatBTS.Web.Models;
using ASPCore.AllThatBTS.BizDac;
using ASPCore.AllThatBTS.Model;

namespace ASPCore.AllThatBTS.Web.Controllers
{
    public class HomeController : Controller
    {
        public UserBiz userBiz = new UserBiz();
        public IActionResult Index()
        {
            List<User> userList = userBiz.GetAllUser();
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
