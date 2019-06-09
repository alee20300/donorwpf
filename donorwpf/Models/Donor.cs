using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donorwpf.Models
{
    public class Donor
    {
        public string  DneNo { get; set; }
        public string  Namw { get; set; }
        public string  Address { get; set; }
        public string Island { get; set; }
        public DateTime Date { get; set; }
        public int BldGrpId { get; set; }
        public string Gender { get; set; }

        public  IEnumerable<Donor>Donors{ get; set; }



    }
}
