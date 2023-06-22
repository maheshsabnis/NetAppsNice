using CS_ADOConnected.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADOConnected.DataAccess
{
    internal class EmployeeDataAccess : IDataAccess<Employee, int>
    {
        Task<Employee> IDataAccess<Employee, int>.CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataAccess<Employee, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Employee>> IDataAccess<Employee, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<Employee> IDataAccess<Employee, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IDataAccess<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
