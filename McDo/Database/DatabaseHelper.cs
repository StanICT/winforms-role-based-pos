using MySqlConnector;
using System;

public class DatabaseHelper
{
    private readonly string connectionString =
        $"server=localhost;user=root;password={Environment
            .GetEnvironmentVariable("PASSWORD")};database={Environment.GetEnvironmentVariable("DB_FILE")};port=3306;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
