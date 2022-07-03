using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }


        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                percentage /= 2;
            }
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {Salary:f2} leva.";
        }
    }
}
