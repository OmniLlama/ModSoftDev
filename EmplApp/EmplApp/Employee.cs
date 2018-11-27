using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplApp
{
    class Employee
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        private decimal salary;

        public decimal Salary_Value
        {
            get { return salary; }
            set
            {
                if(value >= 0.0m)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("invalid salary amount");
                }
            }
        }
        public Employee(string first, string last, decimal salary)
        {
            firstName = first;
            lastName = last;
            Salary_Value = salary;
        }
        public override string ToString()
        {
            return string.Format("First Name : {0}\n "
                + "Last Name: {1}\n Salary: {2:C}",
                firstName, lastName, Salary_Value);
        }
    }
}
