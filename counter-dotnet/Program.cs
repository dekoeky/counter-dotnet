
using counter_dotnet;
using Microsoft.Extensions.Configuration;

//Build the configuration
var configuration = new ConfigurationBuilder()
    .AddApplicationDefaults()
    .AddJsonFile("appsettings.json", optional: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

//Extract application parameters
var start = configuration.GetValue<ulong>(IConfigurationNames.START);
var stop = configuration.GetValue<ulong>(IConfigurationNames.STOP);
var delay_s = configuration.GetValue<double>(IConfigurationNames.DELAY);
var delay = TimeSpan.FromSeconds(delay_s);

//Create the counter
var counter = new Counter<ulong>(start, stop, delay);

//Run the application
await counter.RunAsync();