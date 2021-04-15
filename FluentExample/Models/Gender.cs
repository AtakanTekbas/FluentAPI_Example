using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class Gender
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
