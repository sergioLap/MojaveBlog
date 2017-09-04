using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MojaveBlog.Core;
using MojaveBlog.Models;

namespace MojaveBlog.Controllers
{
    public class MojaveController : Controller
    {
        private readonly IRepository _mojaveRepository;
        public MojaveController(IRepository mojaveRepository)
        {
            _mojaveRepository = mojaveRepository;
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ViewResult Posts(int p = 1)
        {
            var listViewModel = new ListViewModel(_mojaveRepository, p);

            ViewBag.Title = "Последние записи";
            return View("List", listViewModel);
        }

    }
}