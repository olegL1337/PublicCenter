using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class ClientTypeOfService
    {
        public int? ClientID { get; set; }
        public Client Client { get; set; }
        public int? ServiceID { get; set; }
        public Service Service { get; set; }
    }
}
