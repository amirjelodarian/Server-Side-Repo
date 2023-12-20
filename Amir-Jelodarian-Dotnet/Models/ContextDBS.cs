
using Microsoft.EntityFrameworkCore;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class ContextDBS:DbContext
    {
        public ContextDBS(DbContextOptions<ContextDBS> options):base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Contact> Cantact { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}