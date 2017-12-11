using DAL.Models;
using DAL.Repository;
using DAL.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindWise.Controllers
{
    public class CPController : Controller
    {
        // GET: CP
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetDUMPSLDG(JQueryDataTableParamModel jModel,string SerchBy)
        {
            try
            {
                var result = DashboardRepository.GetDUMPSLDG(Convert.ToInt32(UserSession.ClientID), SerchBy, jModel.iDisplayStart, jModel.iDisplayLength);
                int? totalRecord = result.Count > 0 ? result[0].TotalRecords : 0;
                var DUMPSLDG = result.Select(row => new string[]
                         {
                            Convert.ToString(row.Tracks),//0
                            Convert.ToString(row.Price),//1
                            Convert.ToString(row.Refundable),//2
                            Convert.ToString(row.STATE),//3
                            Convert.ToString(row.City),//4
                            Convert.ToString(row.Zip),//5
                         });
                return Json(new
                {
                    iTotalRecords = totalRecord,
                    iTotalDisplayRecords = totalRecord,
                    aaData = DUMPSLDG
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}