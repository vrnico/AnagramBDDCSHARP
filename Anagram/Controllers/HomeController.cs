using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/anagram")]
        public ActionResult Check()
        {
          string userWord = Request.Form["user-word"];
          List<string> userList = new List<string>{
            Request.Form["list-word1"]
          };
        }
    }
}
