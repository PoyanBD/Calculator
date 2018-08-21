using Operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Operation.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(OperationViewModel model, string command)
        {
            if (command == "add")
            {
                model.Resualt = model.A + model.B;
            }
            if (command == "sub")
            {
                model.Resualt = model.A - model.B;
            }
            if (command == "mul")
            {
                model.Resualt = model.A * model.B;
            }
            if (command == "div")
            {
                model.Resualt = model.A / model.B;
            }
            return View(model);

        }
    }
}