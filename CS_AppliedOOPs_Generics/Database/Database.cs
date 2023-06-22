using CS_AppliedOOPsGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppliedOOPsGenerics.Database
{
    internal static class Database
    {
        // The String aka Key is DeptName
        public static Dictionary<string, List<Employee>> EmployeesDb = new Dictionary<string, List<Employee>>();



        private static void doSomething()
        {
            var res = from record in EmployeesDb.Values
                      where record.GetType() == typeof(Manager)
                      select record.Sum(e => e.Salary);
        }
    }
}
