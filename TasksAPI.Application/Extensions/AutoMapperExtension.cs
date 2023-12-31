﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksAPI.Application.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services) 
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
