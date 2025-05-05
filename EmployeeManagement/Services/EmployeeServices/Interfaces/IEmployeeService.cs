using EmployeeManagement.DTOs.EmployeeDtos;

namespace EmployeeManagement.Services.EmployeeServices.Interfaces
{
    public interface IEmployeeService
    {
         Task AddUser(AddUserDto userDto);
    }
}
