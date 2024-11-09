using EmployeeAPI.Models.DTOs;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto?> GetByIdAsync(int id);
        Task<EmployeeDto> CreateAsync(EmployeeDto employeeDto);
        Task UpdateAsync(int id, UpdateEmployeeDto employeeDto);
        Task DeleteAsync(int id);
    }
}