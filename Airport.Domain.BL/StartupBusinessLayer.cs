using Airport.Domain.DAL.Repository;
using Airport.Domain.DAL.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.BL
{
    public class StartupBusinessLayer
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IAirplanesTypesRepository, AirplanesTypesRepository>();            
        }
    }
}
