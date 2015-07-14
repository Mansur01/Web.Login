using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginUser(TBL_LOGIN login)
        {
            if (ModelState.IsValid)
            {

                NewDBEntities ent = new NewDBEntities();
                var v = ent.TBL_LOGIN.Where(a => a.UserName.Equals(login.UserName) && a.Password.Equals(login.Password)).FirstOrDefault();
                if (v != null)
                {
                    Session["UserName"] = v.UserName.ToString();
                    return RedirectToAction("AfterLogin");
                    
                }
            } 
            
            return View(login);
            
        }

        public ActionResult AfterLogin()
        {
            return View();
        }
    }


}