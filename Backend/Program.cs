using BlazorWasmAcademyServer.Configurators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwagger();
builder.Services.AddNSwag();
builder.Services.AddCors();

var app = builder.Build();


app.UseCors(opt => opt.WithOrigins("https://localhost:5001","http://localhost:5000").AllowAnyHeader().AllowAnyMethod());

app.UseApplicationSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();