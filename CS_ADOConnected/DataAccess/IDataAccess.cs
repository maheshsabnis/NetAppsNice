using CS_ADOConnected.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADOConnected.DataAccess
{
    /// <summary>
    /// Multi-Type Generic Interface
    /// TEntity: The Name of Entity Class, Department, Employee
    /// TPk: specified as 'in', means this will always be an input paranmeter to the method declared in interface
    /// where TENtity: EntityBase, means a constraints for TEntity type as any derived type of EntityBase
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    internal interface IDataAccess<TEntity, in TPk> where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(TPk id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TPk id, TEntity entity);
        Task<bool> DeleteAsync(TPk id);
    }
}
