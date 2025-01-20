using System;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }

        public async Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user == null)
                return false;

            var hashedPassword = HashPassword(password);
            return user.Password == hashedPassword;
        }

        public async Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword)
        {
            var user = await GetByIdAsync(userId);
            if (user == null)
                throw new ArgumentException("Kullanıcı bulunamadı.");

            var hashedOldPassword = HashPassword(oldPassword);
            if (user.Password != hashedOldPassword)
                throw new InvalidOperationException("Mevcut şifre hatalı.");

            user.Password = HashPassword(newPassword);
            user.ModifiedDate = DateTime.Now;

            await UpdateAsync(user);
            return true;
        }

        public override async Task<User> AddAsync(User user)
        {
            if (string.IsNullOrEmpty(user.Username))
                throw new ArgumentException("Kullanıcı adı boş olamaz.");

            if (string.IsNullOrEmpty(user.Password))
                throw new ArgumentException("Şifre boş olamaz.");

            var existingUser = await _userRepository.GetByUsernameAsync(user.Username);
            if (existingUser != null)
                throw new InvalidOperationException("Bu kullanıcı adı zaten kullanılıyor.");

            user.Password = HashPassword(user.Password);
            user.CreatedDate = DateTime.Now;
            
            return await base.AddAsync(user);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public async Task<bool> IsUsernameUniqueAsync(string username)
        {
            return await _userRepository.IsUsernameUniqueAsync(username);
        }

        public async Task<bool> ResetPasswordAsync(int userId, string newPassword)
        {
            var user = await GetByIdAsync(userId);
            if (user == null)
                throw new ArgumentException("Kullanıcı bulunamadı.");

            user.Password = HashPassword(newPassword);
            user.ModifiedDate = DateTime.Now;

            await UpdateAsync(user);
            return true;
        }

        public async Task<bool> UpdateUserRoleAsync(int userId, UserRole role)
        {
            var user = await GetByIdAsync(userId);
            if (user == null)
                throw new ArgumentException("Kullanıcı bulunamadı.");

            user.Role = role;
            user.ModifiedDate = DateTime.Now;

            await UpdateAsync(user);
            return true;
        }

        public async Task<bool> CanBeDeletedAsync(int userId)
        {
            var user = await GetByIdAsync(userId);
            if (user == null)
                return false;

            // Admin kullanıcısı silinemez
            if (user.Role == UserRole.Admin)
                return false;

            return true;
        }
    }
} 