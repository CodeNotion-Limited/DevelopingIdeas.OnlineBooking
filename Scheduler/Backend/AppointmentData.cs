namespace BlazorWasmAcademyServer;

public record AppointmentData
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Text { get; set; }
    public object Data { get; set; }
    
}