using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Podes usar dessa forma mais complexa

        // string server = "127.0.0.1";
        // string port = "1433";
        // string database = "PROJECTO_DB";
        // string user = "eliude";
        // string pass = "MyS3rv3r@2024!!"; // Chama o método para ler a senha
        // string connectionString = $"Server={server},{port};Database={database};User Id={user};Password={pass};Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true";

        // Ou podes usar dessa forma

        string connectionString = "Server=127.0.0.1,1433;Database=PROJECTO_DB;User Id=eliude;Password=MyS3rv3r@2024!!;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true";

        using SqlConnection connection = new(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Conexão bem-sucedida!");

            // Exemplo de consulta SQL
            // string sql = "SELECT @@VERSION";
            // using SqlCommand command = new(sql, connection);
            // string version = (string)command.ExecuteScalar();
            // Console.WriteLine($"Versão do SQL Server: {version}");
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Erro ao conectar ao SQL Server: {ex.Message}");
        }
    }
}
