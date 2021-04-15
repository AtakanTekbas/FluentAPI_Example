using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class Diagnostic
    {
        public int DiagnosticID { get; set; }
        public string DiagnosticName { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
