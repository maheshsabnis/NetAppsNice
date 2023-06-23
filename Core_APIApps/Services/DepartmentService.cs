using Core_APIApps.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_APIApps.Services
{
    public class DepartmentService : IService<Department, int>
    {
        CompanyContext ctx;

        ResponseObject<Department> response;
        /// <summary>
        /// Inject the CompanyContext as Constructor Injection in Service 
        /// </summary>
        public DepartmentService(CompanyContext ctx)
        {
            this.ctx = ctx;
            response = new ResponseObject<Department>();
        }


        async Task<ResponseObject<Department>> IService<Department, int>.CreateAsync(Department entity)
        {
            var result = await ctx.Departments.AddAsync(entity);
            await ctx.SaveChangesAsync(); 
            response.Record =  result.Entity; // Newly created record
            response.StatusMessage = "Data Read Successfuly";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Department>> IService<Department, int>.DeleteAsync(int id)
        {
            var recordToDelete = await ctx.Departments.FindAsync(id);
            if (recordToDelete == null)
            {
                response.StatusMessage = "Recotrd not found base on DeptNo = {id}";
                response.StatusCode = 404;
            }
            else
            { 
                ctx.Departments.Remove(recordToDelete);
                await ctx.SaveChangesAsync();
                response.StatusMessage = "Delete Successfuly";
                response.StatusCode = 200;
            }
            return response;
        }

        async Task<ResponseObject<Department>> IService<Department, int>.GetAsync()
        {
            response.Records =  await ctx.Departments.ToListAsync();
            response.StatusMessage = "Data Read Successfuly";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Department>> IService<Department, int>.GetAsync(int id)
        {
            response.Record = await ctx.Departments.FindAsync(id);
            response.StatusMessage = "Data Read Successfuly";
            response.StatusCode = 200;
            return response;
        }

        async Task<ResponseObject<Department>> IService<Department, int>.UpdateAsync(int id, Department entity)
        {
           var recordToUpdate = await ctx.Departments.FindAsync(id);
            if (recordToUpdate == null)
            {
                response.StatusMessage = "Recotrd not found base on DeptNo = {id}";
                response.StatusCode = 404;
            }
            else
            {
                recordToUpdate.DeptName = entity.DeptName;
                recordToUpdate.Capacity = entity.Capacity;
                recordToUpdate.Location = entity.Location;
                await ctx.SaveChangesAsync();
                response.Record = recordToUpdate;
                response.StatusMessage = "Update is successful";
                response.StatusCode = 200;
            }
            return response;
        }
    }
}
