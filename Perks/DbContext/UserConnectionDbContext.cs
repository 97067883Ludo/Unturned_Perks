using System;
using OpenMod.API.Plugins;
using OpenMod.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore.Configurator;
using OpenMod.EntityFrameworkCore.MySql.Extensions;

namespace Reinier.Perks.DbContext;

public class UserConnectionDbContext: OpenModDbContext<UserConnectionDbContext>
{
    public UserConnectionDbContext(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public UserConnectionDbContext(IDbContextConfigurator configurator, IServiceProvider serviceProvider) : base(configurator, serviceProvider)
    {
    }
    
    
}

public class PluginContainerConfigurator : IPluginContainerConfigurator
{
    public void ConfigureContainer(IPluginServiceConfigurationContext context)
    {
        // You can extend how your database context works by using the overloads of this method.
        context.ContainerBuilder.AddMySqlDbContext<UserConnectionDbContext>();
    }
}