using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        // string server = "169.239.134.139";
        // string database = "PROJECTO_DB";
        // string user = "eliude";
        // string pass = "B3sT_P@ssw0rd"; // Chama o método para ler a senha

        // string connectionString = $"Server={server};Database={database};User Id={user};Password={pass};Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true";

        string connectionString = "Server=127.0.0.1,1433;Database=SODIAM_DB;User Id=SA;Password=MyS3rv3r@2024!!;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true";

        using SqlConnection connection = new(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Conexão bem-sucedida!");

            // Exemplo de consulta SQL
            string sql = "SELECT @@VERSION";
            using SqlCommand command = new(sql, connection);
            string version = (string)command.ExecuteScalar();
            Console.WriteLine($"Versão do SQL Server: {version}");
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Erro ao conectar ao SQL Server: {ex.Message}");
        }
    }
}
