using EmployeeMgtSystem.Data;
using EmployeeMgtSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgtSystem.Repositories
{
    public class EmployeeRepository : IGenericRepository<tbl_Employee>
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<tbl_Employee>> GetAllAsync(int page, int pageSize)
        {
            return await context.tbl_Employee.OrderByDescending(d => d.Id).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<int> GetAllCountAsync()
        {
            return await context.tbl_Employee.CountAsync();
        }

        public async Task<tbl_Employee> GetByIdAsync(int id)
        {
            return await context.tbl_Employee.FindAsync(id);
        }

        public async Task AddAsync(tbl_Employee entity)
        {
            context.tbl_Employee.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var emp = await context.tbl_Employee.FindAsync(id);
            if (emp != null)
            {
                context.tbl_Employee.Remove(emp);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(tbl_Employee entity)
        {
            context.tbl_Employee.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
