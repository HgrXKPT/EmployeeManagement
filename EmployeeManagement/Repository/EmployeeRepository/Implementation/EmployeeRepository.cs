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

        public async Task<Users> FindUsers(string rg)
        {
            var users = await SelectUsers(rg);
            if (users == null)
                throw new KeyNotFoundException("User doens't exists");

            return users;
           
        }

        public async Task EditUsers(Users user)
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteUsers(string rg)
        {
         var users = await SelectUsers(rg);
            if(users != null)
            {
                _context.Users.Remove(users);
                await _context.SaveChangesAsync();
            }
           
        }

        private async Task<Users> SelectUsers(string rg)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Rg == rg);
        }
    }
} 
