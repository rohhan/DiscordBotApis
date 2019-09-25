using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Data;
using DiscordBotApis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscordBotApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuildsController : ControllerBase
    {
        private IGuildRepository _guildRepository;

        public GuildsController(IGuildRepository guildRepository)
        {
            _guildRepository = guildRepository;
        }

        //GET guilds
        [HttpGet]
        public ActionResult<List<Guild>> Get()
        {
            var guilds = _guildRepository.GetGuilds();

            return Ok(guilds);
        }

        [HttpGet("{id}")]
        public ActionResult<Guild> Get(ulong id)
        {
            var guild = _guildRepository.GetGuildById(id);

            if (guild == null)
            {
                return NotFound("The Guilds record couldn't be found.");
            }

            return Ok(guild);
        }

        [HttpGet("{id}/users")]
        public ActionResult<List<User>> GetUsers(ulong id)
        {
            var users = _guildRepository.GetUsersByGuildId(id);

            return Ok(users);
        }
    }
}