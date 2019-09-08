using DiscordBotApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data.Users
{
    public interface IUserRepository
    {
        List<User> GetAllUsersByGuild(ulong guildDiscordId);
    }
}
