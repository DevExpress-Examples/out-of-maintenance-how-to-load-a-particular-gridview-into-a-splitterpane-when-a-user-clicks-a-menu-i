using System;
using System.Web.Mvc;
using CS.Model;


namespace CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewAction(String _GridViewName) {
            ViewData["GridViewName"] = _GridViewName;
            return View(new MyViewModel { Products = MyModel.GetProducts(), Customers = MyModel.GetCustomers() });
        }

        public ActionResult GridViewPartialProducts() {
            return PartialView(MyModel.GetProducts());
        }

        public ActionResult GridViewPartialCustomers() {
            return PartialView(MyModel.GetCustomers());
        }
    }
}