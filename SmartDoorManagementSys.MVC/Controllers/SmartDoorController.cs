using SmartDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartDoorManagementSys.MVC.Controllers
{
    [Authorize]
    public class SmartDoorController : Controller
    {
        // GET: SmartDoor
        public ActionResult Index()
        {
            var model = new SmartDoorItemList[0];
            return View(model);
        }
        //Get
        public ActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SmartDoorCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}