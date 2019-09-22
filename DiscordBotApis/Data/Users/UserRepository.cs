using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace DiscordBotApis.Data.Users
{
    public class UserRepository : IUserRepository
    {
        private DiscordBotApiDbContext _context;

        public UserRepository(DiscordBotApiDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsersByGuild(ulong guildDiscordId)
        {
            var query =
                from users in _context.Users
                join guildUsers in _context.GuildUsers on users.Id equals guildUsers.UserId
                where guildUsers.Guild.GuildDiscordId == guildDiscordId
                select users;

            var usersInGuild = query.ToList();

            return usersInGuild;
        }

        public List<UserCountData> GetUserCount(ulong guildDiscordId)
        {
            var userCountData = new List<UserCountData>();

            var numberUsersInGuild = 0;

            var usersInGuild = _context.GuildUsers
                .Where(gu => gu.Guild.GuildDiscordId == guildDiscordId)
                .OrderBy(g => g.ActionDate)
                .ToList();

            foreach (var user in usersInGuild)
            {
                if (user.ActionType == GuildUserActionEnum.Joined)
                {
                    numberUsersInGuild++;
                }
                else if (user.ActionType == GuildUserActionEnum.Left 
                    || user.ActionType == GuildUserActionEnum.Kicked 
                    || user.ActionType == GuildUserActionEnum.Banned)
                {
                    numberUsersInGuild--;
                }

                userCountData.Add(new UserCountData()
                {
                    Count = numberUsersInGuild,
                    Date = user.ActionDate
                });
            }

            return userCountData;
        }
    }
}
