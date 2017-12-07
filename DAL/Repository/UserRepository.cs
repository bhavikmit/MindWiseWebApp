using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Entities;
namespace DAL.Repository
{
    public class UserRepository
    {
        public static User ValidUser(string userName, string password)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return db.A_PROV_USERS.Where(x => x.UserName == userName && x.Password == password && x.Status == 1).Select(x => new
                User
                {
                    UserName = x.UserName,
                    Password = x.Password,
                    Status = x.Status,
                    Email = x.Email,
                    ClientID = x.ClientID,
                    UserID = x.UserID
                }).FirstOrDefault();
            }
        }
    }
}
