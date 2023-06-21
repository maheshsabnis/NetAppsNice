using CS_AppliedOOPsGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPsGenerics.Logic
{
    /// <summary>
    /// DirectLogic class is overriding abstrat methods of the EmployeeLogic abstract class 
    /// </summary>
    public class DirectorLogic : EmployeeLogic
    {
        int count = 0;
        // Store only Employee Object;s information wuill skip the Director Object Specific Data 
       List<Employee> employees;
        // Instead declare the Director Array

       List<Director> directors; 

        public DirectorLogic()
        {
            employees = new List<Employee>();   
            directors = new List<Director>();
        }

        public override void AddEmployee(Employee employee)
        {
           // employees[count] = employee;
           // Cast Employee to Director at Runtime so that the Director;s information
           // will persist and can be added into the Director Array 

            directors.Add( (Director)employee);
            
        }
        // Compiler and Runtime will return the Director Array As Employee  Array
        public override List<Employee> GetEmployee()
        {
            foreach (Director director in directors)
            {
                employees.Add(director);
            }

            return employees;
        }
        /// <summary>
        /// using the 'base' keyword the base class methods can be invoked
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public override decimal GetSalary(Employee employee)
        {
            var salary =  base.GetSalary(employee);
            Director director = (Director)employee;
            decimal netSalary = salary + director.AirFare + director.ElectricityBill + director.OtherAllowances;

            return netSalary;
        }
    }
}
