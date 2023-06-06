using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcinterview.Models;

namespace mvcinterview.Data
{
    public class mvcinterviewContext : DbContext
    {
        public mvcinterviewContext (DbContextOptions<mvcinterviewContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Topic> Topic { get; set; } = default!;
    }
}
