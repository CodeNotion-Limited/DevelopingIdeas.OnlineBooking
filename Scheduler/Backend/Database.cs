namespace BlazorWasmAcademyServer;

public static class Database
{
    public static readonly AppointmentData[] CalendarEvents =
    {
        new() {Start = DateTime.Today.AddDays(-2), End = DateTime.Today.AddDays(-2), Text = "SERVER Birthday"},
        new() {Start = DateTime.Today.AddDays(-11), End = DateTime.Today.AddDays(-10), Text = "SERVER Day off"},
        new() {Start = DateTime.Today.AddDays(-10), End = DateTime.Today.AddDays(-8), Text = "SERVER Work from home"},
        new() {Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(12), Text = "SERVER Online meeting"},
        new() {Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(13), Text = "SERVER Skype call"},
        new() {Start = DateTime.Today.AddHours(14), End = DateTime.Today.AddHours(14).AddMinutes(30), Text = "SERVER Dentist appointment"},
        new() {Start = DateTime.Today.AddDays(1), End = DateTime.Today.AddDays(12), Text = "SERVER Vacation"}
    };
}