using ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth;
using ApiSeguridad.DDD.Domain._3._2_DomainService;
using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;
using ApiSeguridad.DDD.Infraestructure._4._1_Repository;
using Microsoft.Extensions.DependencyInjection;
using ServicioAPISeguridad.Infraestructure.Configuration;
using ServicioAPISeguridad.Infraestructure.Interfaces;

namespace ApiSeguridad.DDD.Service.IoC
{
    public static class IoCGeneral
    {
        public static IServiceCollection AddRegistration(this IServiceCollection service)
        {

            #region [Connection]
            service.AddSingleton<IConnectionFactory, ConnectionFactory>(); 
            #endregion

            #region [Auth]
            service.AddSingleton<IAuthService, AuthService>();
            service.AddSingleton<IAuthDomain, AuthDomain>();
            service.AddSingleton<IAuthRepository, AuthRepository>(); 
            #endregion

            return service;
        }
    }
}
