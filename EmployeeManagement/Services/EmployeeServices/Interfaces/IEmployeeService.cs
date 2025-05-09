using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services.EmployeeServices.Interfaces
{
    public interface IEmployeeService
    {
         Task AddUser(AddUserDto userDto);
        Task<Users> FindUsers(EditUserDto userDto);

        Task EditUser(EditUserDto userDto, Users user);
        
        Task DeleteUser(DeleteUserDto userDTO);

    }
}
