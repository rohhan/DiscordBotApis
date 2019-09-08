using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;

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
            return new List<User>()
            {
                new User() { Username = "Bobby" }
            };
        }
    }
}
