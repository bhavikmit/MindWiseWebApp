using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class CVVLDGClass
    {
        public string RecordID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string STATE { get; set; }
        public string City { get; set; }
        public int? TotalRecords { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Zip { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
    }
}
