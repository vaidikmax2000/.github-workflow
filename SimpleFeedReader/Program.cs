
namespace SimpleFeedReader;
public class Program
{
    public static void Main(string[] args)
    {       
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
    public static string DisplayMessage(string message)
    {
        return "<div>" + message + "</div>";
    }

    // Hardcoded Password Vulnerability Example
    public static string GetDatabasePassword()
    {
        return "secretpassword123";
    }
    
}
