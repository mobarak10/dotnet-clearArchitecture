using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Insfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Insfrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeReository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entiry)
        {
            entiry.Id = Guid.NewGuid();
            dbContext.Employees.Add(entiry);


            await dbContext.SaveChangesAsync();
            return entiry;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entiry)
        {
            
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

            if(employee is not null)
            {
                employee.Name = entiry.Name;
                employee.Email = entiry.Email;
                employee.Phone = entiry.Phone;

                await dbContext.SaveChangesAsync();

                return employee;
            }
            return entiry;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

            if (employee is not null)
            {
                dbContext.Employees.Remove(employee);

                return await dbContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}

