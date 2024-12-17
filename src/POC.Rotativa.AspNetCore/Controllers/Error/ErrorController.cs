using Microsoft.AspNetCore.Mvc;
using POC.Rotativa.AspNetCore.Models.Error;
using System.Diagnostics;

namespace POC.Rotativa.AspNetCore.Controllers.Error;

public class ErrorController : Controller
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}