using Blank.solutionProj.DataBase;

namespace Blank.solutionProj.Bl
{
    public class Class1
    {
        public int Add(int a, int b)
        {
            // creating instance
            DbContext dbContext = new DbContext();
            return dbContext.Add(a, b);
        }
    }
}
