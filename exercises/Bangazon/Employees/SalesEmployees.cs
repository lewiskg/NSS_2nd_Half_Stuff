using System;
using System.Collections.Generic;

namespace Bangazon.Employees
{
    public class SalesEmployee: Employee, IFullTime, IPartTime
    {
        // Field
        private double _salary;
        private double _hourlyRate;

        // Property
        public double Salary { get => _salary; set => _salary = value; }
        
        public double HourlyRate { get => _hourlyRate; set => _hourlyRate = value; }

        // Constructor
        public SalesEmployee() : base()
        {
            Console.WriteLine("Enter Sales employee's first name: "); 
            	this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Sales last name: ");
            	this.LastName = Console.ReadLine();
            Console.WriteLine("Enter 'FT' for full-time or 'PT' for part-time employtee: ");
            	string workStatus = Console.ReadLine();
            if (workStatus.ToUpper() == "FT")
            {
                Console.WriteLine("Enter yearly salary (for FT employees): ");
            	    this.Salary = (double) float.Parse(Console.ReadLine());
			    Console.WriteLine("{0}, {1}, {2}, {3:C}",this.FirstName,this.LastName,workStatus,this.Salary);
            } else {
                Console.WriteLine("For PT employees, pay rate must be between $10/hr & $35/hr");
                Console.WriteLine("Enter hourly pay rate ($/hr) (for PT employees): ");
            	    this.HourlyRate = (double) float.Parse(Console.ReadLine());
			    Console.WriteLine("Sales employee: {0}, {1}, {2}, {3:C}",this.FirstName,this.LastName,workStatus,this.HourlyRate);
            }
        }

        public SalesEmployee(string firstName, string lastName, string jobStatus, double pay) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            if (Convert.ToBoolean(String.Compare(jobStatus, "FT", true)))
            {
                this.Salary = pay;
            } else 
            {
                this.HourlyRate = pay;
            }
        }

        public override void printEmployee()
        {
            if (Salary != 0) 
            {
                Console.WriteLine($"Sales employee name: {this.FirstName} {this.LastName} | Yearly salary: {(this.Salary):C}");
            } else 
            {
                Console.WriteLine($"Sales employee name: {this.FirstName} {this.LastName} | Hourly rate: {(this.HourlyRate):C}");
            }
        }

    }
}