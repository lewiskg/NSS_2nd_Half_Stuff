using System;

namespace Architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResources("Human Resources",);
        }
    }

    // Parent class for all departments
    public class Department
    {
        private string _name;
        private string _supervisor;
        private int _employee_count;

        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }
    }

    public class HumanResources: Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        // Constructor method
        public HumanResources(string dept_name, string supervisor, int employees): base(dept_name, supervisor, employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }

        // Publicly accessible method to add an HR policy
        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach(KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }
        }

        // Overriding the default toString() method for each object instance
        public string toString() 
        {
            return $"{_name} {_supervisor} {_employee_count}";
        }
    }

   


}
