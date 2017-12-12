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
                        SSN = x.SSN,
                        DateADDED = x.DateADDED.ToString("MM/dd/yyyy"),
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
                        Tracks = x.Tracks,
                        Price = x.Price,
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
