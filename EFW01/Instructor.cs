using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW01
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Adress { get; set; }
        public int? Bonus { get; set; }
        public int Salary { get; set; }
        public int HourRate { get; set; }
    }
}
