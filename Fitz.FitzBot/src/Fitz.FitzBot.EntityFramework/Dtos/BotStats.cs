using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class BotStats
    {
        public int Id { get; set; }

        public int TwitchAlertCount { get; set; }

        public int YouTubeAlertCount { get; set; }

        public int UptimeMinutes { get; set; }

        public DateTime LoggingStartDate { get; set; }

        public DateTime LastRestartDate { get; set; }
    }
}
