using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.Utility
{
    public class AppSetting
    {
        public static decimal? Version
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings[Constants.AppConfig_Version]);
            }
        }
        public static string AppUrl
        {
            get
            {
                return Convert.ToString(ConfigurationManager.AppSettings[Constants.AppConfig_AppUrl]);
            }
        }
        public static string RecordPerPage
        {
            get
            {
                return Convert.ToString(ConfigurationManager.AppSettings[Constants.AppConfig_RecordPerPage]);
            }
        }
    }
}
