using CS_AppliedOOPsGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPsGenerics.Logic
{
    public abstract class EmployeeLogic
    {
        public abstract void AddEmployee(Employee employee);

        public abstract List<Employee> GetEmployee();

        public virtual decimal GetSalary(Employee employee)
        { 
            return employee.Salary;
        }
    }



}
