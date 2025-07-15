using SimpleKTStudent.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleKTStudent.Domain.Interfaces.Repositories
{
    public interface ITestingRepository
    {
        Task<Testing?> GetByIdAsync(Guid id);
        Task<IEnumerable<Testing>> GetAllAsync();
        Task AddAsync(Testing testing);
        Task UpdateAsync(Testing testing);
        Task DeleteAsync(Guid id);
        Task SaveChangesAsync();
    }
}
