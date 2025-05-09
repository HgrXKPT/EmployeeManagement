using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Models;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Components.Pages
{
    public partial class EditEmployee
    {

        [Inject]
        public IEmployeeService _employeeService
        {
            get; set;
        }

        private bool exibirFormulario = true;

        private EditUserDto newUser = new EditUserDto();
        private Users savedUser = new Users();
        private async Task FindUsers()
        {
           exibirFormulario = false;
           savedUser = await _employeeService.FindUsers(newUser);
            newUser = new EditUserDto();
        }

        private async Task EditUsers()
        {
            await _employeeService.EditUser(newUser, savedUser);
        }


        private void ReturnToHome()
        {
            Thread.Sleep(1000);
            exibirFormulario = true;
        }
    }
}
