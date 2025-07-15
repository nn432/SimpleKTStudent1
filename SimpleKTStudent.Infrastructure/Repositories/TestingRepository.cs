using Microsoft.EntityFrameworkCore;
using SimpleKTStudent.Domain.Interfaces.Repositories;
using SimpleKTStudent.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleKTStudent.Infrastructure.Repositories
{
    public class TestingRepository : ITestingRepository
    {
        private readonly ApplicationDbContext _context;

        public TestingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Testing testing)
        {
            await _context.Testings.AddAsync(testing);
        }

        public async Task<IEnumerable<Testing>> GetAllAsync()
        {
            return await _context.Testings.ToListAsync();
        }

        public async Task<Testing?> GetByIdAsync(Guid id)
        {
            return await _context.Testings.FindAsync(id);
        }

        public async Task UpdateAsync(Testing testing)
        {
            _context.Testings.Update(testing);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Testings.FindAsync(id);
            if (entity != null)
                _context.Testings.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
