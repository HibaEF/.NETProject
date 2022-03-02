﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PS.Domain;
namespace PS.Data
{
    public class PSContext : DbContext
    {
            //les images de contenue des tables-    
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=ProductStoreDB;
                                          Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);

        }
      

    }
}
