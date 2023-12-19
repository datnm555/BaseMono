using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BaseMono.DapperRepository;

public class DapperDbContext
{
    private readonly IConfiguration _configuration;


    public DapperDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("sqlConnection"));
}