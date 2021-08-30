﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListServer.BL;
using TodoListServer.Entities;

namespace TodoListServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        [AllowAnonymous]
public IActionResult Index()
        {
            return Redirect("/swagger/ui/index.html");
        }
    }
}
