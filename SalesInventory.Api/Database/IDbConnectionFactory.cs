using MySqlConnector;

namespace SalesInventory.Api.Database;

public interface IDbConnectionFactory
{
    Task<MySqlConnection> CreateConnectionAsync(CancellationToken cancellationToken = default);
}