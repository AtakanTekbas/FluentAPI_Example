using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public int PatientAge { get; set; }
        public int GenderID { get; set; }
        public Gender Gender { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<Diagnostic> Diagnostics { get; set; }


    }
}
