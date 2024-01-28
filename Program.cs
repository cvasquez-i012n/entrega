using Kalumproject;

public class Program
{

    public static void Main(String [] args)
    {
        CreatHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreatHostBuilder(String[] args) =>
        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => {
            webBuilder.UseStartup<Startup>();
        });
}