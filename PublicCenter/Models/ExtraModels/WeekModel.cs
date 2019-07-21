using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.Models.ExtraModels
{
    public class WeekModel
    {
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thirsday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }


        public WeekModel(List<Schedule> schedule)
        {
            if (schedule.Where(s => s.Day == "Monday").Any()) Monday = true;
            if (schedule.Where(s => s.Day == "Tuesday").Any()) Tuesday = true;
            if (schedule.Where(s => s.Day == "Wednesday").Any()) Wednesday = true;
            if (schedule.Where(s => s.Day == "Thirsday").Any()) Thirsday = true;
            if (schedule.Where(s => s.Day == "Friday").Any()) Friday = true;
            if (schedule.Where(s => s.Day == "Saturday").Any()) Saturday = true;
            if (schedule.Where(s => s.Day == "Sunday").Any()) Sunday = true;
        }

    }

}
