using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Service
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ServiceTypeID { get; set; }
        public ServiceType ServiceType { get; set; }
        public string GroupOfMotorActivity { get; set; }
        public double? Price { get; set; }
    }
}
