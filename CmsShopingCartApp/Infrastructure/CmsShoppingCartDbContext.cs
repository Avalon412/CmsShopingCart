using CmsShopingCartApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShopingCartApp.Infrastructure
{
    public class CmsShoppingCartDbContext : DbContext
    {
        public CmsShoppingCartDbContext(DbContextOptions<CmsShoppingCartDbContext> options)
            : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
