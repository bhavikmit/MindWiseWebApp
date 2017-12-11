using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace DAL.Repository
{
    public static class DashboardRepository
    {
        public static List<CardClass> GetCardClass(int clientId)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return db.GetCardClass(clientId).
                    Select(x => new CardClass
                    {
                        CardCount = x.CardCount,
                        ClassName = x.CardClass
                    }).ToList();
            }
        }
        public static List<CVVLDGClass> GetCVVLDG(int clientId, string SerchBy, int pageIndex, int pageSize)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return db.GetCVVLDG(clientId, SerchBy, pageIndex, pageSize).
                    Select(x => new CVVLDGClass
                    {
                        FirstName = x.First_Name,
                        LastName = x.Last_Name,
                        Address = x.Address,
                        Price = x.Price,
                        City = x.City,
                        STATE = x.STATE,
                        Zip = x.Zip,
                        DOB = x.DOB,
                        Phone = x.Phone,
                        Gender = x.Gender,
                        TotalRecords = x.TotalRecords
                    }).ToList();
            }
        }
        public static List<DUMPSLDGClass> GetDUMPSLDG(int clientId, string SearchBy, int pageIndex, int pageSize)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return db.GetDUMPSLDG(clientId, SearchBy, pageIndex, pageSize).
                    Select(x => new DUMPSLDGClass
                    {
                        Tracks=x.Tracks,
                        Price=x.Price,
                        Refundable = x.Refundable,
                        STATE = x.STATE,
                        City = x.City,
                        Zip = x.Zip,
                        TotalRecords = x.TotalRecords
                    }).ToList();
            }
        }
    }
}
