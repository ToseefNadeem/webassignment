using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Toseefstore.Models;

namespace Toseefstore.Data
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext (DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }

        public DbSet<Toseefstore.Models.OrderModel> OrderModel { get; set; }
    }
}
