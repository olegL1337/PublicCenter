using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models.ExtraModels
{
    public class ClientWeekSTypesModel
    {
        public Client Client { get; set; }
        public WeekModel Week { get; set; }
        public IEnumerable<ServiceType> Types { get; set; }
    }
}
