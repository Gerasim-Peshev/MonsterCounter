using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonsterCounter2.Data.Models;

namespace MonsterCounter2.Data
{
    public class MonsterCounter2DbContext : IdentityDbContext<MonsterFan>
    {
        public MonsterCounter2DbContext(DbContextOptions<MonsterCounter2DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}