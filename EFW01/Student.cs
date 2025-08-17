using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW01
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Address { get; set; }
        public int St_Age { get; set; }
        public override string ToString()
        {
            return $"Id {Id} , FName {FName} ,Address{Address},St_Age {St_Age} ";
        }
    }
}
