using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DTOs.EmployeeDtos
{
    public class EditUserDto
    {

        public int Id
        {
            get; set;
        }
        [Required]
        public string? Name
        {
            get; set;
        }

        [Required]
        public string? Rg
        {
            get; set;
        }

        public string? departament
        {
        
        get; set;}


    }
}
