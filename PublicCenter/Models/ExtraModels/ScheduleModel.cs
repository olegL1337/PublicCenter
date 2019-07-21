using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models.ExtraModels
{
    public class ScheduleModel
    {
        public int id { get; set; }
        public Client client { get; set; }
        public ServiceType serviceType { get; set; }
        public Service service { get; set; }
        public Address address { get; set; }
    }
}
