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
    }
}
