using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task<User> GetByUsernameAsync(string username);
        Task<bool> IsUsernameUniqueAsync(string username);
        Task<bool> ValidateCredentialsAsync(string username, string password);
        Task<bool> ChangePasswordAsync(int userId, string currentPassword, string newPassword);
        Task<bool> ResetPasswordAsync(int userId, string newPassword);
        Task<bool> UpdateUserRoleAsync(int userId, UserRole role);
        Task<bool> CanBeDeletedAsync(int userId);
    }
} 