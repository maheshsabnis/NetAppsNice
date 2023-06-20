using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPs.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class Director : Employee
    {
        public decimal AirFare { get; set; }
        public decimal OtherAllowances { get; set; }
        public decimal ElectricityBill { get; set; }
    }

    public class Manager : Employee
    {
        public decimal PhoneBill { get; set; }
        public decimal PetrolAlloances { get; set; }
    }
}
