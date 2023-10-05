
namespace SimpleFeedReader;
public class Program
{
    public static void Main(string[] args)
    {
        ExecuteQuery("Swapnil");
        GetDatabasePassword();
        DisplayMessage("swapnil");
        ExecuteQuery("swapnil");
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

    // SQL Injection Vulnerability Example
    public static void ExecuteQuery(string userInput)
    {
        string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";
        // Execute the query
    }

     // Cross-Site Scripting (XSS) Vulnerability Example
    public string DisplayMessage(string message)
    {
        return "<div>" + message + "</div>";
    }

    // Hardcoded Password Vulnerability Example
    public string GetDatabasePassword()
    {
        return "secretpassword123";
    }

    // SQL Injection Vulnerability Example
    public void ExecuteQuery(string userInput)
    {
        using (var connection = new SqlConnection("your_connection_string"))
        {
            using (var command = new SqlCommand("SELECT * FROM Users WHERE Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", userInput);
                connection.Open();
                // Execute the query
            }
        }
    }
}
