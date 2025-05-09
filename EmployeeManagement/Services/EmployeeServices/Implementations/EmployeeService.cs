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
            CheckIfDtoIsNull(userDto);

            if (string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.Departament) || string.IsNullOrWhiteSpace(userDto.Rg))
                throw new ArgumentException("One or more fields is empty or null");

            var user = new Users(userDto.Name, userDto.Rg, userDto.Departament);
           
            await _employeeRepository.AddUser(user);
        }

        public async Task<Users> FindUsers(EditUserDto userDto)
        {
            CheckIfDtoIsNull(userDto);
            Users user = await _employeeRepository.FindUsers(userDto.Rg);

            return user;     
        }

        public async Task EditUser(EditUserDto userDto, Users savedUser)
        {
            CheckIfDtoIsNull(userDto);

            savedUser.Name = userDto.Name;
            savedUser.Rg = userDto.Rg;
            savedUser.Departament = userDto.departament;
            
            await _employeeRepository.EditUsers(savedUser);
        


        }

        public async Task DeleteUser(DeleteUserDto userDto)
        {
        
            await _employeeRepository.DeleteUsers(userDto.Rg);
        }

        private void CheckIfDtoIsNull<T1>(T1 dto1)
        {
            if(dto1== null) 
                throw new ArgumentNullException("The provided information is null!");
        }
    }
}
