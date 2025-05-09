using EmployeeManagement.DTOs.EmployeeDtos;
using EmployeeManagement.Models;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Components.Pages
{
    public partial class DeleteEmployee
    {
        [Inject]
        public IEmployeeService _employeeService
        {
            get; set;
        }

        private bool exibirFormulario = true;
        private DeleteUserDto newUser = new DeleteUserDto();
        

        private async Task DeleteUser()
        {
            exibirFormulario = false;
            await _employeeService.DeleteUser(newUser);
        }
    }
}
