using AutoElectronic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Infrastructure.Data
{
    public class AutoElectronicDbContext : DbContext
    {
        public AutoElectronicDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Item> Item { get; set; }
    }
}