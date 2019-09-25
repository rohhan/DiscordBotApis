using DiscordBotApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data.Users
{
    public class MockUserRepository : IUserRepository
    {
        private DiscordBotApiDbContext _context;

        public MockUserRepository(DiscordBotApiDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsersByGuild(ulong guildDiscordId)
        {
            return new List<User>()
            {
                new User() { Username = "Bobby" },
                new User() { Username = "Mickey Mouse" }
            };
        }

        /// <summary>
        /// Returns essentially key-value pairs of a random date tied to a random number of users
        /// </summary>
        /// <param name="guildDiscordId"></param>
        /// <returns></returns>
        public List<UserCountData> GetUserCount(ulong guildDiscordId)
        {
            var userCountDataList = new List<UserCountData>();

            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();

                // Generate random date
                DateTime start = new DateTime(2005, 1, 1);
                int range = (DateTime.Today - start).Days;
                var randomDate = start.AddDays(random.Next(range));

                // Generate random number (of users)
                var randomInt = random.Next(1, 50);

                userCountDataList.Add(new UserCountData() { Date = randomDate, Count = randomInt });
            }

            // The list needs to be ordered by date in order for the line graph in the UI to properly display
            List<UserCountData> sortedList = userCountDataList.OrderBy(ucd => ucd.Date).ToList();

            return sortedList;
        }
    }
}
