using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeSite.Models;

namespace RecipeSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RecipeSite.Models.Recipe> Recipe { get; set; }
        public DbSet<RecipeSite.Models.Ingredient> Ingredient { get; set; }
    }
}
