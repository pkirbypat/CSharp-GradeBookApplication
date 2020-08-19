using System;
using System.Linq;
using GradeBook.GradeBooks;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.Enums
{
    public enum GradeBookType
    {
        Standard,
        Ranked,
        ESNU,
        OneToFour,
        SixPoint
    }
}