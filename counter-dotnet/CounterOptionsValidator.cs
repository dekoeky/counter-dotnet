using Microsoft.Extensions.Options;

namespace counter_dotnet;

public class CounterOptionsValidator : IValidateOptions<CounterOptions>
{
    public ValidateOptionsResult Validate(string? name, CounterOptions options)
    {
        if (options.Stop <= options.Start) return ValidateOptionsResult.Fail($"{nameof(options.Start)} must be smaller than {nameof(options.Stop)}");
        if (options.Delay <= TimeSpan.Zero) return ValidateOptionsResult.Fail("Delay must be larger than 0 seconds");
        return ValidateOptionsResult.Success;
    }
}