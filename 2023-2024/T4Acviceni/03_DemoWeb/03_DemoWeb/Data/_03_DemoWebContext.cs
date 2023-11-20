using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _03_DemoWeb.Models;

namespace _03_DemoWeb.Data
{
    public class _03_DemoWebContext : DbContext
    {
        public _03_DemoWebContext (DbContextOptions<_03_DemoWebContext> options)
            : base(options)
        {
        }

        public DbSet<_03_DemoWeb.Models.Account> Account { get; set; } = default!;
    }
}
