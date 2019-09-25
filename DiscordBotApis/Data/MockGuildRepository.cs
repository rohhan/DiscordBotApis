using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;

namespace DiscordBotApis.Data
{
    public class MockGuildRepository : IGuildRepository
    {
        public List<GuildResponseModel> GetGuilds()
        {
            var guild = new GuildResponseModel();

            var guildList = new List<GuildResponseModel>() { guild };

            return guildList;
        }

        public GuildResponseModel GetGuildById(ulong id)
        {
            var guild = new GuildResponseModel();

            return guild;
        }

        public List<User> GetUsersByGuildId(ulong guildId)
        {
            var user = new User();

            var userList = new List<User>() { user };

            return userList;
        }
    }
}