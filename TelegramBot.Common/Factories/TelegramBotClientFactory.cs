using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using TelegramBot.Common.Settings;

namespace TelegramBot.Common.Factories
{
    public static class TelegramBotClientFactory
    {
        public static ITelegramBotClient GetBotClient(IConfiguration configuration) 
        {
            var settings = configuration.GetSection(nameof(BotSettings)).Get<BotSettings>();

            var client = new TelegramBotClient(settings.Token);
            client.SetWebhookAsync(settings.HookUrl).GetAwaiter().GetResult();

            return client;
        }
    }
}
