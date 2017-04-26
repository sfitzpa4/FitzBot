using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class DiscordUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public TwitchChannel TwitchChannel { get; set; }
        public YouTubeChannel YouTubeChannel { get; set; }

    }
}
