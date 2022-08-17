namespace BlazorWasmAcademyServer;

public static class Database
{
    public static readonly List<Appointment> CalendarEvents = new()
    {
        new() {Start = DateTime.Today.AddDays(-2), End = DateTime.Today.AddDays(-2), Text = "SERVER Birthday", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddDays(-11), End = DateTime.Today.AddDays(-10), Text = "SERVER Day off", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddDays(-10), End = DateTime.Today.AddDays(-8), Text = "SERVER Work from home", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(12), Text = "SERVER Online meeting", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(18), Text = "SERVER Skype call", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddHours(14), End = DateTime.Today.AddHours(14).AddMinutes(30), Text = "SERVER Dentist appointment", UserEmail = "dennisbattisti.26@gmail.com"},
        new() {Start = DateTime.Today.AddDays(1), End = DateTime.Today.AddDays(12), Text = "SERVER Vacation", UserEmail = "dennisbattisti.26@gmail.com"}
    };
}