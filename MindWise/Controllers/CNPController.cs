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
    public class CNPController : Controller
    {
        // GET: CNP
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCVVLDG(JQueryDataTableParamModel jModel, string SerchBy)
        {
            try
            {
                var result = DashboardRepository.GetCVVLDG(Convert.ToInt32(UserSession.ClientID), SerchBy, jModel.iDisplayStart, jModel.iDisplayLength);
                int? totalRecord = result.Count > 0 ? result[0].TotalRecords : 0;
                var CVVLDG = result.Select(row => new string[]
                         {
                            Convert.ToString(row.FirstName),//0
                            Convert.ToString(row.LastName),//1
                            Convert.ToString(row.Address),//2
                            Convert.ToString(row.Price),//3
                            Convert.ToString(row.City),//4
                            Convert.ToString(row.STATE),//5
                            Convert.ToString(row.Zip),//6
                            Convert.ToString(row.DOB),//7
                            Convert.ToString(row.Phone),//8
                            Convert.ToString(row.Gender)//9
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