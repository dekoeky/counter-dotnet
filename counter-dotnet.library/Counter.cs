using System.Numerics;

namespace counter_dotnet;

public class Counter<T> where T : INumber<T>
{
    private readonly T start;
    private readonly T stop;
    private readonly TimeSpan delay;

    public Counter(T start, T stop, TimeSpan delay)
    {
        this.start = start;
        this.stop = stop;
        this.delay = delay;
    }
    public void Run()
    {
        Console.WriteLine($"Counting from '{start}' to '{stop}' with a delay of {delay}");

        T i = start;

        while (i < stop)
        {
            //Sleep
            Thread.Sleep(delay);

            //Count
            i++;

            //Print
            Console.WriteLine(i);
        }

        Console.WriteLine($"Count reached stop value '{stop}'");
    }

    public async Task RunAsync(CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"Counting from '{start}' to '{stop}' with a delay of {delay}");

        T i = start;

        while (i < stop)
        {
            //Sleep
            await Task.Delay(delay, cancellationToken);

            //Count
            i++;

            //Print
            Console.WriteLine(i);
        }

        Console.WriteLine($"Count reached stop value '{stop}'");
    }
}