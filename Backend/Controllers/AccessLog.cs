namespace BlazorWasmAcademyServer.Controllers;

public class AccessLog
{
    public string id { get; set; }
    public object smartlockId { get; set; }
    public int deviceType { get; set; }
    public string authId { get; set; }
    public string name { get; set; }
    public int action { get; set; }
    public int trigger { get; set; }
    public int state { get; set; }
    public bool autoUnlock { get; set; }
    public DateTime date { get; set; }
}