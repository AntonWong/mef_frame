using System;
using System.ComponentModel.Composition;
using System.Web.Mvc;
using Site.Models;
using Site.Service;

namespace MyMvc1.Controllers
{
    [Export]
    public class HomeController : Controller
    {

        [Import]
        public ITestDataSiteContract TestDataContract { get; set; }

        public ActionResult Index()
        {
            var list = TestDataContract.Menus();
            return View(list);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var i = 1;
            i = TestDataContract.DeleteMenu(id);
            var result = new { id = i, message = "删除成功" };

            return Json(result);
        }

        [HttpPost]
        public ActionResult Add(MenuView model)
        {
            TestDataContract.AddMenu(new MenuView { Name = model.Name });
            var list = TestDataContract.Menus();
            return View("Index", list);
        }

    }
}