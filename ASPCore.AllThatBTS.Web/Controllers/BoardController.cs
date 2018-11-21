using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.AllThatBTS.Web.Controllers
{
    public class BoardController : Controller
    {
        [Route("Board/{id}")]
        public IActionResult Board(string id)
        {
            return View(id);
        }

        public IActionResult Write()
        {
            return View();
        }
    }
}