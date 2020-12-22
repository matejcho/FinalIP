using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalIP.Models;

namespace FinalIP.Data
{
    public class FinalIPContext : DbContext
    {
        public FinalIPContext (DbContextOptions<FinalIPContext> options)
            : base(options)
        {
        }

        public DbSet<FinalIP.Models.User> User { get; set; }
    }
}
