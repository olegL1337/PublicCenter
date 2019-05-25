using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Father_name { get; set; }
        //ForeignKey
        public int? Formal_addressId { get; set; }
        public Address Formal_address { get; set; }
        //ForeignKey
        public int? Real_addressId { get; set; }
        public Address Real_address { get; set; }
        public string Phone_stat { get; set; }
        public string Mobile_phone { get; set; }
        public string Personal_file_number { get; set; }
        //?????
        [DataType(DataType.Date)]
        public DateTime Date_birth { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public string Passport { get; set; }
        public string Identify_number { get; set; }
        public string Group { get; set; }
        //????
        public string Period { get; set; }
        public string Degree_Indiv_Need { get; set; }
        public string Group_Motor_Activity { get; set; }
        public string Ability_Self_Service { get; set; }
        public string Condition_Giving_Service { get; set; }
        public string Number_Of_Visit { get; set; }

        public int? WorkerID { get; set; }
        public Worker Worker { get; set; }
        public string Organization_Service_House { get; set; }
        public bool Is_active { get; set; }
    }
}
