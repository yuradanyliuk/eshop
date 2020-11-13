using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop.Models.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eshop.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        private IConfiguration _Configuration { get; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options, IConfiguration conf) : base(options)
        {
            _Configuration = conf;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
