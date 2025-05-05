using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repository.EmployeeRepository.Interface;
using EmployeeManagement.Utils.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.EmployeeRepository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
         _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddUser(Users user)
        {

          var newUser =  await _context.Users.AnyAsync(u => u.Rg == user.Rg);
            if (newUser)
                throw new ExistingDataInDatabaseException($"User already exists");

            _context.Add(user);
            await _context.SaveChangesAsync();

        }
    }
} 
