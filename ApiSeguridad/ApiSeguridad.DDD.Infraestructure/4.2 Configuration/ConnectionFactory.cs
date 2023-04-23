using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using ServicioAPISeguridad.Infraestructure.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ServicioAPISeguridad.Infraestructure.Configuration
{
    public class ConnectionFactory : IConnectionFactory
    {
        #region [Properties]
        private readonly IConfiguration _configuration;
        private readonly ILogger<ConnectionFactory> _logger;

        private const string ConnectionStringSeguridad = "DataBaseConnection:SQLServer:BDSeguridad";
        private const string ConnectionStringPideloPues = "DataBaseConnection:SQLServer:BDPideloPues";
        #endregion

        #region [Constructor]
        public ConnectionFactory(IConfiguration configuration, ILogger<ConnectionFactory> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        #endregion

        #region [Properties]
        public IDbConnection GetConnectionSeguridad
        {
            get { return DBPideloPuesSQLServer(_configuration.GetSection(ConnectionStringSeguridad).Value); }
        }

        public IDbConnection GetConnectionPideloPues
        {
            get { return DBPideloPuesSQLServer(_configuration.GetSection(ConnectionStringPideloPues).Value); }
        }
        #endregion

        #region [Methods]
        public IDbConnection DBPideloPuesSQLServer(string pDataBase)
        {
            var connection = new SqlConnection();

            try
            {
                if (connection == null) return null;

                connection.ConnectionString = pDataBase;
                connection.Open();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: " + ex.Message.ToString());
            }
            return connection;
        }

        public IDbConnection DBConnectionOracleDeveloper(string pDataBase)
        {
            var connection = new OracleConnection();

            try
            {
                if (connection == null) return null;

                connection.ConnectionString = pDataBase;
                connection.Open();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: " + ex.Message.ToString());
            }
            return connection;
        } 
        #endregion
    }
}
