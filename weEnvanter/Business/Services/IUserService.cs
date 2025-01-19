using System.Threading.Tasks;
using weEnvanter.Business.DTOs;

namespace weEnvanter.Business.Services
{
    public interface IUserService
    {
        Task<UserDto> AuthenticateAsync(UserLoginDto loginDto);
        Task<bool> ChangePasswordAsync(int userId, string currentPassword, string newPassword);
    }
} 