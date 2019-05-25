using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Schedule
    {
        public int? ClientID { get; set; }
        public Client Client { get; set; }
        public string Day { get; set; }
    }
}
