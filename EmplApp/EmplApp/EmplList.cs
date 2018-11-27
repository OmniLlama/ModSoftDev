using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplApp
{
    class EmplList
    {
        private static List<Employee> myEmployees = new List<Employee>();
        public static void AddEmployee(Employee emp)
        {
            myEmployees.Add(emp);
        }
        public static List<Employee> ShowEmployee()
        {
            return myEmployees;
        }
    }
}
