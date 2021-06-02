using AutoElectronic.Application.Interfaces;
using AutoElectronic.Application.Services;
using AutoElectronic.Domain.Interfaces;
using AutoElectronic.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Infrastructure.IOC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IItemRepository, ItemRepository>();
        }
    }
}
