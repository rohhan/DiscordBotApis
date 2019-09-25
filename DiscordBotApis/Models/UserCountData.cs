using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class UserCountData
    {
        public DateTimeOffset? Date { get; set; }

        public int Count { get; set; }
    }
}
