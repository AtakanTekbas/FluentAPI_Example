using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentExample.Models
{
    public class Medicine
    {
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public ICollection<Diagnostic> Diagnostics { get; set; }
    }
}
