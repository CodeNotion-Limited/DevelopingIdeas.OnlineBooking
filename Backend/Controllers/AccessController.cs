using System.Text;
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
    public async Task<bool> Access(string email)
    {
        if (IsRegistered(email))
        {
            return await OpenLockAsync();
        }

        return false;
    }

    private async Task<bool> OpenLockAsync()
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", "Bearer 6vMsGPUamPsu-GZ0Ejod3eLZ52zzD155zdj1_1OCka4.EF18tsVU8P1gkTnxMGjCBq7hNGaS56GyLDaXWEwI5_I");
        var result = await client.PostAsync("https://api.nuki.io/smartlock/17988037356/action", new StringContent("{\"action\":3,\"option\":0}", Encoding.Default, "application/json"));
        return result.IsSuccessStatusCode;
    }
}