using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Properties;

public class FallbackController : Controller
{
    public IActionResult Index()
    {
        return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),
         "wwwroot", "index.html"), "text/HTML"); 
    }
}
