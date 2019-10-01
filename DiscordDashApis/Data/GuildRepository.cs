using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordDashApis.Models;

namespace DiscordDashApis.Data
{
    public class GuildRepository : IGuildRepository
    {
        private DiscordBotApiDbContext _guildContext;

        public GuildRepository(DiscordBotApiDbContext context)
        {
            _guildContext = context;
        }

        public GuildResponseModel GetGuildById(ulong id)
        {
            var guild = _guildContext.Guilds
                .FirstOrDefault(g => g.GuildDiscordId == id);

            var guildResponse = Map(guild);

            return guildResponse;
        }

        public List<GuildResponseModel> GetGuilds()
        {
            var guilds = _guildContext.Guilds.ToList();

            var guildsResponse = guilds.Select(g => Map(g)).ToList();

            return guildsResponse;
        }

        public List<User> GetUsersByGuildId(ulong guildId)
        {
            throw new NotImplementedException();
        }

        private GuildResponseModel Map(Guild guild)
        {
            return new GuildResponseModel()
            {
                DateAdded = guild.DateAdded,
                DateCreated = guild.DateCreated,
                GuildDiscordId = guild.GuildDiscordId.ToString(),
                GuildName = guild.GuildName,
                OwnerId = guild.OwnerId.ToString()
            };
        }
    }
}