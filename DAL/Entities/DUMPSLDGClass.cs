using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DUMPSLDGClass
    {
        public string RecordID { get; set; }
        public string Base_ID { get; set; }
        public string Tracks { get; set; }
        public string STATE { get; set; }
        public string City { get; set; }
        public string Refundable { get; set; }
        public string Zip { get; set; }
        public string Price { get; set; }
        public Nullable<int> TotalRecords { get; set; }
    }
}
