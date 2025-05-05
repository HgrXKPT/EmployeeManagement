using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Components.Pages
{
    public partial class AddEmployee
    {
        [Inject]
        public IEmployeeService _employeeService
        {
            get;set;
        }

            private AddUserDto userDto = new AddUserDto();
            

           private async Task AddUser()
            {
        
                Console.WriteLine($"Name: {userDto.Name}, Rg: {userDto.Rg}, Departament: {userDto.Departament}");
           

            if (string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.Departament) || string.IsNullOrWhiteSpace(userDto.Rg))
                return;

            await _employeeService.AddUser(userDto);

            StateHasChanged();

            

            }

    }
}
