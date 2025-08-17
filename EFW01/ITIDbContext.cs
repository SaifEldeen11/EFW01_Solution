using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW01
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= EFITI; Trusted_Connection = true; TrustServerCertificate=true");
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet <Instructor> instructors { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet <Course_Inst> course_Insts { get; set; }
    }
}
