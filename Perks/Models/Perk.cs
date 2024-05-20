using System;
using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;

namespace Reinier.Perks.Models;


[Command("perk")]
[CommandSyntax("[Add]|[Delete]|[Select] <Name> <points>")]
public class Perk : UnturnedCommand
{
    public Perk(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    protected override UniTask OnExecuteAsync() 
    { 
        throw new NotImplementedException();
    }
}