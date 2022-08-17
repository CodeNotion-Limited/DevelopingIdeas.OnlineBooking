using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmAcademyServer.Controllers;

[ApiController]
[Route("calendar-events")]
public class AppointmentDataController : ControllerBase
{
    [HttpGet]
    public List<AppointmentData> GetAll() => Database.CalendarEvents
        .OrderByDescending(x => x.Start)
        .ToList();
}
