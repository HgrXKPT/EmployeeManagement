using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using EmployeeManagement.Utils.Exceptions;

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

            await _employeeService.AddUser(userDto);

            StateHasChanged();
        }


    }
}
