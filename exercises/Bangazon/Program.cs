using System;
using System.Collections.Generic;
using Bangazon.Departments;
using Bangazon.Employees;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            const double baseBudget = 75000.00;

            // Create some instances
            HumanResources hr01 = new HumanResources("HR 1", "Toby Flenderson", 2, "Dunder Mifflin");
            HumanResources hr02 = new HumanResources("HR 2", "Jack Frost", 13, "South Pole");
            Accounting ac01 = new Accounting("Accounting", "Angela Martin", 10, "Dunder Mifflin");
            Sales sa01 = new Sales("Sales 1", "Michael Scott", 50, "Dunder Mifflin");
            
            hr01.printDetails();
            hr02.printDetails();
            ac01.printDetails();
            sa01.printDetails();
            

            hr01.AddPolicy("Terminating Employees", "How to give people the shaft.");
            hr01.AddPolicy("Selling Out People", "How to screw people over.");
            hr01.AddPolicy("Bankrupting the System", "How to steal like a politician.");
            hr01.printPolicies();

            sa01.AddSale("Dwight Schrute", 58975);
            sa01.AddSale("Phyllis Lapin", 48502);
            sa01.AddSale("Stanley Hudson", 1254871);
            sa01.printSalesStats();

            ac01.AddBudget("Kevin Malone", -13);
            ac01.AddBudget("Oscar Gutierrez", 4858502);
            ac01.AddBudget("Angela Martin", 101254871);
            ac01.printBudgetStats();

            
            // Add derived departments to the list
            List<Department> departmentsList = new List<Department>();
            departmentsList.Add(hr01);
            departmentsList.Add(hr02);
            departmentsList.Add(ac01);
            departmentsList.Add(sa01);
            
            foreach(Department d in departmentsList)
            {
                d.SetBudget(baseBudget);
            }

            Console.WriteLine("\nToString() method on each list object:");
            foreach (Department d in departmentsList)
            {
                Console.WriteLine($"{d.ToString()}");
            }

            // Employee E01 = new Employee("Ken", "Lewis");
            // Console.WriteLine("\n");
            // E01.printEmployee();
            // Console.WriteLine("\n");

            // Console.WriteLine("\n------------------------------------");
            // Console.WriteLine("\n------------------------------------");

            // HumanResourcesEmployee E02 = new HumanResourcesEmployee("Ted", "Nugent", "fT", 24.50);

            // E02.printEmployee();   
            // Console.WriteLine("\n");
            // HumanResourcesEmployee E03 = new HumanResourcesEmployee();
            // E03.printEmployee(); 
            
            // Console.WriteLine("\n------------------------------------");
            // Console.WriteLine("\n------------------------------------");

            // SalesEmployee E04 = new SalesEmployee("Teddy", "Nugenty", "pt", 24.50);
            // E04.printEmployee();   
            // Console.WriteLine("\n");
            // SalesEmployee E05 = new SalesEmployee();
            // E05.printEmployee();  

            // Console.WriteLine("\n------------------------------------");
            // Console.WriteLine("\n------------------------------------");

            // AccountingEmployee E06 = new AccountingEmployee("Teddyyy", "Nugent", "FT", 2400.50);
            // E06.printEmployee();   
            // Console.WriteLine("\n");
            // AccountingEmployee E07 = new AccountingEmployee();
            // E07.printEmployee();

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("------------------------------------");

            Employee hre01 = new Employee("Ted", "Nugent");
            Employee hre02 = new Employee("Eddy", "Van Halen");
            Employee hre03 = new Employee("Alice", "Cooper");

            Employee sae01 = new Employee("Johnny", "Appleseed");
            Employee sae02 = new Employee("Jack", "Ripper");
            Employee sae03 = new Employee("George", "Washington");

            Employee ace01 = new Employee("Theodore", "huxtable");
            Employee ace02 = new Employee("Peter", "Griffin");
            Employee ace03 = new Employee("Glen", "Quigmire");

            hr01.AddEmployee(hre01);
            hr01.AddEmployee(hre02);
            hr01.AddEmployee(hre03);
            
            sa01.AddEmployee(sae01);
            sa01.AddEmployee(sae02);
            sa01.AddEmployee(sae03);
            
            ac01.AddEmployee(ace01);
            ac01.AddEmployee(ace02);
            ac01.AddEmployee(ace03);
            

            hr01.printEmployeeList();
            sa01.printEmployeeList();
            ac01.printEmployeeList();

        }
    }
}
