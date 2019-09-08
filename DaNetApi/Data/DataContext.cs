using System;
using System.Threading.Tasks;
using DaNetApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DaNetApi.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) {}

        public DbSet<Post> Posts { get; set; }

        internal Task<Post> SingleOrDefaultAsync(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
