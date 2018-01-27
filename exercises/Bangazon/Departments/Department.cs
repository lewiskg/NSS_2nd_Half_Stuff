﻿using System;
using System.Collections.Generic;

namespace Bangazon.Departments
{
    // Parent class for all departments
    public class Department
    {
        // Fields
        private string _dept_name;
        private string _supervisor;
        private int _employee_count;
        private string _company;
        private double _budget;

        // Properties
        public string Name { get => _dept_name; set => _dept_name = value; }
        public string Supervisor { get => _supervisor; set => _supervisor = value; }
        public int Employee_count { get => _employee_count; set => _employee_count = value; }
        public string Company { get => _company; set => _company = value; }
        public double Budget { get => _budget; set => _budget = value; }

        // Constructor methods
        public Department() => Console.WriteLine("Department default class constructor called. - 1");
        public Department(string name, string supervisor, int employees, string company)
        {
            Name = name;
            Supervisor = supervisor;
            Employee_count = employees;
            Company = company;
        }

        // Other Methods
        public void printDetails() 
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine(String.Format("{0,-18} | {1,15}", "Company:", this.Company));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(String.Format("{0,-18} | {1,15}", "Dept type:", this.GetType().Name));
            Console.WriteLine(String.Format("{0,-18} | {1,15}", "Dept name:", this.Name));
            Console.WriteLine(String.Format("{0,-18} | {1,15}", "Dept supervisor:", this.Supervisor));
            Console.WriteLine(String.Format("{0,-18} | {1,15}", "Num Employees:", this.Employee_count));
            Console.WriteLine("------------------------------------\n");
        }

        public virtual void SetBudget(double budget)
        {
            Budget = budget;
            Console.WriteLine($"The budget for the {this.GetType().Name} department is {this.Budget:C}");
        }
    }
}
