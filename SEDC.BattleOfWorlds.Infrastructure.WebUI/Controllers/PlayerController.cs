using SEDC.BattleOfWorlds.Infrastructure.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEDC.BattleOfWorlds.Infrastructure.WebUI.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        ThePlayer Me = new ThePlayer();

        [Authorize]
        public ActionResult Index()
        {
            return View(Me);
        }

        [Authorize]
        public JsonResult UpZeBuilding(int buildingID)
        {
            Builder.Building(buildingID);
            return Json("ok");
        }
    }
}