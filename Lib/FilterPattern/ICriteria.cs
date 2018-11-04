using System;
using System.Collections.Generic;

namespace Lib.FilterPattern
{
    public interface ICriteria
    {
        IEnumerable<Person> MeetCriteria(IEnumerable<Person> persons);
    }
}
