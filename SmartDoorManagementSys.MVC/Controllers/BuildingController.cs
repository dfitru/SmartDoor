using SmartDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartDoorManagementSys.MVC.Controllers
{
    [Authorize]
    public class BuildingController : Controller
    {
        // GET: Building
        public ActionResult Index()
        {
            var model = new BuildingListItems[0];
            return View(model);
        }
        //Get
        public ActionResult Create()
        {
            return View();
        }
    }
}