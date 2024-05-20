using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Cysharp.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpenMod.Unturned.Plugins;
using OpenMod.API.Plugins;

// For more, visit https://openmod.github.io/openmod-docs/devdoc/guides/getting-started.html

[assembly: PluginMetadata("Reinier.Perks", DisplayName = "Reinier.Perks")]

namespace Reinier.Perks
{
    public class MyOpenModPlugin : OpenModUnturnedPlugin
    {
        private readonly IConfiguration m_Configuration;
        private readonly IStringLocalizer m_StringLocalizer;
        private readonly ILogger<MyOpenModPlugin> m_Logger;
        private readonly UserConnectionDbContext _context;

        public MyOpenModPlugin(
            IConfiguration configuration,
            IStringLocalizer stringLocalizer,
            ILogger<MyOpenModPlugin> logger,
            UserConnectionDbContext dbContext,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            m_Configuration = configuration;
            m_StringLocalizer = stringLocalizer;
            m_Logger = logger;
            _context = dbContext;
        }

        protected override async UniTask OnLoadAsync()
        {
            // await UniTask.SwitchToMainThread(); uncomment if you have to access Unturned or UnityEngine APIsf
            m_Logger.LogInformation("Hello World!");

            if (await _context.Database.CanConnectAsync()) 
            { 
                await _context.Database.MigrateAsync();
            }
            // await UniTask.SwitchToThreadPool(); // you can switch back to a different thread
        }

        protected override async UniTask OnUnloadAsync()
        {
            // await UniTask.SwitchToMainThread(); uncomment if you have to access Unturned or UnityEngine APIs
            m_Logger.LogInformation(m_StringLocalizer["plugin_events:plugin_stop"]);
        }
    }
}