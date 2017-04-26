using Discord.Commands;
using Discord.WebSocket;
using Fitz.FitzBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Fitz.FitzBot.Bot
{
    public class Program
    {
        private DependencyMap map;
        private CommandService commands;
        private DiscordSocketClient client;

        public static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();
        
        public async Task Start()
        {
            await DoBotStuff();

            await Task.Delay(-1);
        }

        private async Task DoBotStuff()
        {
            map = new DependencyMap();
            commands = new CommandService();
            client = new DiscordSocketClient();

            await ConfigureEventHandlers();
            await InstallCommands();
            Console.WriteLine("Logging In");
            await client.LoginAsync(Discord.TokenType.Bot, Constants.DiscordToken);
            Console.WriteLine("Logged In");
            Console.WriteLine("Connecting");
            await client.StartAsync();
            Console.WriteLine("Connected. Awaiting Instruction");
        }


        private async Task ConfigureEventHandlers()
        {
            client.MessageReceived += Client_MessageReceived;
        }

        private async Task InstallCommands()
        {
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        private async Task Client_MessageReceived(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;

            if (message == null)
            {
                return;
            }

            int argPos = 0;
            if (!(message.HasStringPrefix("!fitz ", ref argPos)))
            {
                return;
            }

            var context = new CommandContext(client, message);
            var result = await commands.ExecuteAsync(context, argPos, map);
        }
    }
}
