using Microsoft.Extensions.DependencyInjection;

namespace ApiSeguridad.DDD.Transversal._5._1_IoC
{
    public static class IoCGeneral
    {
        public static IServiceCollection AddRegistration(this IServiceCollection service)
        {

            //service.AddSingleton<IConnectionFactory, ConnectionFactory>();

            //service.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            //service.AddSingleton<IUsuarioDomain, UsuarioDomain>();
            //service.AddSingleton<IUsuarioApplication, UsuarioApplication>();

            return service;
        }
    }
}
