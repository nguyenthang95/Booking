using Booking.Instrastructure.Configurations;
using Booking.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Instrastructure.Context
{
    public class BookingDbContext : IdentityDbContext<Account>, IDbContext
    {
        private readonly IConfiguration _configuration;

        public BookingDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccountConfiguration());

            base.OnModelCreating(builder);
        }

        public Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
