﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Route("[Controller]")]
    public class DebugController : Controller
    {
        private readonly AppSettings _appSettings;
        public DebugController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appSettings);
        }

    [Route("test")]
    [HttpGet]
    public IActionResult Test()
        {
            return Ok();
        }
    }
}