using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ChallengerKenner1._0.Models;

namespace ChallengerKenner1._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProdutoModel> ProdutoModel { get; set; }
        public DbSet<LogAuditoriaModel> LogAuditoriaModel{ get; set; }
    }
}
