using CS_AppliedOOPsGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPsGenerics.Logic
{
    public class ManagerLogic : EmployeeLogic
    {
        int count = 0;
       List<Employee> employees;
        List<Manager> managers; 
        public ManagerLogic()
        {
            employees = new  List<Employee>();
            managers = new List<Manager>()    ;
        }

        public override void AddEmployee(Employee employee)
        {
            //employees[count] = employee;
            managers[count] = (Manager)employee;    
            count++;
        }

        public override List<Employee> GetEmployee()
        {
            foreach (Manager manager in managers)
            {
                employees.Add(manager);
            }
            return employees;
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
