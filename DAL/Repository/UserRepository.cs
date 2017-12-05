using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public static class UserRepository
    {
        public static bool ValidUser(string userName,string password)
        {
            using (MindWiseEntities db = new MindWiseEntities())
            {
                return false;
            }
        }
    }
}
