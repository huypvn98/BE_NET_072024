using DataAccess.NetCore.DO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DBContext
{
    public class BE_072024dDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BE_072024dDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<BE072024_HB_Rooms>? bE072024_HB_Rooms { get; set; }
        public DbSet<BE072024_HB_TypeBeds>? bE072024_HB_Hotels { get; set; }

    }
}
