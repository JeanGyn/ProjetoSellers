using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSellers.Models;

namespace ProjetoSellers.Data
{
    public class ProjetoSellersContext : DbContext
    {
        public ProjetoSellersContext (DbContextOptions<ProjetoSellersContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
