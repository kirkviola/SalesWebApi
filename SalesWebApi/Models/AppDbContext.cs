﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class AppDbContext : DbContext
    {
        // DbSet collections go here
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderline> Orderlines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base (options)
        {

        }
        // For Fluent Api statements
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        
    }
}
