using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW01
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public int Name { get; set; }
        public string CName { get; set; }
        public string? Description { get; set; }
    }
}
