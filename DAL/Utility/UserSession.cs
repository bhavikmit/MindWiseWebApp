using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.Utility
{
    public class UserSession
    {
        //Sessions
        public static long? UserID
        {
            get
            {
                if (HttpContext.Current.Session[Constants.UserID_Session] == null)
                {
                    return 0;
                }
                return Convert.ToInt64(HttpContext.Current.Session[Constants.UserID_Session]);
            }
            set { HttpContext.Current.Session[Constants.UserID_Session] = value; }
        }
        public static long? ClientID
        {
            get
            {
                if (HttpContext.Current.Session[Constants.ClientID_Session] == null)
                {
                    return 0;
                }
                return Convert.ToInt64(HttpContext.Current.Session[Constants.ClientID_Session]);
            }
            set { HttpContext.Current.Session[Constants.ClientID_Session] = value; }
        }
        public static string UserName
        {
            get
            {
                if (HttpContext.Current.Session[Constants.UserName_Session] == null)
                {
                    return "";
                }
                return Convert.ToString(HttpContext.Current.Session[Constants.UserName_Session]);
            }
            set { HttpContext.Current.Session[Constants.UserName_Session] = value; }
        }
        public static string Email
        {
            get
            {
                if (HttpContext.Current.Session[Constants.Email_Session] == null)
                {
                    return "";
                }
                return Convert.ToString(HttpContext.Current.Session[Constants.Email_Session]);
            }
            set { HttpContext.Current.Session[Constants.Email_Session] = value; }
        }

    }
}
