using EmployeeAPI.Models.Entities;
using EmployeeAPI.Models.DTOs;
using EmployeeAPI.Repositories;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
        {
            var employees = await _repository.GetAllAsync();
            return employees.Select(MapToDto);
        }

        public async Task<EmployeeDto?> GetByIdAsync(int id)
        {
            var employee = await _repository.GetByIdAsync(id);
            return employee != null ? MapToDto(employee) : null;
        }

        public async Task<EmployeeDto> CreateAsync(EmployeeDto employeeDto)
        {
            if (await _repository.EmpNoExistsAsync(employeeDto.EmpNo))
            {
                throw new InvalidOperationException("Employee number already exists");
            }

            var employee = MapToEntity(employeeDto);
            var created = await _repository.CreateAsync(employee);
            return MapToDto(created);
        }

        public async Task UpdateAsync(int id, UpdateEmployeeDto employeeDto)
        {
            if (!await _repository.ExistsAsync(id))
            {
                throw new KeyNotFoundException("Employee not found");
            }

            var existingEmployee = await _repository.GetByIdAsync(id);
            if (existingEmployee == null) throw new KeyNotFoundException("Employee not found");


            existingEmployee.EmpNo = employeeDto.EmpNo ?? existingEmployee.EmpNo;
            existingEmployee.EmpName = employeeDto.EmpName ?? existingEmployee.EmpName;
            existingEmployee.EmpAddressLine1 = employeeDto.EmpAddressLine1 ?? existingEmployee.EmpAddressLine1;
            existingEmployee.EmpAddressLine2 = employeeDto.EmpAddressLine2 ?? existingEmployee.EmpAddressLine2;
            existingEmployee.EmpAddressLine3 = employeeDto.EmpAddressLine3 ?? existingEmployee.EmpAddressLine3;
            existingEmployee.EmpDateOfJoin = employeeDto.EmpDateOfJoin ?? existingEmployee.EmpDateOfJoin;
            existingEmployee.EmpStatus = employeeDto.EmpStatus ?? existingEmployee.EmpStatus;
            existingEmployee.EmpImage = employeeDto.EmpImage ?? existingEmployee.EmpImage;

            await _repository.UpdateAsync(existingEmployee);
        }


        public async Task DeleteAsync(int id)
        {
            if (!await _repository.ExistsAsync(id))
            {
                throw new KeyNotFoundException("Employee not found");
            }

            await _repository.DeleteAsync(id);
        }

        private static EmployeeDto MapToDto(Employee employee)
        {
            return new EmployeeDto
            {
                EmpNo = employee.EmpNo,
                EmpName = employee.EmpName,
                EmpAddressLine1 = employee.EmpAddressLine1,
                EmpAddressLine2 = employee.EmpAddressLine2,
                EmpAddressLine3 = employee.EmpAddressLine3,
                EmpDateOfJoin = employee.EmpDateOfJoin,
                EmpStatus = employee.EmpStatus,
                EmpImage = employee.EmpImage
            };
        }

        private static Employee MapToEntity(EmployeeDto dto)
        {
            return new Employee
            {
                EmpNo = dto.EmpNo,
                EmpName = dto.EmpName,
                EmpAddressLine1 = dto.EmpAddressLine1,
                EmpAddressLine2 = dto.EmpAddressLine2,
                EmpAddressLine3 = dto.EmpAddressLine3,
                EmpDateOfJoin = dto.EmpDateOfJoin,
                EmpStatus = dto.EmpStatus,
                EmpImage = dto.EmpImage
            };
        }
    }
}