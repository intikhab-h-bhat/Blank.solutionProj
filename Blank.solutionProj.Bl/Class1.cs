using Blank.solutionProj.DataBase;

namespace Blank.solutionProj.Bl
{
    public class Class1
    {
        public int Add(int a, int b)
        {
            DbContext dbContext = new DbContext();
            return dbContext.Add(a, b);
        }
    }
}
