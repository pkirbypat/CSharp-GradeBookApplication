using GradeBook.Enums;
  
namespace GradeBook.GradeBooks
{
    public class RandkedGradeBook : BaseGradeBook
    {
        public RandkedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}