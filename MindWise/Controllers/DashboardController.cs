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

        public JsonResult GetCVVLDG(JQueryDataTableParamModel jModel, string serchByName = "", string searchByBin = "")
        {
            try
            {
                string sortBy = jModel.iSortingCols + " " + jModel.sSortDir;
                var result = DashboardRepository.GetCVVLDG(Convert.ToInt32(UserSession.ClientID), serchByName, searchByBin, jModel.iDisplayStart, jModel.iDisplayLength);
                int? totalRecord = result.Count > 0 ? result[0].TotalRecords : 0;
                var CVVLDG = result.Select(row => new string[]
                         {
                            Convert.ToString(row.UserName),//0
                            Convert.ToString(row.Bin),//1
                            Convert.ToString(row.Bank),//2
                            Convert.ToString(row.CardClass),//3
                            Convert.ToString(row.STATE),//4
                            Convert.ToString(row.City)//5
                         });
                return Json(new
                {
                    iTotalRecords = totalRecord,
                    iTotalDisplayRecords = totalRecord,
                    aaData = CVVLDG
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}