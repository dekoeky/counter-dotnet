
using counter_dotnet;
using Microsoft.Extensions.Options;

//Legacy functionality
var banner = new DefaultWelcomeBannerGenerator();
Console.WriteLine(banner.GetBanner());

var builder = Host.CreateApplicationBuilder(args);

//Add the Service, Service Options and Service Options Validation
builder.Services.Configure<CounterOptions>(builder.Configuration);
builder.Services.AddSingleton<IValidateOptions<CounterOptions>, CounterOptionsValidator>();
builder.Services.AddHostedService<CounterService>();

var host = builder.Build();

host.Run();