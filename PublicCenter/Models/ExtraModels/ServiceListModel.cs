using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models.ExtraModels
{
    public class ServiceListModel
    {
        public IEnumerable<Service> services { get; set; }
        public IEnumerable<ServiceType> servicesTypes { get; set; }
    }
}
