using System;
using System.Collections.Generic;

namespace Bangazon.Employees
{
    public class HumanResourcesEmployee: Employee, IFullTime, IPartTime
    {
        // Field
        private double _salary;
        private double _hourlyRate;


        // Property
        public double Salary { get => _salary; set => _salary = value; }
        
        public double HourlyRate
        {
            get { return _hourlyRate; }
            set 
            {
                // HR pays people between $10/hr and $35/hr
                if (value >= 10 && value <= 35)
                {
                    _hourlyRate = value;
                } else {
                    // If the value is not in the required range, throw
                    // and exception that the external code and catch
                    throw new ArgumentOutOfRangeException("Cannot set salary to value specified");
                }
            }
        }

        // Constructor
        public HumanResourcesEmployee() : base()
        {
            Console.WriteLine("Enter HR employee's first name: "); 
            	this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter HR last name: ");
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
			    Console.WriteLine("{0}, {1}, {2}, {3:C}",this.FirstName,this.LastName,workStatus,this.HourlyRate);
            }
        }

        public HumanResourcesEmployee(string firstName, string lastName, string jobStatus, double pay) : base(firstName, lastName)
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
                Console.WriteLine($"HR employee name: {this.FirstName} {this.LastName} | Yearly salary: {(this.Salary):C}");
            } else 
            {
                Console.WriteLine($"HR employee name: {this.FirstName} {this.LastName} | Hourly rate: {(this.HourlyRate):C}");
            }
        }

        public void printDeptEmployeeList()
        {
            Console.WriteLine("Department:  Human Resources");
            printDeptEmployeeList();
        }

    }
}