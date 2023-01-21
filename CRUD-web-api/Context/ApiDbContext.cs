using CRUD_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_web_api.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
