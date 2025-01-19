using System;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using weEnvanter.Business.DTOs;
using weEnvanter.Data;

namespace weEnvanter.Business.Services
{
    public class UserService : IUserService
    {
        private readonly WeEnvanterDbContext _context;

        public UserService(WeEnvanterDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> AuthenticateAsync(UserLoginDto loginDto)
        {
            var hashedPassword = HashPassword(loginDto.Password);
            
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginDto.Username && 
                                        u.Password == hashedPassword);

            if (user == null)
                return null;

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role
            };
        }

        public async Task<bool> ChangePasswordAsync(int userId, string currentPassword, string newPassword)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
                return false;

            var hashedCurrentPassword = HashPassword(currentPassword);
            if (user.Password != hashedCurrentPassword)
                return false;

            user.Password = HashPassword(newPassword);
            await _context.SaveChangesAsync();
            
            return true;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
} 