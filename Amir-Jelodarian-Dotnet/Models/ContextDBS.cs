
using System.Microsoft.EntityFrameworkCore;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class ContextDBS:DbContext
    {
        public ContextDBS(DbContextOptions<ContextDBS> options):base(options)
        {

        }
        public DbSet<Users> Userss { get; set; }
    }
}