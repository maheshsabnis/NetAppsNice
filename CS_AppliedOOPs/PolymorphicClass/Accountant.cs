using CS_AppliedOOPs.Logic;
using CS_AppliedOOPs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPs.PolymorphicClass
{
    public sealed class Accountant
    {
        /// <summary>
        /// The method will have polymorphic behavior based on
        /// type of Employee and EmployeeLogic instances at runtime
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="employeeLogic"></param>
        /// <returns></returns>
        public decimal GetTax(Employee employee, EmployeeLogic employeeLogic)
        {
            decimal netSalary = employeeLogic.GetSalary(employee);
            decimal tax = netSalary * Convert.ToDecimal(0.4);
            return tax;

        }
    }
}
