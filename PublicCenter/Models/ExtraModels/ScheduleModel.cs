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
        public Service service { get; set; }

    }
}
