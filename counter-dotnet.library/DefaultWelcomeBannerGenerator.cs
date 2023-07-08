using System.Text;

namespace counter_dotnet;

public class DefaultWelcomeBannerGenerator : IWelcomeBannerGenerator
{
    public string GetBanner()
    {
        var stringBuilder = new StringBuilder();
      
        var now = DateTime.Now;
        stringBuilder.AppendLine($"################################################################");
        stringBuilder.AppendLine($"Welcome to the {ApplicationConstants.ApplicationName} application!");
        stringBuilder.AppendLine($"The date is now {now.Date}");
        stringBuilder.AppendLine($"The time is now {now.TimeOfDay}");
        stringBuilder.AppendLine($"If you need the weather, i suggest searching the internet");
        stringBuilder.AppendLine($"################################################################");

        return stringBuilder.ToString();
    }
}
