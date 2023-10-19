﻿using Api_Authentication.Domain.Application.UseCase;
using Api_Authentication.Port.InputboundPort;

namespace Api_Authentication.Infrastructure.Extensions
{
    public static class DomainExtensions
    {
        public static void AddDomainExtensions(this IServiceCollection services)
        {
            services.AddScoped<IUseCaseRegister, UseCaseRegister>();
            services.AddScoped<IUseCaseLogin, UseCaseLogin>();

        }

    }
}