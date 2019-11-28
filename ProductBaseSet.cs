using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ProductBase
{
    class ProductBaseSet:DbContext
    {
        public DbSet<ProductDefinition> MyBase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Productsl.db");
    }
}
