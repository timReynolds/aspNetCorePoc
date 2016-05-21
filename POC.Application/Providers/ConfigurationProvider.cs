namespace POC.Application.Providers
{
    public class ConfigurationProvider : IDbConfigurationProvider
    {
        public ConfigurationProvider(string databaseConnectionString)
        {
            DatabaseConnectionString = databaseConnectionString;
        }

        public string DatabaseConnectionString { get; }
    }
}
