
namespace SimpleFeedReader;
public class Program
{
    public static void Main(string[] args)
    {
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
}
