using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestCreateCheckBoxInMVC.Models;

namespace TestCreateCheckBoxInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddRole()
        {

            var list = new List<RoleCheckBoxModel>
            {
                 new RoleCheckBoxModel{Id = 1, Name = "Admin", Checked = false},
                 new RoleCheckBoxModel{Id = 2, Name = "Guest", Checked = false},
                 new RoleCheckBoxModel{Id = 3, Name = "Member", Checked = false},
         

            };
            return View(list);
        }
        [HttpPost]
        public ActionResult AddRole(List<RoleCheckBoxModel> list)
        {
            foreach (var item in list)
            {
                if (item.Checked)
                {
                    //Do something
                }
            }
            return View();
        }
    }
}