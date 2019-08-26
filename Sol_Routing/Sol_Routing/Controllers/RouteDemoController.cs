using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Routing.Models;

namespace Sol_Routing.Controllers
{
    [Route("web/route")]
    public class RouteDemoController : Controller
    {

        //[Route("index")]
        [HttpGet("index",Name ="index")]
        public IActionResult Index()
        {
            return View();
        }

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        [HttpGet("getvalue/{id:int}", Name ="getvalue")]
        public IActionResult OnHttpGetValues()
        {
            return RedirectToRoute("index");
        }

        [BindProperty()]
        public UserModel Users { get; set; }

        [HttpPost("/post/onsubmit",Name ="onsubmit")]
        public IActionResult OnHttpPostDemo()
        {
            return View("index");
        }

        [HttpPost("/post/onsubmitroutevalue",Name ="onsubmitroute")]
        public IActionResult OnHttpDemo()
        {
            return View("index");
        }
       
    }
}