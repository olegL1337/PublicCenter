using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public int? ManagerId { get; set; }
        public Worker Worker { get; set; }
    }
}
