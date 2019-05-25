using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models
{
    public class DoneWork
    {
        public long ID { get; set; }
        public int? WorkerID { get; set; }
        public Worker Worker { get; set; }
        public int? ClientID { get; set; }
        public Client Client { get; set; }
        public int? ServiceID { get; set; }
        public Service Service { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_of_service { get; set; }
    }
}
