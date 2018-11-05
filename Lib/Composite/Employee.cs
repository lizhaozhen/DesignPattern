using System;
using System.Collections.Generic;

namespace Lib.Composite
{
    public class Employee
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
