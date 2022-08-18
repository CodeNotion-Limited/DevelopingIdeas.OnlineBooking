namespace BlazorWasmAcademyServer;

public record Appointment
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Text { get; set; }
    public string UserEmail { get; set; }
    
}