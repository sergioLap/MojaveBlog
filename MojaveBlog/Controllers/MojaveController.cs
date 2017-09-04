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

        public ViewResult Category(string category, int p = 1)
        {
            var viewModel = new ListViewModel(_mojaveRepository, category, "Category", p);

            if(viewModel.Category == null)
                throw new HttpException(404, "Такого раздела не существует!");

            ViewBag.Title = String.Format(@"Последние записи в разделе '{0}'",
                        viewModel.Category.Name);

            return View("List", viewModel);

        }


        public ViewResult Tag(string tag, int p = 1)
        {
            var viewModel = new ListViewModel(_mojaveRepository, tag, "Tag", p);

            if (viewModel.Tag == null)
                throw new HttpException(404, "Такого раздела не существует!");

            ViewBag.Title = String.Format(@"Последние записи по тэгу '{0}'",
                        viewModel.Tag.Name);

            return View("List", viewModel);

        }

    }
}