using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
