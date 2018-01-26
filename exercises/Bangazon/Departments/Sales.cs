using System;
using System.Collections.Generic;

namespace Bangazon.Departments
{
    public class Sales : Department
    {
        private Dictionary<string, double> _salesStats = new Dictionary<string, double>();

        // Constructor
        public Sales(string name, string supervisor, int employees, string company) : base(name, supervisor, employees, company)
        {
            this.Name = name;
            this.Supervisor = supervisor;
            this.Employee_count = employees;
            this.Company = company;
        }

        // Methods
        public void AddSale(string employee_name, double dollars) => _salesStats.Add(employee_name, dollars);
        public void printSalesStats()
        {
            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.WriteLine(String.Format("         {0} department for company {1}", this.GetType().Name, this.Company));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("         Employee      |  Sales Transaction Totals  ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (KeyValuePair<string, double> s in _salesStats)
            {
                Console.WriteLine($"{s.Key,-20} \t {s.Value,20:C}");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }

        // Overriding the default toString() method for each object instance
        public override string ToString() => $"{this.Name} {this.Supervisor}  {this.Employee_count} {this.Company}";
    }
}