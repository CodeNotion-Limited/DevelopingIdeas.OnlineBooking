using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmAcademyServer.Controllers;

[ApiController]
[Route("calendar-events")]
public class AppointmentDataController : ControllerBase
{
    [HttpGet]
    public List<Appointment> GetAll() => Database.CalendarEvents
        .OrderByDescending(x => x.Start)
        .ToList();

    [HttpPut]
    public void Create([FromBody] Appointment data) => Database.CalendarEvents.Add(data);
}