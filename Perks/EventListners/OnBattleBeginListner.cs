using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OpenMod.API.Eventing;
using OpenMod.API.Users;
using OpenMod.Extensions.Games.Abstractions.Players;
using OpenMod.Unturned.Users;
using SDG.Unturned;

namespace Reinier.Perks.EventListners;

public class OnBattleBeginListner : IEventListener<IPlayerSpawnedEvent>
{
    private readonly ILogger<MyOpenModPlugin> _logger;
    
    private readonly IUnturnedUserDirectory _userDirectory;
    
    public OnBattleBeginListner(ILogger<MyOpenModPlugin> logger, IUnturnedUserDirectory unturnedUserDirectory)
    {
        
        _logger = logger;
        _userDirectory = unturnedUserDirectory;
    }

    public Task HandleEventAsync(object sender, IPlayerSpawnedEvent @event)
    {
        _logger.LogInformation("start logging");

        var animals = AnimalManager.animals;

        if (animals == null)
        {
            return Task.CompletedTask;
        }

        var unturnedUser = _userDirectory.FindUser(@event.Player.EntityInstanceId, UserSearchMode.FindById);

        if (unturnedUser == null)
        {
            _logger.LogInformation("User not foud.");
            return Task.CompletedTask;
        }
        _logger.LogInformation("stop logging");
        _logger.LogInformation("Players are spawned");
        
        return Task.CompletedTask;
    }
}