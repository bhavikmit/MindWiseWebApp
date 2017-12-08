using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class CVVLDGClass
    {
        public string UserName { get; set; }
        public string Bin { get; set; }
        public string Bank { get; set; }
        public string CardClass { get; set; }
        public string STATE { get; set; }
        public string City { get; set; }
        public int? TotalRecords { get; set; }
    }
}
