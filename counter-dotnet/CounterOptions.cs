namespace counter_dotnet;

public class CounterOptions
{
    public ulong Start { get; set; } = 0;
    public ulong Stop { get; set; } = ulong.MaxValue;

    public TimeSpan Delay { get; init; } = TimeSpan.FromSeconds(1);

    public double DelaySeconds
    {
        get => Delay.TotalSeconds;
        init => Delay = TimeSpan.FromSeconds(value);
    }
    public double DelayMilliseconds
    {
        get => Delay.TotalMilliseconds;
        init => Delay = TimeSpan.FromMilliseconds(value);
    }
}