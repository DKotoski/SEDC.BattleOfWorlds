using N2.Web.Mvc;
using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Infrastructure.DataAccess;
using SEDC.BattleOfWorlds.Infrastructure.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SEDC.BattleOfWorlds.Infrastructure.WebUI.Controllers
{
    public class StartPageController : ContentController<StartPage>
    {
        UserRepository users = new UserRepository();

        public override ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction("Index", "Player");
            //}
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string username, string password)
        {

            if (users.Authenticate(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, true);
                return RedirectToAction("Index", "Player");
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                LogIn(user.Username, user.Password);
            }
            return RedirectToAction("Index");
        }

        internal ActionResult NotFound()
        {
            throw new NotImplementedException();
        }
    }
}