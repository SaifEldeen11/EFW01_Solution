using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW01
{
    internal class Course_Inst
    {
        [Key]
        public int FakeId { get; set; } // to get rid of the exeption as u want us to not make relationships
        public string Evaluate { get; set; }
    }
}
