using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicProject.Models
{
    internal class Timetable
    {
        public string timetableId {  get; set; }
        public string date { get; set; }
        public string subjectid { get; set; } 
        public string roomtype { get; set; } 
        public string starttime { get; set; } 
        public string endtime { get; set; }
        public string timeslot { get; set; } 
    }
}
