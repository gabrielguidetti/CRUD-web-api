using CRUD_web_api.Context;
using CRUD_web_api.Models;
using CRUD_web_api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUD_web_api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiDbContext _context;

        public UserRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<User> Add(User model)
        {
            await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<User> Get(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<bool> Remove(long id)
        {
            var user = await Get(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User> Update(User model, long id)
        {
            User user = await Get(id);
            user.Nome= model.Nome;
            user.Profissao= model.Profissao;

            _context.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
