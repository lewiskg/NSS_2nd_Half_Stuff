using System;
using System.Collections.Generic;

namespace Bangazon.Departments
{
    public class Accounting : Department
    {
        private Dictionary<string, double> _budget = new Dictionary<string, double>();

        // Constructor
        public Accounting(string name, string supervisor, int employees, string company) : base(name, supervisor, employees, company)
        {
            this.Name = name;
            this.Supervisor = supervisor;
            this.Employee_count = employees;
            this.Company = company;
        }

        // Methods
        public void AddBudget(string employee_name, double dollars) => _budget.Add(employee_name, dollars);
        public void printBudgetStats()
        {
            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.WriteLine(String.Format("         {0} department for company {1}", this.GetType().Name, this.Company));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("         Employee      |  Budget $ Responsible For  ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (KeyValuePair<string, double> s in _budget)
            {
                Console.WriteLine($"{s.Key,-20} \t {s.Value,20:C}");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }


        // Overriding the default toString() method for each object instance
        public override string ToString() => $"{this.Name} {this.Supervisor}  {this.Employee_count} {this.Company}";
    }
}