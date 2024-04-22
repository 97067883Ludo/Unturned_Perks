using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NuGet.Common;
using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.Movement.Events;
using ILogger = NuGet.Common.ILogger;

namespace Reinier.Perks.EventListners;

public class OnPlayerTeleported : IEventListener<UnturnedPlayerTeleportingEvent>
{
    private readonly ILogger<MyOpenModPlugin> _logger;
    
    public OnPlayerTeleported(ILogger<MyOpenModPlugin> logger)
    {
        _logger = logger;
    }

    public Task HandleEventAsync(object sender, UnturnedPlayerTeleportingEvent @event)
    {
        _logger.LogInformation($"{@event.Player.Player.name} teleported");

        return Task.CompletedTask;
    }
}