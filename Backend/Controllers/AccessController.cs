using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmAcademyServer.Controllers;

[ApiController]
[Route("access")]
public class AccessController : ControllerBase
{
    [HttpGet("is-registered")]
    public bool IsRegistered(string email) => Database.CalendarEvents
        .Where(x => x.Start <= DateTime.Now)
        .Where(x => x.End >= DateTime.Now)
        .Any(x => x.UserEmail == email);

    [HttpPut]
    public bool Access(string email)
    {
        if (IsRegistered(email))
        {
            // TODO: Dario implement Nuki Access
            return true;
        }

        return false;
    }
}