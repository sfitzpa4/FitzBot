using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework
{
    public class FitzBotContextFactory : IDbContextFactory<FitzBotContext>
    {
        public FitzBotContext Create(DbContextFactoryOptions options)
        {
            DbContextOptionsBuilder<FitzBotContext> builder = new DbContextOptionsBuilder<FitzBotContext>();
            builder.UseSqlServer("Server-(localdb)\\mssqllocaldb;Database=FitzBotDb;Trusted_Connection=True;MultipleActiveResultSets-true");
            return new FitzBotContext(builder.Options);
        }
    }
}
