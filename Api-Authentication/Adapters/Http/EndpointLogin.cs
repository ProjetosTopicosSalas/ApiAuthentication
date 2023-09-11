﻿using Api_Authentication.Domain.DTO;
using Api_Authentication.Domain.Exceptions;
using Api_Authentication.Port.InputboundPort;

namespace Api_Authentication.Adapters.Http
{
    public static class EndpointLogin
    {
        public static void AddEndpointLogin(this WebApplication app)
        {
            
            app.MapPost("/v1/Login", async Task<IResult> (InputLoginUser request, IUseCaseLogin useCase) =>
            {
                try
                {
                    var ret = await useCase.ExecuteLogin(request);
                    return Results.Ok(ret);
                }
                catch (BusinessException ex)
                {
                    return Results.Json(ex.Message, statusCode: 400);
                }
                catch (Exception ex)
                {
                    return Results.Json(ex.Message, statusCode: 500);
                }
            });
        }
    }
}
