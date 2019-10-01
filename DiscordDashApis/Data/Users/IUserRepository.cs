using DiscordDashApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordDashApis.Data.Users
{
    public interface IUserRepository
    {
        List<User> GetAllUsersByGuild(ulong guildDiscordId);

        List<UserCountData> GetUserCount(ulong guildDiscordId);
    }
}
