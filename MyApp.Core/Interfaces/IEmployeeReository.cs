using MyApp.Core.Entities;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeReository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id);
        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entiry);
        Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entiry);
        Task<bool> DeleteEmployeeAsync(Guid employeeId);
    }
}
