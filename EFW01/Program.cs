// This code was made by Eng Saif :)
namespace EFW01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region By Convention anf API
            //using (ITIDbContext Context = new ITIDbContext())
            //{
            //    // Some Code
            //}

            using ITIDbContext context = new ITIDbContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            #endregion

            #region CRUD
            // i will update Age in student
            // delete Name in Department
            // create a new CName in courses
            // Read a student that has name "Saif"


            //var result = context.students.Where(s => s.FName == "Saif").ToList();
            //foreach (var resultItem in result)
            //{
            //    Console.WriteLine(resultItem);
            //} 
            #endregion
        }
    }
}
