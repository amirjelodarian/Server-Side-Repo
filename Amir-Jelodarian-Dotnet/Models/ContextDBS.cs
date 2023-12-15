using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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