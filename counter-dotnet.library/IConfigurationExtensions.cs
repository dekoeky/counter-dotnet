using Microsoft.Extensions.Configuration;

namespace counter_dotnet;

public static class IConfigurationExtensions
{
    public static IConfigurationBuilder AddApplicationDefaults(this IConfigurationBuilder builder)
        => builder.AddInMemoryCollection(IConfigurationApplicationDefaults.values);
}