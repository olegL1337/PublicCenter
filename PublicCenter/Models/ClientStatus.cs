using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class ClientStatus
    {
        public int? ClientID { get; set; }
        public Client Client { get; set; }
        public int? StatusId { get; set; }
        public Status Status { get; set; }
    }
}
