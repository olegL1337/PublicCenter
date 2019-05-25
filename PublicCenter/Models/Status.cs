using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Status
    {
        [Key]
        public int ID {get; set;}
        public string Status_name { get; set; }
    }
}
