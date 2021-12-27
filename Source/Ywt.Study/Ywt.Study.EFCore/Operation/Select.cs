using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class Select
    {
        public List<Person> GetList()
        {
            using (var context = new StudyDbContext())
            {
                return context.Person.ToList();
            }
        }

        public Person First() {
            using (var context = new StudyDbContext())
            {
                return context.Person.FirstOrDefault();
            }
        }
    }
}
