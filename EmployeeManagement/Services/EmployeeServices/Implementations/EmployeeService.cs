using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Repository.EmployeeRepository.Interface;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services.EmployeeServices.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task AddUser(AddUserDto userDto)
        {
            if (userDto == null) throw new ArgumentNullException("The provided information is null!");

            if (string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.Departament) || string.IsNullOrWhiteSpace(userDto.Rg))
                throw new ArgumentException("One or more fields is empty or null");

            var user = new Users(userDto.Name, userDto.Rg, userDto.Departament);

            await _employeeRepository.AddUser(user);
        }
    }
}
