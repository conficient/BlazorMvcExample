using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMvcExample.Server.Controllers
{
    public class MvcController : Controller
    {
        /// <summary>
        /// This method is public, confirms routing
        /// </summary>
        /// <returns></returns>
        [HttpGet("mvc/public")] public IActionResult Public() => Content("<h1>This view is public</h1>");
        
        [Authorize, HttpGet("mvc/private")] public IActionResult Private() => Content("<h1>This view is private</h1>");
    }
}
