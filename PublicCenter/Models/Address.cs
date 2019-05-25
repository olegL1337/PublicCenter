using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Addr { get; set; }
    }
}
