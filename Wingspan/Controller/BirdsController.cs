using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wingspan.Model;
using Wingspan.Services;

namespace Wingspan.Controller
{
    [ApiController]
    [Route("rest/")]
    public class BirdsController : ControllerBase
    {
        private readonly IBirdServices _birdServices;

        public BirdsController(IBirdServices birdServices)
        {
            _birdServices = birdServices;
        }

        [HttpGet("birds")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public List<Bird> GetAllBirds()
        {
            return _birdServices.GetAllBirds();
        }
    }
};
