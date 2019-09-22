using DiscordBotApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data
{
    public interface IGuildRepository
    {
        List<GuildResponseModel> GetGuilds();

        GuildResponseModel GetGuildById(ulong id);

        List<User> GetUsersByGuildId(ulong guildId);
    }
}