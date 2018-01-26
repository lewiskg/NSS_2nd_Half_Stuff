﻿using System;
using System.Collections.Generic;

namespace Bangazon.Departments
{
    public class HumanResources : Department
    {
        // Field
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        // Constructor
        public HumanResources(string name, string supervisor, int employees, string company) : base(name, supervisor, employees, company)
        {
            this.Name = name;
            this.Supervisor = supervisor;
            this.Employee_count = employees;
            this.Company = company;
        }

        // Methods
        public void AddPolicy(string title, string text) => _policies.Add(title, text);
        public void printPolicies()
        {
            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.WriteLine(String.Format("         {0} policies for company {1}", this.GetType().Name, this.Company));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("         Policy Title      |  Policy Description  ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Key,-30} \t {policy.Value,31}");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }


        // Overriding the default toString() method for each object instance
        public override string ToString() => $"{this.Name} {this.Supervisor}  {this.Employee_count} {this.Company}";
    }
}