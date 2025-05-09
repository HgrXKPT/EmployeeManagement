using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DTOs.EmployeeDtos
{
    public class DeleteUserDto
    {

        [Required]
        public string? Rg
        {
            get; set;
        }

      
    }
}
