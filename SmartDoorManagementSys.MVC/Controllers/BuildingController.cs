using SmartDoor.Models;
using SmartDoor.Services;
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
        private BuildingServices _buildingServices = new BuildingServices();
        
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