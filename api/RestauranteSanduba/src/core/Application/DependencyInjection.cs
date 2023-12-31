﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestauranteSanduba.Core.Application.Abstraction.Cardapios;
using RestauranteSanduba.Core.Application.Abstraction.Clientes;
using RestauranteSanduba.Core.Application.Abstraction.Pedidos;
using RestauranteSanduba.Core.Application.Cardapios;
using RestauranteSanduba.Core.Application.Clientes;
using RestauranteSanduba.Core.Application.Pedidos;

namespace RestauranteSanduba.Core.Application
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Registers the necessary services with the DI framework.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>The same service collection.</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPedidoService, PedidoService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<ICardapioService, CardapioService>(); 

            return services;
        }
    }
}
