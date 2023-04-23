﻿using ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager;
using ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager;
using ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth;
using ApiSeguridad.DDD.Domain._3._2_DomainService;
using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;
using ApiSeguridad.DDD.Infraestructure._4._1_Repository;
using Microsoft.Extensions.DependencyInjection;
using ServicioAPISeguridad.Infraestructure.Configuration;
using ServicioAPISeguridad.Infraestructure.Interfaces;

namespace ApiProductBooking.DDD.Service.IoC
{
    /// <summary>
    /// 
    /// </summary>
    public static class IoCGeneral
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
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

            #region [Manager]
            service.AddSingleton<IManagerService, ManagerService>();
            service.AddSingleton<IManagerRepository, ManagerRepository>();
            #endregion

            return service;
        }
    }
}
