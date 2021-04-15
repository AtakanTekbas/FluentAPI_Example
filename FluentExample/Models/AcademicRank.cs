using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class AcademicRank
    {
        public int AcademicRankID { get; set; }
        public string AcademicRankName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
