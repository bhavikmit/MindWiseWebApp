using DAL.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Repository;
using DAL.Models;
using DAL.Entities;

namespace MindWise.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = UserRepository.ValidUser(model.UserName, model.Password);
                    if (result!=null)
                    {
                        SetSession(result);
                        return Json("1", JsonRequestBehavior.AllowGet);
                    }
                }
                return Json("0", JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void SetSession(User user)
        {
            UserSession.UserName = user.UserName;
            UserSession.Email = user.Email;
            UserSession.UserID = user.UserID;
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            try
            {
                Session.Abandon();
                Session.Clear();
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}