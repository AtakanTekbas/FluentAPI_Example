using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public int BranchID { get; set; }
        public Branch Branch { get; set; }
        public int AcademicRankID { get; set; }
        public AcademicRank AcademicRank { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
