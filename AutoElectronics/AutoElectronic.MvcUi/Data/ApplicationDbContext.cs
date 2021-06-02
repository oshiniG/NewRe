using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AutoElectronic.Application.ViewModels;

namespace AutoElectronic.MvcUi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AutoElectronic.Application.ViewModels.ItemViewModel> ItemViewModel { get; set; }
    }
}
