using System;
using Microsoft.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore.Configurator;
using Reinier.Perks.Models;
using SDG.Unturned;

namespace Reinier.Perks;

public class UserConnectionDbContext: OpenModDbContext<UserConnectionDbContext>
{
    public DbSet<Perk> Perks => Set<Perk>();

    public DbSet<ActiveConnection> ActiveConnections => Set<ActiveConnection>();

    public DbSet<User> Users => Set<User>();
    
    public UserConnectionDbContext(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        
    }

    public UserConnectionDbContext(IDbContextConfigurator configurator, IServiceProvider serviceProvider) : base(
        configurator, serviceProvider)
    {
    }

}