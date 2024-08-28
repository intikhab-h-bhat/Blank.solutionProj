using Blank.solutionProj.DataBase;

namespace Blank.solutionProj.Bl
{
    public class Class1
    {
        public int Add(int a, int b)
        {
            // creating instance
            AppDbContext dbContext = new AppDbContext();
            // calling add finction of Dbcontext
            return dbContext.Add(a, b);
        }
    }
}
