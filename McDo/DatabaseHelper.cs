using MySql.Data.MySqlClient;
using System;

public class DatabaseHelper
{
    private readonly string connectionString =
        "server=localhost;user=root;password=Tantan#0119;database=mcdonalds_db;port=3306;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
