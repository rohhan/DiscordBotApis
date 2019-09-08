using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class GuildUser
    {
        public int UserId { get; set; }

        public int GuildId { get; set; }

        public User User { get; set; }

        public Guild Guild { get; set; }

        public DateTimeOffset? DateJoined { get; set; }

        public DateTimeOffset? DateLeft { get; set; }

        public DateTimeOffset? DateLastActive { get; set; }
    }
}
