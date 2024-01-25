using System.Text;

namespace counter_dotnet;

public class DefaultWelcomeBannerGenerator : IWelcomeBannerGenerator
{
    public string GetBanner() => GetBanner(DateTime.Now);
    private static string GetBanner(DateTime now) => new StringBuilder()
        .AppendLine($"################################################################")
        .AppendLine($"Welcome to the {ApplicationConstants.ApplicationName} application!")
        .AppendLine($"The date is now {now.Date}")
        .AppendLine($"The time is now {now.TimeOfDay}")
        .AppendLine($"################################################################")
        .ToString();
}
