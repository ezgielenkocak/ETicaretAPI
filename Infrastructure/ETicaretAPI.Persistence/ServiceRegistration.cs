﻿using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        //bunları IOC Container'a ekliycez
       public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductManager>();

        }
    }
}
