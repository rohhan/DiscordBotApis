using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class GuildResponseModel
    {
        /// <summary>
        /// The date that the guild was created according to Discord.
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// The date that the guild was added to our database.
        /// </summary>
        public DateTimeOffset DateAdded { get; set; }

        public string GuildDiscordId { get; set; }

        public string GuildName { get; set; }

        public string OwnerId { get; set; }
    }
}
