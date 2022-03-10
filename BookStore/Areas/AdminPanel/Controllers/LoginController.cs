using BookStore.Areas.AdminPanel.ViewModels;
using DataAccesLayer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        // GET: AdminPanel/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Admin admin = db.Admins.First(x=>x.Mail==model.Mail && x.Password==model.Password);
                Session["admin"]=admin;
                if (model.RememberMe)
                {
                    HttpCookie userInfo = new HttpCookie("AdminInfo");
                    userInfo["adminmail"] = model.Mail;
                    userInfo["adminpassword"] = model.Password;
                    userInfo.Expires= DateTime.Now.AddDays(10);
                    Response.Cookies.Add(userInfo);
                }
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public ActionResult LogOut() 
        {
            if (Request.Cookies["AdminInfo"] != null)
            {
                HttpCookie cookie = new HttpCookie("adminInfo");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
                Session["admin"] = null;
            }
            return RedirectToAction("Index","Login");
        }
    }
}