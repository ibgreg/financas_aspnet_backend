using System;
using System.Collections.Generic;
using System.Text;
using financas_aspnet_backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace financas_aspnet_backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Despesa> Despesa { get; set; }
    }
}
