using Microsoft.EntityFrameworkCore;
using OdataSampleApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataSampleApp.Data
{
    public class IMSDbcontext : DbContext
    {
        public IMSDbcontext(DbContextOptions<IMSDbcontext> options) : base(options)
        {

        }

        public  DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // below line to watch the ef core sql quiries generation
            // not at all recomonded for the production code
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
