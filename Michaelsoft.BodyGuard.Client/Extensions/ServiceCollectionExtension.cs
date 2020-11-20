﻿using Michaelsoft.BodyGuard.Client.Interfaces;
using Michaelsoft.BodyGuard.Client.Services;
using Michaelsoft.BodyGuard.Client.Settings;
using Michaelsoft.BodyGuard.Common.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Michaelsoft.BodyGuard.Client.Extensions
{
    public static class ServiceCollectionExtension
    {

        public static void AddBodyGuard(this IServiceCollection services,
                                        IConfiguration configuration)
        {
            services.Configure<BodyGuardClientSettings>
                (configuration.GetSection(nameof(BodyGuardClientSettings)));

            services.AddSingleton<IBodyGuardClientSettings>
                (sp => sp.GetRequiredService<IOptions<BodyGuardClientSettings>>().Value);

            services.AddHttpClient();
            services.AddHttpContextAccessor();

            services.AddSingleton<IBodyGuardAuthenticationApiService, BodyGuardAuthenticationApiService>();
            services.AddSingleton<IBodyGuardUserApiService, BodyGuardUserApiService>();
            services.AddSingleton<IBodyGuardAuthorizationApiService, BodyGuardAuthorizationApiService>();

            services.Configure<IdentitySettings>(configuration.GetSection("IdentitySettings"));

        }

    }
}