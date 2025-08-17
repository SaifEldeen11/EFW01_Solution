namespace EFW01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region By Convention
            using ITIDbContext context = new ITIDbContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            #endregion

            // i will update Age in student
            // delete Name in Department
            // create a new CName in courses
            // Read a student that has name "Saif"
            var result = context.students.Where(s => s.FName == "Saif").ToList();
            Console.WriteLine(result);
        }
    }
}
