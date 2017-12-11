using DAL.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Utility;
using DAL.Models;

namespace MindWise.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            try
            {
                var result = DashboardRepository.GetCardClass(Convert.ToInt32(UserSession.ClientID));
                return View(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}