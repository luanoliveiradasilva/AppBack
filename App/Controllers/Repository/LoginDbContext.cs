using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Controllers.Repository
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}