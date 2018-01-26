using System;
using System.Collections.Generic;
using Bangazon.Departments;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {

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
            
            
            Console.WriteLine("ToString() method on each list object:");
            foreach(Department d in departmentsList)
            {
                Console.WriteLine($"{d.ToString()}");
            }
        }
    }
}
