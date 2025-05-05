using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DTOs.EmployeeDtos
{
    public class AddUserDto
    {
        [Required]
        public string Name
        {
            get; set;
        }

        [Required]
        public string Rg
        {
            get; set;
        }

        [Required]
        public string Departament
        {
            get; set;
        }

    }
    
}
