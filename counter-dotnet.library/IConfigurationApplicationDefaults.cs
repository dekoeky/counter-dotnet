using System.Globalization;
using static counter_dotnet.IConfigurationNames;

namespace counter_dotnet;
public static class IConfigurationApplicationDefaults
{
    private readonly static CultureInfo culture = CultureInfo.InvariantCulture;

    public static readonly ulong start = 0;
    public static readonly ulong stop = ulong.MaxValue;
    public static readonly TimeSpan delay = TimeSpan.FromSeconds(1);

    internal static readonly IReadOnlyDictionary<string, string?> values
        = new Dictionary<string, string?>()
        {
        { START , start.ToString(culture)               },
        { STOP  , stop.ToString(culture)                },
        { DELAY , delay.TotalSeconds.ToString(culture)  },
        }.AsReadOnly();
}