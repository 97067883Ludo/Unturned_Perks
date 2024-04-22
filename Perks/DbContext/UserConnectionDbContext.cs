using System;
using Microsoft.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore.Configurator;
using Reinier.Perks.Models;

namespace Reinier.Perks.DbContext;

public class UserConnectionDbContext: OpenModDbContext<UserConnectionDbContext>
{
    public UserConnectionDbContext(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public UserConnectionDbContext(IDbContextConfigurator configurator, IServiceProvider serviceProvider) : base(configurator, serviceProvider)
    {
    }

    public DbSet<UserConnection> UserConnections => Set<UserConnection>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserConnection>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<UserConnection>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}