using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Worker
    {
        [Key]
        public int ID { get; set; }
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Father_name { get; set; }
        public int? AddressID { get; set; }
        public Address Address { get; set; }
        public string Phone_stat { get; set; }
        public string Mobile_phone { get; set; }
        public string Passport { get; set; }
        public string Identify_number { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_birth { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public string Role { get; set; }
    }
}
