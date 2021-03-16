using System;
using Domain.Entities;
using Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Infrastructure.Persistence
{
    public partial class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext() { }

        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options) { }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
        }
    }
}
