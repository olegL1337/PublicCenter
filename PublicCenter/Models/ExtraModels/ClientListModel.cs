using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models.ExtraModels
{
    public class ClientListModel
    {
        public Client Сlient { get; set; }
        public Address RealAddress { get; set; }
        public Address FormalAddress { get; set; }
        public Department Department { get; set; }
        public Worker Worker { get; set; }
    }
}
