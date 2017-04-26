using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.Bot.Modules
{
    public class BaseCommands : ModuleBase
    {
        [Command("echo")]
        public async Task Echo([Summary("Message we want to repeat back.")] string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            await Context.Channel.SendMessageAsync("User - " + Context.User.Username + " said.. " + message + " at " + DateTime.UtcNow);
            
        }
        [Command("live")]
        public async Task Live()
        {
            await Context.Channel.SendMessageAsync("Fitz is streaming live at https://www.twitch.tv/24fitz");
        }
    }
}
