
using NintendoApi.Models;
using NintendoApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NintendoApi.controllers {

    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase {
        private readonly GamesService _gamesService;

        public GamesController(GamesService gamesService) {
            _gamesService = gamesService;
        }

        [HttpGet]
        public ActionResult<List<Games>> Get() {
            return _gamesService.Get();
        }
    }
}