namespace POC.Application.Providers
{
    public interface IDbConfigurationProvider
    {
        string DatabaseConnectionString { get; }
    }
}