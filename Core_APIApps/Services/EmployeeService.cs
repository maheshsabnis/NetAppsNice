using Core_APIApps.Models;

namespace Core_APIApps.Services
{
    public class EmployeeService : IService<Employee, int>
    {
        Task<ResponseObject<Employee>> IService<Employee, int>.CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IService<Employee, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IService<Employee, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IService<Employee, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Employee>> IService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
