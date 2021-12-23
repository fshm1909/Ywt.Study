using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class Select
    {
        public Person First() {
            using (var context = new StudyDbContext())
            {
                return context.Person.FirstOrDefault();
            }
        }

        public Person sql()
        {
            using (var context = new StudyDbContext())
            {
                var x = from a in context.Person
                        select a;

                return x.FirstOrDefault();
            }
        }
    }
}
