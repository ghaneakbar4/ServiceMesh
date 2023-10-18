﻿using Microsoft.EntityFrameworkCore;
using Ordering.API.Models;

namespace Ordering.API.Db
{
    public class OrderingContext : DbContext
    {
        public OrderingContext(DbContextOptions<OrderingContext> options) : base(options)
        {

        }
        public DbSet<Ordering.API.Models.Order> Order { get; set; }
    }
}
