using System;
using System.Collections.Generic;

#nullable disable

namespace Ywt.Study.EFCore.Scaffold.Model
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool IsDeleted { get; set; }
        public int State { get; set; }
    }
}
