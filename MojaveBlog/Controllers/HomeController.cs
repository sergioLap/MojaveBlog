using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MojaveBlog.Core;
using MojaveBlog.Models;

namespace MojaveBlog.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View("Index");
        }

    }
}