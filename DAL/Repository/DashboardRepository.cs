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
        public static List<CVVLDGClass> GetCVVLDG(int clientId, string serchByName, string searchByBin, int pageIndex, int pageSize)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return db.GetCVVLDG(clientId, serchByName, searchByBin, pageIndex, pageSize).
                    Select(x => new CVVLDGClass
                    {
                        UserName = x.UserName,
                        Bin = x.Bin,
                        Bank = x.Bank,
                        CardClass = x.Card_Class,
                        STATE = x.STATE,
                        City = x.City,
                        TotalRecords = x.TotalRecords
                    }).ToList();
            }
        }
    }
}
