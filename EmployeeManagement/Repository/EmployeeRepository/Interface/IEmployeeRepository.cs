using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.EmployeeRepository.Interface
{
    public interface IEmployeeRepository
    {
        Task AddUser(Users user);
    }
}
