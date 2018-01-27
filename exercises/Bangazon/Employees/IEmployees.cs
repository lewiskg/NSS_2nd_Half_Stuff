using System;
using System.Collections.Generic;

namespace Bangazon.Employees
{
    // Describes full-time employees
    public interface IFullTime
    {
        double Salary { get; set; }
    }

    // Describes part-time employees
    public interface IPartTime
    {
        double HourlyRate { get; set; }
    }
}