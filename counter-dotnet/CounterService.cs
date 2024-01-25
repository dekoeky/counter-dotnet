using Microsoft.Extensions.Options;

namespace counter_dotnet;

public class CounterService : BackgroundService
{
    private readonly CounterOptions _options;

    public CounterService(IOptions<CounterOptions> options)
    {
        _options = options.Value;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine($"Counting from '{_options.Start}' to '{_options.Stop}' with a delay of {_options.Delay}");

        ulong i = _options.Start;

        while (i < _options.Stop)
        {
            //Sleep
            await Task.Delay(_options.Delay, stoppingToken);

            //Count
            i++;

            //Print
            Console.WriteLine(i);
        }

        Console.WriteLine($"Count reached stop value '{_options.Stop}'");
    }
}