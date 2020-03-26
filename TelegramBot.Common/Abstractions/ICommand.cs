using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Common.Abstractions
{
    public interface ITelegramCommand
    {
        string Name { get; set; }

        bool Contain(Message message);

        Task ExecuteAsync(Message message, ITelegramBotClient client);
    }
}
