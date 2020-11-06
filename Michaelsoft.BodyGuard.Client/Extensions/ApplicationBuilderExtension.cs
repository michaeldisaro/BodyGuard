﻿using Michaelsoft.BodyGuard.Common.BaseClasses;
using Microsoft.AspNetCore.Builder;

namespace Michaelsoft.BodyGuard.Client.Extensions
{
    public static class ApplicationBuilderExtension
    {

        public static void AddBodyGuard(this IApplicationBuilder app)
        {
            InjectableServicesBaseStaticClass.Services = app.ApplicationServices;
        }

    }
}