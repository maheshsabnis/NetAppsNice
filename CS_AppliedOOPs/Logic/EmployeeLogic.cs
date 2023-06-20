using CS_AppliedOOPs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPs.Logic
{
    public abstract class EmployeeLogic
    {
        public abstract void AddEmployee(Employee employee);

        public abstract Employee [] GetEmployee();

        public virtual decimal GetSalary(Employee employee)
        { 
            return employee.Salary;
        }
    }



}
