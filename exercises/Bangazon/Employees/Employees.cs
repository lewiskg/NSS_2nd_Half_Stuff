using System;
using System.Collections.Generic;

namespace Bangazon.Employees
{
    // Parent class for all employees
    public class Employee
    {
        // Fields
        private string _firstName;
        private string _lastName;

        // Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        // Constructor
        public Employee() {}
        public Employee(string firstName, string lastName)
        {  
            FirstName = firstName;
            LastName = lastName;
         }

        // Method
        public virtual void printEmployee()
        {
            Console.WriteLine($"Employee name: {this.FirstName} {this.LastName}");
        }

    }

}
