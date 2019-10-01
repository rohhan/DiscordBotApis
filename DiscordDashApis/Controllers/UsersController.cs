using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordDashApis.Data.Users;
using DiscordDashApis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscordDashApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _userRepo;

        public UsersController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("{guildDiscordId}")]
        public ActionResult<List<User>> Get(ulong guildDiscordId)
        {
            var users = _userRepo.GetAllUsersByGuild(guildDiscordId);

            return Ok(users);
        }

        [HttpGet("count/{guildDiscordId}")]
        public ActionResult GetUserCount(ulong guildDiscordId)
        {
            var userCount = _userRepo.GetUserCount(guildDiscordId);

            return Ok(userCount);
        }
    }
}