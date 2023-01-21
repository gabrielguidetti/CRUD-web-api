using CRUD_web_api.Models;

namespace CRUD_web_api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Get(long id);
        Task<IEnumerable<User>> GetAll();

        Task<User> Add(User model);
        Task<User> Update(User model, long id);
        Task<bool> Remove(long id);
    }
}
