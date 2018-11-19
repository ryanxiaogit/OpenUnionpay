using CoreServices.Settings.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.Settings
{
    public static class SettingExtensions
    {
        public static void AddCoreServiceSetting(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServicesSettingOption>(configuration.GetSection("ServiceSetting"));
            services.Configure<MessageSettingOption>(configuration.GetSection("MessageSetting"));
        }
    }
}
