using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TelegramBot.Common.Factories;

namespace TelegramBot.Common.Extensions
{
    public static class BotModule
    {
        public static IServiceCollection AddTelegramBot(this IServiceCollection services, IConfiguration configuration) 
        {
            var client = TelegramBotClientFactory.GetBotClient(configuration);

            return services
                .AddSingleton(client);
        }
    }
}
