using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class DiscordGuild
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DiscordUser Owner { get; set; }
        public List<DiscordUser> Users { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<TwitchChannel> TwitchChannels { get; set; }
        public List<YouTubeChannel> YouTubeChannels { get; set; }

        public GuildConfiguration GuildConfiguration { get; set; }
    }
}
