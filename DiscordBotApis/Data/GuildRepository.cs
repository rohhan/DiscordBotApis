using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;

namespace DiscordBotApis.Data
{
    public class GuildRepository : IGuildRepository
    {
        private DiscordBotApiDbContext _guildContext;

        public GuildRepository(DiscordBotApiDbContext context)
        {
            _guildContext = context;
        }

        public Guild GetGuildById(ulong id)
        {
            return _guildContext.Guilds
                .FirstOrDefault(g => g.GuildDiscordId == id);
        }

        public List<Guild> GetGuilds()
        {
            return _guildContext.Guilds.ToList();
        }

        public List<User> GetUsersByGuildId(ulong guildId)
        {
            throw new NotImplementedException();
        }
    }
}