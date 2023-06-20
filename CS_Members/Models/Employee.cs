using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Members.Models
{
    /// <summary>
    /// Dara Class aka Data Transmission Object (DTO) aka Value Object (VO)
    /// </summary>
    internal class Employee
    {
        private int _EmpNo;

        public int EmpNo 
        {
            // return
            get { return _EmpNo; }
            // accept
            set 
            {   if(_EmpNo <=0)
                    _EmpNo = 0;
                _EmpNo = value; 
            }
        }

         


        private string? _EmpName;

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        //public Employee(int eno, string ename)
        //{
        //    _EmpNo = eno;
        //    _EmpName = ename;
        //}

       
    }

    /// <summary>
    /// Class with Auto0-Implemented Porperties
    /// </summary>
    internal class EmployeeDTO
    { 
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
    }


    internal class EmployeeLogic
    {
        EmployeeDTO[] employees;

        int counter = 0;

        public EmployeeLogic()
        {
            employees = new EmployeeDTO[5]; 
        }

        public void AddEmployee(EmployeeDTO employee)
        { 
            employees[counter] = employee;
            counter++;
        }

        public EmployeeDTO[] GetEmployees()
        {
            return employees;
        }


    }
}
