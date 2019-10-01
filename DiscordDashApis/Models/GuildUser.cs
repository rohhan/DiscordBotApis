using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordDashApis.Models
{
    public class GuildUser
    {
        public int UserId { get; set; }

        public int GuildId { get; set; }

        public User User { get; set; }

        public Guild Guild { get; set; }

        public DateTimeOffset? ActionDate { get; set; }

        public GuildUserActionEnum ActionType { get; set; }

        public DateTimeOffset? DateLastActive { get; set; }
    }
}
