using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUserAsync();//Es una firma de un método
        Task<User> GetUserByIdAsync(Guid Id);
        Task<User> CreateUserAsync(User user);
        Task<User> EditUserAsync(User user);
        Task<User> DeleteUserAsync(Guid Id);
    }
}
