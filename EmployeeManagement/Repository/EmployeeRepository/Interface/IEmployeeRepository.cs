using EmployeeManagement.Models;

namespace EmployeeManagement.Repository.EmployeeRepository.Interface
{
    public interface IEmployeeRepository
    {
        Task AddUser(Users user);
        Task<Users> FindUsers(string rg);
        Task EditUsers(Users user);
        Task DeleteUsers(string rg);
        
    }
}
