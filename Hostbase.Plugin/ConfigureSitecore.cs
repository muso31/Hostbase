using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sitecore.Framework.Runtime.Configuration;
using Sitecore.Framework.Runtime.Hosting;
using Sitecore.Framework.Runtime.Plugins;

namespace Hostbase.Plugin
{
    public class ConfigureSitecore
    {
        private readonly ISitecoreConfiguration _configuration;
        private readonly ILogger<ConfigureSitecore> _logger;

        public ConfigureSitecore(ISitecoreConfiguration configuration, ILogger<ConfigureSitecore> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Add services services.AddSingleton<ISomeService, SomeService>();
            
        }

        public void Configure(IApplicationBuilder app, ISitecorePluginManager pluginManager, ISitecoreHostingEnvironment hostingEnvironment)
        {
            var plugin = pluginManager.Resolve(this);

            _logger.LogInformation($"The SettingOne value is: { _configuration.GetSection("Sitecore:Hostbase.Plugin:SettingOne").Value }");
            _logger.LogInformation($"Plugin is running, name is: { plugin.PluginName }");
            _logger.LogInformation($"Application name is: { hostingEnvironment.ApplicationName }");
            
        }
    }
}
