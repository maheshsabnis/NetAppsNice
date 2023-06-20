using CS_AppliedOOPs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPs.Logic
{
    public class ManagerLogic : EmployeeLogic
    {
        int count = 0;
        Employee[] employees;
        Manager[] managers; 
        public ManagerLogic()
        {
            employees = new Employee[2];
            managers = new Manager[2];
        }

        public override void AddEmployee(Employee employee)
        {
            //employees[count] = employee;
            managers[count] = (Manager)employee;    
            count++;
        }

        public override Employee[] GetEmployee()
        {
            return managers;
        }

        public override decimal GetSalary(Employee employee)
        {
            var salary = base.GetSalary(employee);
            Manager mgr = (Manager)employee;
            decimal netSalary = salary +mgr.PhoneBill + mgr.PetrolAlloances;

            return netSalary;
        }
    }
}
