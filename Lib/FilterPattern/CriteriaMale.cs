using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib.FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public IEnumerable<Person> MeetCriteria(IEnumerable<Person> persons)
        {
            return persons.Where(x => x.Gender == "Male");
        }
    }
}
