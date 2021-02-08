using Airport.Domain.BL;
using Airport.Domain.BL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.Services
{
    public class StartupServices
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IAirplanesTypesBL, AirplanesTypesBL>();
            StartupBusinessLayer.ConfigureServices(services, connectionString);
        }
    }
}
