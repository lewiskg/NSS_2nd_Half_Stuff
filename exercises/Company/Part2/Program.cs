using System;
using System.Collections.Generic;

namespace Dork
{
    class Program
    {
        static void Main(string[] args)
        {
            Company seven11 = new Company("seven11", "3/9/2008");

            Employee BOB = new Employee("Manager","Bob","Smith", "3/9/2008" );
   			Employee TED = new Employee("Clerk","Ted","Anderson", "3/9/2008" );
			Employee JON = new Employee("Janitor","Jon","Lee", "3/9/2008" );

            seven11.addEmployee(BOB);
            seven11.addEmployee(TED);
            seven11.addEmployee(JON);

            seven11.printEmployees();
            
            seven11.removeEmployee(BOB);

            seven11.printEmployees();

        }
    }

    public class Company
    {
        public string Name { get; }
        public string CreatedOn { get; }
        
        public List<Employee> employeeList = new List<Employee>();

        public void addEmployee(Employee worker)
        {
            employeeList.Add(worker);
            Console.WriteLine("Added employee {0}", worker.firstName);
        }

        public void removeEmployee(Employee worker)
        {
            employeeList.Remove(worker);
            Console.WriteLine("Removed employee {0}", worker.firstName);
        }

        public Company(string companyName, string dateCreated)
        {
            Name = companyName;
            CreatedOn = dateCreated;
        }

        public void printEmployees()
        {
            Console.WriteLine("\n");
            foreach (var person in employeeList)
            {
                Console.WriteLine("Job title: {0}, Name: {1}, Start date: {2}", person.jobTitle, person.firstName, person.startDate);
            }
        }

    }

    public class Employee
    {
        public string jobTitle { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string startDate {get; set; }

        public Employee(string job_title, string first_name, string last_name, string start_date)
        {
            jobTitle = job_title;
            firstName = first_name;
            lastName = last_name;
            startDate = start_date;
        }
    }
}
