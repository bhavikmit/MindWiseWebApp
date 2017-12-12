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
        
    }
}
