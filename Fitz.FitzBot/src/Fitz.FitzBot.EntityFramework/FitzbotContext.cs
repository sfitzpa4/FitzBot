using Fitz.FitzBot.EntityFramework.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework
{
    public class FitzBotContext : DbContext
    {
        public FitzBotContext(DbContextOptions<FitzBotContext> options)
            :   base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server-(localdb)\\mssqllocaldb;Database=FitzBotDb;Trusted_Connection=True;MultipleActiveResultSets-true");
            base.OnConfiguring(builder);
        }

        public DbSet<TwitchChannel> TwitchChannels { get; set; }

        public DbSet<BotStats> BotStats { get; set; }

        public DbSet<DiscordGuild> DiscordGuilds { get; set; }

        public DbSet<DiscordUser> DiscordUsers { get; set; }

        public DbSet<YouTubeChannel> YouTubeChannels { get; set; }
    }
}
